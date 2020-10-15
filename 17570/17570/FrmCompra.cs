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
    public partial class FrmCompra : Form
    {
        bool Empty;

        public FrmCompra()
        {
            InitializeComponent();
        }
        void NotEmpty()
        {
            if (String.IsNullOrWhiteSpace(txtCusto.Text)) Empty = true;
            else Empty = false;
        }

        void LimparCampos()
        {
            cboDespesa.SelectedIndex = -1;
            cboFornecedor.SelectedIndex = -1;
            dtpData.Text = DateTime.Now.ToShortDateString();
            nudParc.Text = "1";
            txtCusto.Clear();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            cboDespesa.DataSource = Global.ConsultarDespesas("");
            cboDespesa.DisplayMember = "Descricao";
            cboDespesa.ValueMember = "ID";

            cboFornecedor.DataSource = Global.ConsultarFornecedores("");
            cboFornecedor.DisplayMember = "Razao";
            cboFornecedor.ValueMember = "ID";

            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            NotEmpty();
            if (Empty == true) { MessageBox.Show("Os campos não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            DateTime Data = Convert.ToDateTime(dtpData.Text);
            int Parc = 0;
            
            while (Parc < Convert.ToInt16(nudParc.Value))
            {
                Parc++;
                Data = Data.AddMonths(1);
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("insert into contas_pagar (nota_fiscal, id_despesas, id_fornecedor, " +
                    "Parcela, data_lanc, data_vencto, data_pgto, vlr_parcela, Status) " +
                    "values (?nota_fiscal, ?id_despesas, ?id_fornecedor, ?Parcela, ?data_lanc, " +
                    "?data_vencto, ?data_pgto, ?vlr_parcela, ?Status) ", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?nota_fiscal", 1);
                Global.Comando.Parameters.AddWithValue("?id_despesas", cboDespesa.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?id_fornecedor", cboFornecedor.SelectedValue);
                Global.Comando.Parameters.AddWithValue("?Parcela", Parc);
                Global.Comando.Parameters.AddWithValue("?data_lanc", Convert.ToDateTime(dtpData.Text));
                Global.Comando.Parameters.AddWithValue("?data_vencto", Data);
                Global.Comando.Parameters.AddWithValue("?data_pgto", Convert.ToDateTime("01/01/0002"));
                Global.Comando.Parameters.AddWithValue("?vlr_parcela", Convert.ToDouble(txtCusto.Text) / Convert.ToDouble(nudParc.Value));
                Global.Comando.Parameters.AddWithValue("?Status", 0);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();
            }
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
    }
}