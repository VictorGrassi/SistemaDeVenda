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
    public partial class FrmConVenda : Form
    {
        public FrmConVenda()
        {
            InitializeComponent();
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

        private void FrmConVenda_Load(object sender, EventArgs e)
        {
            Fornecedor();

            cboCategoria.DataSource = Global.ConsultarCategorias("");
            cboCategoria.DisplayMember = "Categoria";
            cboCategoria.ValueMember = "ID";

            cboFornecedor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();

            if (rdbProdutos.Checked)
            {
                Global.Comando = new MySqlCommand("select p.ID 'Codigo', p.Descricao 'Produto', round(sum(vd.qtde), 1) 'Vendas', " +
                    "round(sum(vd.qtde * vd.vlr_unit), 2) 'Valor' from produtos p " +
                    "inner join venda_det vd on vd.Id_produto = p.id " +
                    "inner join venda_cab vc on vc.Id = vd.Id_venda " +
                    "where vc.data >= ?Data1 and vc.data <= ?Data2 " +
                    "group by p.ID, p.Descricao " +
                    "order by Vendas desc; ", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?Data1", Convert.ToDateTime(dtpData1.Text));
                Global.Comando.Parameters.AddWithValue("?Data2", Convert.ToDateTime(dtpData2.Text));
                Global.Adaptador = new MySqlDataAdapter(Global.Comando);
                Global.Adaptador.Fill(Global.datTabela = new DataTable());
            }
            else if (rdbFornecedor.Checked)
            {
                Global.Comando = new MySqlCommand("select p.ID 'Codigo', p.Descricao 'Produto', round(sum(vd.qtde), 1) 'Vendas', " +
                    "round(sum(vd.qtde * vd.vlr_unit), 2) 'Valor' from produtos p " +
                    "inner join venda_det vd on vd.Id_produto = p.id " +
                    "inner join venda_cab vc on vc.Id = vd.Id_venda " +
                    "inner join fornecedores f on f.id = p.idfornecedor " +
                    "where p.idfornecedor = ?Fornecedor and vc.data >= ?Data1 and vc.data <= ?Data2 " +
                    "group by p.ID, p.Descricao " +
                    "order by Vendas desc; ", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?Fornecedor", cboFornecedor.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?Data1", Convert.ToDateTime(dtpData1.Text));
                Global.Comando.Parameters.AddWithValue("?Data2", Convert.ToDateTime(dtpData2.Text));
                Global.Adaptador = new MySqlDataAdapter(Global.Comando);
                Global.Adaptador.Fill(Global.datTabela = new DataTable());
            }
            else
            {
                Global.Comando = new MySqlCommand("select p.ID 'Codigo', p.Descricao 'Produto', round(sum(vd.qtde), 1) 'Vendas', " +
                    "round(sum(vd.qtde * vd.vlr_unit), 2) 'Valor' from produtos p " +
                    "inner join venda_det vd on vd.Id_produto = p.id " +
                    "inner join venda_cab vc on vc.Id = vd.Id_venda " +
                    "inner join categorias c on c.id = p.idcategoria " +
                    "where c.id = ?Categoria and vc.data >= ?Data1 and vc.data <= ?Data2 " +
                    "group by p.ID, p.Descricao " +
                    "order by Vendas desc; ", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?Categoria", cboCategoria.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?Data1", Convert.ToDateTime(dtpData1.Text));
                Global.Comando.Parameters.AddWithValue("?Data2", Convert.ToDateTime(dtpData2.Text));
                Global.Adaptador = new MySqlDataAdapter(Global.Comando);
                Global.Adaptador.Fill(Global.datTabela = new DataTable());
            }

            Global.Conexao.Close();

            dgvConsulta.DataSource = Global.datTabela;
            cboFornecedor.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            rdbProdutos.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void rdbProdutos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProdutos.Checked) { cboFornecedor.Enabled = false; cboCategoria.Enabled = false; }
            if (rdbFornecedor.Checked) { cboFornecedor.Enabled = true; cboCategoria.Enabled = false; }
            if (rdbCategoria.Checked) { cboCategoria.Enabled = true; cboFornecedor.Enabled = false; }
        }

        private void rdbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProdutos.Checked) { cboFornecedor.Enabled = false; cboCategoria.Enabled = false; }
            if (rdbFornecedor.Checked) { cboFornecedor.Enabled = true; cboCategoria.Enabled = false; }
            if (rdbCategoria.Checked) { cboCategoria.Enabled = true; cboFornecedor.Enabled = false; }
        }

        private void rdbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProdutos.Checked) { cboFornecedor.Enabled = false; cboCategoria.Enabled = false; }
            if (rdbFornecedor.Checked) { cboFornecedor.Enabled = true; cboCategoria.Enabled = false; }
            if (rdbCategoria.Checked) { cboCategoria.Enabled = true; cboFornecedor.Enabled = false; }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatório de Vendas", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 215, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("Código", new Font("Arial", 10), Brushes.Black, 80, 95);
            e.Graphics.DrawString("Produto", new Font("Arial", 10), Brushes.Black, 230, 95);
            e.Graphics.DrawString("Vendas", new Font("Arial", 10), Brushes.Black, 480, 95);
            e.Graphics.DrawString("Valor", new Font("Arial", 10), Brushes.Black, 650, 95);
            e.Graphics.DrawLine(Pens.Black, 50, 120, 780, 120);

            posicao = 100;

            foreach (DataGridViewRow linha in dgvConsulta.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }
                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 80, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 230, posicao);
                e.Graphics.DrawString(linha.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, 480, posicao);
                e.Graphics.DrawString(linha.Cells[3].Value.ToString(), new Font("Arial", 10), Brushes.Black, 650, posicao);

                itens++;
            }
        }
    }
}