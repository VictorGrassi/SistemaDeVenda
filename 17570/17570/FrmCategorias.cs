//Bibliotecas usadas pelos form
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
    public partial class FrmCategorias : Form
    {
        //Variavel do tipo boolean para teste de campos
        bool Empty;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        //Função para teste de campos
        void NotEmpty()
        {
            //Verifica se o campo em questão tem conteudo nulo ou apenas espaçamentos
            if (String.IsNullOrWhiteSpace(txtDescricao.Text)) Empty = true; else Empty = false;
        }

        //Função para limpar o form
        void limpar()
        {
            txtID.Clear();
            txtDescricao.Clear();
            txtPesquisa.Clear();
            dgvCategorias.ClearSelection();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            //Carrega o grid com a função do global
            dgvCategorias.DataSource = Global.ConsultarCategorias("");
            //Deixa invisivel a primeira coluna do DatGrid
            dgvCategorias.Columns[0].Visible = false;
            int Sort = 0; while (Sort < dgvCategorias.ColumnCount)
            { dgvCategorias.Columns[Sort].SortMode = DataGridViewColumnSortMode.NotSortable; Sort++; }
            limpar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            NotEmpty();
            //Teste para verificar resultado da função e prosseguir ou retornar
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            //Abre conexão
            Global.Conexao.Open();
            //Instrução Mysql
            Global.Comando = new MySqlCommand("INSERT INTO categorias (descricao) VALUES (?descricao)", Global.Conexao);
            //Parametros da instrução
            Global.Comando.Parameters.AddWithValue("?descricao", txtDescricao.Text);
            //Executa Instrução
            Global.Comando.ExecuteNonQuery();
            //Fecha conexão
            Global.Conexao.Close();

            limpar();
            dgvCategorias.DataSource = Global.ConsultarCategorias("");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            try
            {
                NotEmpty();
                if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                Global.Comando = new MySqlCommand("UPDATE categorias set descricao = ?descricao where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(txtID.Text));
                Global.Comando.Parameters.AddWithValue("?descricao", txtDescricao.Text);
                Global.Comando.ExecuteNonQuery();

                limpar();
                dgvCategorias.DataSource = Global.ConsultarCategorias("");
            }
            catch
            {
                MessageBox.Show("Para Atualizar selecione uma linha", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Global.Conexao.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            dgvCategorias.DataSource = Global.ConsultarCategorias("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text)) { MessageBox.Show("Selecione um registro para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Deseja realmente excluir a Categoria? " + txtDescricao.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("DELETE FROM categorias where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", txtID.Text);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                limpar();
                dgvCategorias.DataSource = Global.ConsultarCategorias("");
            }
        }

        //Impressão de dados
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Maximiza pagina de impressão
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            //Exibe pagina de impressão
            printPreviewDialog1.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Exibe mensagem, com botoes sim e não, icone de questão, com foco no segundo botão, e if para caso for sim, fechar o form
            if (MessageBox.Show("Deseja realmente fechar o formulario? ", "Fechando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Faz pesquisa do que foi digitado no campo, basiado na variavel descrição do Global.ConsultarCategorias e exibe no datagrid
            dgvCategorias.DataSource = Global.ConsultarCategorias(txtPesquisa.Text);
            txtPesquisa.Clear();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if verificando se existe pelo menos 1 linha
            if (dgvCategorias.RowCount > 0)
            {
                //Joga nos campos os registros das colunas das linhas selecionadas
                txtID.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //Formulação da pagina de impressão
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            //Criação de Escrita, seguido pela escrita, font (tamanho e negrito), cor e posição
            e.Graphics.DrawString("Relatorios de Categorias", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 190, 10);
            //Criação de linha, e sua posição
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("ID", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Descrição", new Font("Arial", 10), Brushes.Black, 130, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);

            posicao = 100;

            //Laço de repetição com variavel linha do tipo datagrid, que vai executar pela quantidade de linha do dgvCategorias
            foreach (DataGridViewRow linha in dgvCategorias.Rows)
            {
                //If para criar outra pagina (!Está com erro!)
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 130, posicao);

                itens++;
            }
        }
    }
}