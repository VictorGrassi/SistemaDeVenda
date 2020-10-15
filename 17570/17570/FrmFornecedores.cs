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
    public partial class FrmFornecedores : Form
    {
        bool Empty;

        public FrmFornecedores()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtRazaoSocial.Text) || String.IsNullOrWhiteSpace(txtFantasia.Text) ||
                String.IsNullOrWhiteSpace(txtCNPJ.Text) || String.IsNullOrWhiteSpace(txtIE.Text) ||
                String.IsNullOrWhiteSpace(txtContato.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) ||
                String.IsNullOrWhiteSpace(txtTelefone.Text) || String.IsNullOrWhiteSpace(txtEndereco.Text) ||
                String.IsNullOrWhiteSpace(txtBairro.Text) || cboCidades.SelectedIndex < 0) Empty = true;
            else Empty = false;
        }

        void Limpar()
        {
            txtID.Clear();
            txtRazaoSocial.Clear();
            txtFantasia.Clear();
            txtCNPJ.Clear();
            txtIE.Clear();
            txtContato.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
            cboCidades.SelectedValue = 0;
            dgvFornecedores.ClearSelection();
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            cboCidades.DataSource = Global.ConsultarCidades("");
            cboCidades.DisplayMember = "Cidade";
            cboCidades.ValueMember = "ID";

            dgvFornecedores.DataSource = Global.ConsultarFornecedores("");
            dgvFornecedores.Columns[0].Visible = false;
            dgvFornecedores.Columns[10].Visible = false;

            int Sort = 0; while (Sort < dgvFornecedores.ColumnCount)
            { dgvFornecedores.Columns[Sort].SortMode = DataGridViewColumnSortMode.NotSortable; Sort++; }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO fornecedores(razao_social, fantasia, endereco, bairro, id_cidade, cnpj, ie, fone, contato, email ) VALUES (?razao_social, ?fantasia, ?endereco, ?bairro, ?id_cidade, ?cnpj, ?ie, ?fone, ?contato, ?email)", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?razao_social", txtRazaoSocial.Text);
            Global.Comando.Parameters.AddWithValue("?endereco", txtEndereco.Text);
            Global.Comando.Parameters.AddWithValue("?fantasia", txtFantasia.Text);
            Global.Comando.Parameters.AddWithValue("?id_cidade", cboCidades.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?bairro", txtBairro.Text);
            Global.Comando.Parameters.AddWithValue("?cnpj", txtCNPJ.Text);
            Global.Comando.Parameters.AddWithValue("?ie", txtIE.Text);
            Global.Comando.Parameters.AddWithValue("?fone", txtTelefone.Text);
            Global.Comando.Parameters.AddWithValue("?contato", txtContato.Text);
            Global.Comando.Parameters.AddWithValue("?email", txtEmail.Text);
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            Limpar();
            dgvFornecedores.DataSource = Global.ConsultarFornecedores("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            try
            {
                NotEmpty();
                if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Global.Comando = new MySqlCommand("UPDATE fornecedores set  razao_social = ?razao_social, endereco = ?endereco, fantasia = ?fantasia, id_cidade = ?id_cidade, bairro = ?bairro, cnpj = ?cnpj, ie = ?ie, fone = ?fone, email = ?email, contato = ?contato, email = ?email where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.Parameters.AddWithValue("?razao_social", txtRazaoSocial.Text);
                Global.Comando.Parameters.AddWithValue("?endereco", txtEndereco.Text);
                Global.Comando.Parameters.AddWithValue("?fantasia", txtFantasia.Text);
                Global.Comando.Parameters.AddWithValue("?id_cidade", cboCidades.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?bairro", txtBairro.Text);
                Global.Comando.Parameters.AddWithValue("?cnpj", txtCNPJ.Text);
                Global.Comando.Parameters.AddWithValue("?ie", txtIE.Text);
                Global.Comando.Parameters.AddWithValue("?fone", txtTelefone.Text);
                Global.Comando.Parameters.AddWithValue("?contato", txtContato.Text);
                Global.Comando.Parameters.AddWithValue("?email", txtEmail.Text);
                Global.Comando.ExecuteNonQuery();

                Limpar();
                dgvFornecedores.DataSource = Global.ConsultarFornecedores("");
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
            dgvFornecedores.DataSource = Global.ConsultarFornecedores("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir o Fornecedor? " + txtRazaoSocial.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM fornecedores where id=?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                Limpar();
                dgvFornecedores.DataSource = Global.ConsultarFornecedores("");
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
            dgvFornecedores.DataSource = Global.ConsultarFornecedores(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ConsultarCidades(cboCidades.Text);
            if (Global.datTabela.Rows.Count > 0)
            {
                txtUF.Text = Global.datTabela.Rows[0].Field<String>("UF").ToString();
            }
        }

        private void dgvFornecedoers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFornecedores.RowCount > 0)
            {
                txtID.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
                txtRazaoSocial.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
                txtFantasia.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
                txtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[3].Value.ToString();
                txtIE.Text = dgvFornecedores.CurrentRow.Cells[4].Value.ToString();
                txtContato.Text = dgvFornecedores.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvFornecedores.CurrentRow.Cells[6].Value.ToString();
                txtTelefone.Text = dgvFornecedores.CurrentRow.Cells[7].Value.ToString();
                txtEndereco.Text = dgvFornecedores.CurrentRow.Cells[8].Value.ToString();
                txtBairro.Text = dgvFornecedores.CurrentRow.Cells[9].Value.ToString();
                cboCidades.SelectedValue = dgvFornecedores.CurrentRow.Cells[10].Value;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatorios de Fornecedores", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 145, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("ID", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Empresa", new Font("Arial", 10), Brushes.Black, 90, 95);
            e.Graphics.DrawString("CNPJ", new Font("Arial", 10), Brushes.Black, 350, 95);
            e.Graphics.DrawString("E-mail", new Font("Arial", 10), Brushes.Black, 485, 95);
            e.Graphics.DrawString("Telefone", new Font("Arial", 10), Brushes.Black, 680, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);
            posicao = 100;

            foreach (DataGridViewRow linha in dgvFornecedores.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 90, posicao);
                e.Graphics.DrawString(linha.Cells[3].Value.ToString(), new Font("Arial", 10), Brushes.Black, 350, posicao);
                e.Graphics.DrawString(linha.Cells[6].Value.ToString(), new Font("Arial", 10), Brushes.Black, 485, posicao);
                e.Graphics.DrawString(linha.Cells[7].Value.ToString(), new Font("Arial", 10), Brushes.Black, 680, posicao);

                itens++;
            }
        }
    }
}