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
    public partial class FrmCentroCusto : Form
    {
        bool Empty;

        public FrmCentroCusto()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text)) Empty = true; else Empty = false;
        }

        void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
        }

        private void FrmCentroCusto_Load(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = Global.ConsultarCentroCusto("");
            dgvCategorias.Columns[0].Visible = false;
            LimparCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO Centro_Custo (descricao) VALUE (?descricao) ", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?descricao", txtNome.Text);
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            LimparCampos();
            dgvCategorias.DataSource = Global.ConsultarCentroCusto("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("UPDATE Centro_Custo SET descricao = ?descricao WHERE id = ?id", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?descricao", txtNome.Text);
            Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            LimparCampos();
            dgvCategorias.DataSource = Global.ConsultarCentroCusto("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            dgvCategorias.DataSource = Global.ConsultarCentroCusto("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir o Custo? " + txtNome.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM Centro_Custo where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                LimparCampos();
                dgvCategorias.DataSource = Global.ConsultarCidades("");
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
            dgvCategorias.DataSource = Global.ConsultarCentroCusto(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatório de Centro de Custo", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 140, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("Descrição", new Font("Arial", 10), Brushes.Black, 150, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);

            posicao = 100;

            foreach (DataGridViewRow linha in dgvCategorias.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }
                posicao += 30;
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 150, posicao);

                itens++;
            }
        }
    }
}