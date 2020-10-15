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
    public partial class FrmCidades : Form
    {
        bool Empty;

        public FrmCidades()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtCidade.Text) || String.IsNullOrWhiteSpace(txtUF.Text)) Empty = true; else Empty = false;
        }

        void Limpar()
        {
            txtID.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
            dgvCidades.ClearSelection();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            dgvCidades.DataSource = Global.ConsultarCidades("");
            dgvCidades.Columns[0].Visible = false;
            int Sort = 0; while (Sort < dgvCidades.ColumnCount)
            { dgvCidades.Columns[Sort].SortMode = DataGridViewColumnSortMode.NotSortable; Sort++; }
            Limpar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (?nome, ?uf)", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?nome", txtCidade.Text);
            Global.Comando.Parameters.AddWithValue("?uf", txtUF.Text);
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            Limpar();
            dgvCidades.DataSource = Global.ConsultarCidades("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            try
            {
                NotEmpty();
                if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Global.Comando = new MySqlCommand("UPDATE cidades set  nome = ?nome, uf = ?uf where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.Parameters.AddWithValue("?nome", txtCidade.Text);
                Global.Comando.Parameters.AddWithValue("?uf", txtUF.Text);
                Global.Comando.ExecuteNonQuery();

                Limpar();
                dgvCidades.DataSource = Global.ConsultarCidades("");
            }
            catch
            {
                MessageBox.Show("Para Atualizar selecione uma linha", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Global.Conexao.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            dgvCidades.DataSource = Global.ConsultarCidades("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir a Cidade? " + txtCidade.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM cidades where id=?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                Limpar();
                dgvCidades.DataSource = Global.ConsultarCidades("");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o formulario? ", "Fechando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvCidades.DataSource = Global.ConsultarCidades(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtID.Text = dgvCidades.CurrentRow.Cells[0].Value.ToString();
                txtCidade.Text = dgvCidades.CurrentRow.Cells[1].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatorios de Cidades", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 215, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("ID", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Cidade", new Font("Arial", 10), Brushes.Black, 130, 95);
            e.Graphics.DrawString("UF", new Font("Arial", 10), Brushes.Black, 450, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);
            posicao = 100;

            foreach (DataGridViewRow linha in dgvCidades.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 130, posicao);
                e.Graphics.DrawString(linha.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, 450, posicao);

                itens++;
            }
        }
    }
}