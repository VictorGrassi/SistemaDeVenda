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
    public partial class FrmClientes : Form
    {
        bool Empty;

        public FrmClientes()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(mtbDataNasc.Text) ||
                String.IsNullOrWhiteSpace(txtRG.Text) || String.IsNullOrWhiteSpace(txtCPF.Text) ||
                String.IsNullOrWhiteSpace(txtEndereco.Text) || String.IsNullOrWhiteSpace(txtBairro.Text) ||
                cboCidades.SelectedIndex < 0) Empty = true;
            else Empty = false;
        }

        void Limpar()
        {
            txtID.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtFone.Clear();
            txtCel.Clear();
            txtEmail.Clear();
            txtRenda.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
            mtbDataNasc.Clear();
            cboCidades.SelectedValue = 0;
            chkBloqueado.Checked = false;
            picImagem.ImageLocation = "";
            dgvClientes.ClearSelection();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cboCidades.DataSource = Global.ConsultarCidades("");
            cboCidades.DisplayMember = "Cidade";
            cboCidades.ValueMember = "ID";

            dgvClientes.DataSource = Global.ConsultarClientes("");
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[10].Visible = false;
            dgvClientes.Columns[14].Visible = false;

            int Sort = 0; while (Sort < dgvClientes.ColumnCount)
            { dgvClientes.Columns[Sort].SortMode = DataGridViewColumnSortMode.NotSortable; Sort++; }

            Limpar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO clientes(nome, endereco, id_cidade, bairro, cpf, rg, fone, celular, email, renda, data_nasc, foto, bloqueado ) VALUES (?nome, ?endereco, ?id_cidade, ?bairro, ?cpf, ?rg, ?fone, ?celular, ?email, ?renda, ?data_nasc, ?foto, ?bloqueado)", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?nome", txtNome.Text);
            Global.Comando.Parameters.AddWithValue("?endereco", txtEndereco.Text);
            Global.Comando.Parameters.AddWithValue("?id_cidade", cboCidades.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?bairro", txtBairro.Text);
            Global.Comando.Parameters.AddWithValue("?cpf", txtCPF.Text);
            Global.Comando.Parameters.AddWithValue("?rg", txtRG.Text);
            Global.Comando.Parameters.AddWithValue("?fone", txtFone.Text);
            Global.Comando.Parameters.AddWithValue("?celular", txtCel.Text);
            Global.Comando.Parameters.AddWithValue("?email", txtEmail.Text);
            Global.Comando.Parameters.AddWithValue("?renda", Convert.ToDouble(txtRenda.Text));
            Global.Comando.Parameters.AddWithValue("?data_nasc", Convert.ToDateTime(mtbDataNasc.Text));
            Global.Comando.Parameters.AddWithValue("?foto", picImagem.ImageLocation);
            Global.Comando.Parameters.AddWithValue("?bloqueado", Convert.ToBoolean(chkBloqueado.Checked));
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            Limpar();
            dgvClientes.DataSource = Global.ConsultarClientes("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            try
            {
                NotEmpty();
                if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Global.Comando = new MySqlCommand("UPDATE clientes set  nome = ?nome, endereco = ?endereco, id_cidade = ?id_cidade, bairro = ?bairro, cpf = ?cpf, rg = ?rg, fone = ?fone, celular = ?celular, email = ?email, renda = ?renda, data_nasc = ?data_nasc, foto = ?foto, bloqueado = ?bloqueado where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.Parameters.AddWithValue("?nome", txtNome.Text);
                Global.Comando.Parameters.AddWithValue("?endereco", txtEndereco.Text);
                Global.Comando.Parameters.AddWithValue("?id_cidade", cboCidades.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?bairro", txtBairro.Text);
                Global.Comando.Parameters.AddWithValue("?cpf", txtCPF.Text);
                Global.Comando.Parameters.AddWithValue("?rg", txtRG.Text);
                Global.Comando.Parameters.AddWithValue("?fone", txtFone.Text);
                Global.Comando.Parameters.AddWithValue("?celular", txtCel.Text);
                Global.Comando.Parameters.AddWithValue("?email", txtEmail.Text);
                Global.Comando.Parameters.AddWithValue("?renda", Convert.ToDouble(txtRenda.Text));
                Global.Comando.Parameters.AddWithValue("?data_nasc", Convert.ToDateTime(mtbDataNasc.Text));
                Global.Comando.Parameters.AddWithValue("?foto", picImagem.ImageLocation);
                Global.Comando.Parameters.AddWithValue("?bloqueado", Convert.ToBoolean(chkBloqueado.Checked));
                Global.Comando.ExecuteNonQuery();

                Limpar();
                dgvClientes.DataSource = Global.ConsultarClientes("");
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
            dgvClientes.DataSource = Global.ConsultarClientes("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir o Cliente? " + txtNome.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM clientes where id=?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                Limpar();
                dgvClientes.DataSource = Global.ConsultarClientes("");
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
            dgvClientes.DataSource = Global.ConsultarClientes(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void picImagem_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "C:\\";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            if (ofdArquivo.FileName.Length <= 100)
                picImagem.ImageLocation = ofdArquivo.FileName;
            else
                MessageBox.Show("Imagem contem nome ou conjunto de diretorios muito grande", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ConsultarCidades(cboCidades.Text);
            if (Global.datTabela.Rows.Count > 0)
            {
                txtUF.Text = Global.datTabela.Rows[0].Field<String>("UF").ToString();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                txtID.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                mtbDataNasc.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtCPF.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtRG.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtFone.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                txtCel.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
                txtEndereco.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
                txtBairro.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
                cboCidades.SelectedValue = dgvClientes.CurrentRow.Cells[10].Value;
                txtRenda.Text = dgvClientes.CurrentRow.Cells[13].Value.ToString();
                picImagem.ImageLocation = dgvClientes.CurrentRow.Cells[14].Value.ToString();
                chkBloqueado.Checked = Convert.ToBoolean(dgvClientes.CurrentRow.Cells[15].Value);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatorios de Clientes", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 200, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("ID", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Nome", new Font("Arial", 10), Brushes.Black, 125, 95);
            e.Graphics.DrawString("E-mail", new Font("Arial", 10), Brushes.Black, 320, 95);
            e.Graphics.DrawString("Renda", new Font("Arial", 10), Brushes.Black, 570, 95);
            e.Graphics.DrawString("Bloqueado", new Font("Arial", 10), Brushes.Black, 700, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);
            posicao = 100;

            foreach (DataGridViewRow linha in dgvClientes.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 125, posicao);
                e.Graphics.DrawString(linha.Cells[7].Value.ToString(), new Font("Arial", 10), Brushes.Black, 320, posicao);
                e.Graphics.DrawString(linha.Cells[13].Value.ToString(), new Font("Arial", 10), Brushes.Black, 570, posicao);
                e.Graphics.DrawString(linha.Cells[15].Value.ToString(), new Font("Arial", 10), Brushes.Black, 700, posicao);

                itens++;
            }
        }
    }
}