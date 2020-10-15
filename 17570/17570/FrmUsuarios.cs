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
    public partial class FrmUsuarios : Form
    {
        bool Empty;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtSenha.Text)) Empty = true; else Empty = false;
        }

        void Limpar()
        {
            txtID.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            chkAdm.Checked = false;
            dgvUsuarios.ClearSelection();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Global.ConsultarUsuarios("");
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[2].Visible = false;
            int Sort = 0; while (Sort < dgvUsuarios.ColumnCount)
            { dgvUsuarios.Columns[Sort].SortMode = DataGridViewColumnSortMode.NotSortable; Sort++; }
            Limpar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("INSERT INTO usuarios(nome, senha, administrador) VALUES (?nome, ?senha, ?administrador)", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?nome", txtNome.Text);
            Global.Comando.Parameters.AddWithValue("?senha", txtSenha.Text);
            Global.Comando.Parameters.AddWithValue("?administrador", Convert.ToBoolean(chkAdm.Checked));
            Global.Comando.ExecuteNonQuery();
            Global.Conexao.Close();

            Limpar();
            dgvUsuarios.DataSource = Global.ConsultarUsuarios("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            try
            {
                NotEmpty();
                if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Global.Comando = new MySqlCommand("UPDATE usuarios set  nome = ?nome, senha = ?senha, administrador = ?administrador where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.Parameters.AddWithValue("?nome", txtNome.Text);
                Global.Comando.Parameters.AddWithValue("?senha", txtSenha.Text);
                Global.Comando.Parameters.AddWithValue("?administrador", Convert.ToBoolean(chkAdm.Checked));
                Global.Comando.ExecuteNonQuery();

                Limpar();
                dgvUsuarios.DataSource = Global.ConsultarUsuarios("");
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
            dgvUsuarios.DataSource = Global.ConsultarUsuarios("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir o Usuario? " + txtNome.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM usuarios where id=?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                Limpar();
                dgvUsuarios.DataSource = Global.ConsultarUsuarios("");
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

        private void btnPesquisarCidades_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Global.ConsultarUsuarios(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                txtID.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtSenha.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                chkAdm.Checked = Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells[3].Value);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatorios de Usuarios", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 200, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("ID", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Nome", new Font("Arial", 10), Brushes.Black, 130, 95);
            e.Graphics.DrawString("Administrador", new Font("Arial", 10), Brushes.Black, 450, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);
            posicao = 100;

            foreach (DataGridViewRow linha in dgvUsuarios.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 130, posicao);
                e.Graphics.DrawString(linha.Cells[3].Value.ToString(), new Font("Arial", 10), Brushes.Black, 450, posicao);

                itens++;
            }
        }
    }
}