using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _17570
{
    public partial class FrmDespesas : Form
    {
        bool Empty;

        public FrmDespesas()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtDescricao.Text) || cboCentro_Custo.SelectedIndex < 0) Empty = true; else Empty = false;
        }

        void LimparCampos()
        {
            txtID.Clear();
            txtDescricao.Clear();
            cboCentro_Custo.SelectedIndex = -1;
            txtPesquisa.Clear();
        }

        private void FrmDespesas_Load(object sender, EventArgs e)
        {
            cboCentro_Custo.DataSource = Global.ConsultarCentroCusto("");
            cboCentro_Custo.DisplayMember = "Descricao";
            cboCentro_Custo.ValueMember = "ID";

            dgvDespesas.DataSource = Global.ConsultarDespesas("");
            dgvDespesas.Columns[0].Visible = false;
            dgvDespesas.Columns[2].Visible = false;
            dgvDespesas.Columns[3].Visible = false;

            LimparCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO Despesas (descricao, ID_Centro_Custo) VALUE (?descricao, ?cc) ", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?descricao", txtDescricao.Text);
            Global.Comando.Parameters.AddWithValue("?cc", cboCentro_Custo.SelectedValue);
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            LimparCampos();
            dgvDespesas.DataSource = Global.ConsultarDespesas("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("UPDATE Despesas SET descricao = ?descricao, ID_Centro_Custo = ?cc WHERE id = ?id", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?descricao", txtDescricao.Text);
            Global.Comando.Parameters.AddWithValue("?cc", cboCentro_Custo.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            LimparCampos();
            dgvDespesas.DataSource = Global.ConsultarDespesas("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            dgvDespesas.DataSource = Global.ConsultarDespesas("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir a Despesa? " + txtDescricao.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM Despesas WHERE id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                LimparCampos();
                dgvDespesas.DataSource = Global.ConsultarDespesas(""); ;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvDespesas.DataSource = Global.ConsultarDespesas(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvDespesas.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgvDespesas.CurrentRow.Cells[1].Value.ToString();
            cboCentro_Custo.Text = dgvDespesas.CurrentRow.Cells[4].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatório de Despesas", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 195, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("Descrição", new Font("Arial", 10), Brushes.Black, 170, 95);
            e.Graphics.DrawString("Centro de Custo", new Font("Arial", 10), Brushes.Black, 470, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);

            posicao = 100;

            foreach (DataGridViewRow linha in dgvDespesas.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }
                posicao += 30;
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 170, posicao);
                e.Graphics.DrawString(linha.Cells[4].Value.ToString(), new Font("Arial", 10), Brushes.Black, 470, posicao);

                itens++;
            }
        }
    }
}