using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17570
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Global.Conectar();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades Form = new FrmCidades();
            Form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias Form = new FrmCategorias();
            Form.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios Form = new FrmUsuarios();
            Form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Form = new FrmClientes();
            Form.Show();
        }

        private void fornacedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores Form = new FrmFornecedores();
            Form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos Form = new FrmProdutos();
            Form.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas Form = new FrmVendas();
            Form.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasReceber Form = new FrmContasReceber();
            Form.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConVenda Form = new FrmConVenda();
            Form.Show();
        }

        private void vendaPorProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConVendaProduto Form = new FrmConVendaProduto();
            Form.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra Form = new
                FrmCompra();
            Form.Show();
        }
    }
}