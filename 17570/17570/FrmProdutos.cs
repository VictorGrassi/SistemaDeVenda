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
using System.Diagnostics;

namespace _17570
{
    public partial class FrmProdutos : Form
    {
        bool Empty;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtDescricao.Text) || String.IsNullOrWhiteSpace(txtCodigoDeBarras.Text) ||
                String.IsNullOrWhiteSpace(txtEstoque.Text) || String.IsNullOrWhiteSpace(txtEstoqueMinimo.Text) ||
                String.IsNullOrWhiteSpace(txtValorVenda.Text) || String.IsNullOrWhiteSpace(txtValorCusto.Text) ||
                cboCategoria.SelectedIndex < 0 || cboFornecedor.SelectedIndex < 0) Empty = true;
            else Empty = false;
        }

        void Fornecedor()
        {
            Global.Comando = new MySqlCommand("SELECT f.ID, f.Razao_social FROM fornecedores f ", Global.Conexao);
            Global.Adaptador = new MySqlDataAdapter(Global.Comando);
            Global.Adaptador.Fill(Global.datTabela = new DataTable());
            cboFornecedor.DataSource = Global.datTabela;
            cboFornecedor.DisplayMember = "Razao_social";
            cboFornecedor.ValueMember = "ID";
        }

        void Limpar()
        {
            txtID.Clear();
            txtDescricao.Clear();
            txtCodigoDeBarras.Clear();
            txtEstoque.Clear();
            txtEstoqueMinimo.Clear();
            txtValorVenda.Clear();
            txtValorCusto.Clear();
            txtVideo.Clear();
            txtPesquisa.Clear();
            chkForaDeLinha.Checked = false;
            cboCategoria.SelectedValue = 0;
            cboFornecedor.SelectedValue = 0;
            picFoto.ImageLocation = "";
            dgvProdutos.ClearSelection();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            Fornecedor();

            cboCategoria.DataSource = Global.ConsultarCategorias("");
            cboCategoria.DisplayMember = "Categoria";
            cboCategoria.ValueMember = "ID";

            dgvProdutos.DataSource = Global.ConsultarProdutos("");
            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[3].Visible = false;
            dgvProdutos.Columns[5].Visible = false;
            dgvProdutos.Columns[12].Visible = false;
            dgvProdutos.Columns[13].Visible = false;
            int Sort = 0; while (Sort < dgvProdutos.ColumnCount)
            { dgvProdutos.Columns[Sort].SortMode = DataGridViewColumnSortMode.NotSortable; Sort++; }
            Limpar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO produtos(descricao, codigoBarra, id_Categoria, id_Fornecedor, estoque, estoqueMinimo, valorVenda, valorCusto, foto, linkVideo, ForaLinha ) VALUES (?descricao, ?codigoBarra, ?id_Categoria, ?id_Fornecedor, ?estoque, ?estoqueMinimo, ?valorVenda, ?valorCusto, ?foto, ?linkVideo, ?ForaLinha)", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?descricao", txtDescricao.Text);
            Global.Comando.Parameters.AddWithValue("?codigoBarra", txtCodigoDeBarras.Text);
            Global.Comando.Parameters.AddWithValue("?id_Categoria", cboCategoria.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?id_Fornecedor", cboFornecedor.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?estoque", Convert.ToDouble(txtEstoque.Text));
            Global.Comando.Parameters.AddWithValue("?estoqueMinimo", Convert.ToDouble(txtEstoqueMinimo.Text));
            Global.Comando.Parameters.AddWithValue("?valorVenda", Convert.ToDouble(txtValorVenda.Text));
            Global.Comando.Parameters.AddWithValue("?valorCusto", Convert.ToDouble(txtValorCusto.Text));
            Global.Comando.Parameters.AddWithValue("?foto", picFoto.ImageLocation);
            Global.Comando.Parameters.AddWithValue("?linkVideo", txtVideo.Text);
            Global.Comando.Parameters.AddWithValue("?ForaLinha", Convert.ToBoolean(chkForaDeLinha.Checked));
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            Limpar();
            dgvProdutos.DataSource = Global.ConsultarProdutos("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            try
            {
                NotEmpty();
                if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Global.Comando = new MySqlCommand("UPDATE produtos set  descricao = ?descricao, codigoBarra = ?codigoBarra, id_Categoria = ?id_Categoria, id_Fornecedor = ?id_Fornecedor" +
                    ", estoque = ?estoque, estoqueMinimo = ?estoqueMinimo, valorVenda = ?valorVenda, valorCusto = ?valorCusto, foto = ?foto, linkVideo = ?linkVideo," +
                    " ForaLinha = ?ForaLinha where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.Parameters.AddWithValue("?descricao", txtDescricao.Text);
                Global.Comando.Parameters.AddWithValue("?codigoBarra", txtCodigoDeBarras.Text);
                Global.Comando.Parameters.AddWithValue("?id_Categoria", cboCategoria.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?id_Fornecedor", cboFornecedor.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?estoque", Convert.ToDouble(txtEstoque.Text));
                Global.Comando.Parameters.AddWithValue("?estoqueMinimo", Convert.ToDouble(txtEstoqueMinimo.Text));
                Global.Comando.Parameters.AddWithValue("?valorVenda", Convert.ToDouble(txtValorVenda.Text));
                Global.Comando.Parameters.AddWithValue("?valorCusto", Convert.ToDouble(txtValorCusto.Text));
                Global.Comando.Parameters.AddWithValue("?foto", picFoto.ImageLocation);
                Global.Comando.Parameters.AddWithValue("?linkVideo", txtVideo.Text);
                Global.Comando.Parameters.AddWithValue("?ForaLinha", Convert.ToBoolean(chkForaDeLinha.Checked));
                Global.Comando.ExecuteNonQuery();

                Limpar();
                dgvProdutos.DataSource = Global.ConsultarProdutos("");
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
            dgvProdutos.DataSource = Global.ConsultarProdutos("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir o Produto? " + txtDescricao.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM produtos where id=?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                Limpar();
                dgvProdutos.DataSource = Global.ConsultarProdutos("");
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

        private void btnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(txtVideo.Text);
            }
            catch
            {
                if (MessageBox.Show("Link Invalido, redirecionamento para Google", "Redirecionamento...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    Process.Start("https://www.google.com");
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = Global.ConsultarProdutos(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "C:\\";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            if (ofdArquivo.FileName.Length <= 100)
                picFoto.ImageLocation = ofdArquivo.FileName;
            else
                MessageBox.Show("Imagem contem nome ou conjunto de diretorios muito grande", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                txtID.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtCodigoDeBarras.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                cboCategoria.SelectedValue = dgvProdutos.CurrentRow.Cells[3].Value;
                cboFornecedor.SelectedValue = dgvProdutos.CurrentRow.Cells[5].Value;
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells[7].Value.ToString();
                txtEstoqueMinimo.Text = dgvProdutos.CurrentRow.Cells[8].Value.ToString();
                txtValorVenda.Text = dgvProdutos.CurrentRow.Cells[9].Value.ToString();
                txtValorCusto.Text = dgvProdutos.CurrentRow.Cells[10].Value.ToString();
                chkForaDeLinha.Checked = Convert.ToBoolean(dgvProdutos.CurrentRow.Cells[11].Value.ToString());
                picFoto.ImageLocation = dgvProdutos.CurrentRow.Cells[12].Value.ToString();
                txtVideo.Text = dgvProdutos.CurrentRow.Cells[13].Value.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatorios de Fornecedores", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 145, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("ID", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Produto", new Font("Arial", 10), Brushes.Black, 140, 95);
            e.Graphics.DrawString("Código de Barras", new Font("Arial", 10), Brushes.Black, 320, 95);
            e.Graphics.DrawString("Categoria", new Font("Arial", 10), Brushes.Black, 490, 95);
            e.Graphics.DrawString("Fora de Linha", new Font("Arial", 10), Brushes.Black, 630, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);
            posicao = 100;

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 140, posicao);
                e.Graphics.DrawString(linha.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, 320, posicao);
                e.Graphics.DrawString(linha.Cells[4].Value.ToString(), new Font("Arial", 10), Brushes.Black, 490, posicao);
                e.Graphics.DrawString(linha.Cells[11].Value.ToString(), new Font("Arial", 10), Brushes.Black, 630, posicao);

                itens++;
            }
        }
    }
}