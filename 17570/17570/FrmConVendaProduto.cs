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
    public partial class FrmConVendaProduto : Form
    {
        public FrmConVendaProduto()
        {
            InitializeComponent();
        }

        private void FrmConVendaProduto_Load(object sender, EventArgs e)
        {
            cboProduto.DataSource = Global.ConsultarProdutos("");
            cboProduto.DisplayMember = "Produto";
            cboProduto.ValueMember = "ID";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("select vc.id 'Venda', vc.Data, c.nome 'Cliente', " +
                 "round(vd.qtde, 1) 'Quantidade', round(vd.vlr_unit, 2) 'Valor' from venda_cab vc " +
                 "inner join venda_det vd on vc.id = vd.id_venda " +
                 "inner join produtos p on vd.Id_produto = p.id " +
                 "inner join clientes c on vc.Id_cliente = c.id " +
                 "where p.id = ?Produto and vc.data >= ?Data1 and vc.data <= ?Data2", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?Produto", cboProduto.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?Data1", Convert.ToDateTime(dtpData1.Text));
            Global.Comando.Parameters.AddWithValue("?Data2", Convert.ToDateTime(dtpData2.Text));
            Global.Adaptador = new MySqlDataAdapter(Global.Comando);
            Global.Adaptador.Fill(Global.datTabela = new DataTable());
            Global.Conexao.Close();

            dgvConsulta.DataSource = Global.datTabela;
            cboProduto.SelectedIndex = -1;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatório de Vendas", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 215, 10);
            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("Venda", new Font("Arial", 10), Brushes.Black, 80, 95);
            e.Graphics.DrawString("Data", new Font("Arial", 10), Brushes.Black, 150, 95);
            e.Graphics.DrawString("Cliente", new Font("Arial", 10), Brushes.Black, 320, 95);
            e.Graphics.DrawString("Quantidade", new Font("Arial", 10), Brushes.Black, 500, 95);
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
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 150, posicao);
                e.Graphics.DrawString(linha.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, 320, posicao);
                e.Graphics.DrawString(linha.Cells[3].Value.ToString(), new Font("Arial", 10), Brushes.Black, 500, posicao);
                e.Graphics.DrawString(linha.Cells[4].Value.ToString(), new Font("Arial", 10), Brushes.Black, 650, posicao);

                itens++;
            }
        }
    }
}