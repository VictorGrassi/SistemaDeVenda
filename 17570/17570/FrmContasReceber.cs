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
    public partial class FrmContasReceber : Form
    {
        double selecao;

        public FrmContasReceber()
        {
            InitializeComponent();
        }

        void LimpaForm()
        {
            txtDinheiro.Clear();
            txtCartao.Clear();
            txtCheque.Clear();
            txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            selecao = 0;
            lblTotal.Text = selecao.ToString("c");
            dgvTitulos.DataSource = "";
            grbClientes.Enabled = true;
            grbCaixa.Enabled = false;
            btnCarregar.Enabled = true;
            btnGravar.Enabled = false;
        }

        private void FrmContasReceber_Load(object sender, EventArgs e)
        {
            Global.ConsultarClientes(cboClientes.Text);
            cboClientes.DataSource = Global.datTabela;
            cboClientes.DisplayMember = "nome";
            cboClientes.ValueMember = "id";
            LimpaForm();
        }

        private void btncarregar_Click(object sender, EventArgs e)
        {
            Global.Conexao.Open();
            Global.Comando = new MySqlCommand("select c.status OK, c.id_venda Venda, c.Parcela, " +
                "c.data_vencto Vencimento, round(c.vlr_parcela, 2) Valor from contas_receber c " +
                "where c.id_cliente = ?cliente and c.status = false " +
                "order by c.id_venda", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?cliente", cboClientes.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?data", Convert.ToDateTime(txtData.Text));
            Global.Adaptador = new MySqlDataAdapter(Global.Comando);
            Global.Adaptador.Fill(Global.datTabela = new DataTable());
            Global.Conexao.Close();
            dgvTitulos.DataSource = Global.datTabela;
            grbClientes.Enabled = false;
            grbCaixa.Enabled = true;
            btnGravar.Enabled = true;
            btnCarregar.Enabled = false;
        }

        private void btnmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvTitulos.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[4].Value);
            }
            lblTotal.Text = selecao.ToString("c");
        }

        private void btndesmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvTitulos.Rows)
            {
                linha.Cells[0].Value = false;
            }
            lblTotal.Text = selecao.ToString("c");
        }

        private void dgvtitulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dgvTitulos.CurrentRow.Cells[0].Value) == true)
            {
                dgvTitulos.CurrentRow.Cells[0].Value = false;
                selecao -= Convert.ToDouble(dgvTitulos.CurrentRow.Cells[4].Value);
            }
            else
            {
                dgvTitulos.CurrentRow.Cells[0].Value = true;
                selecao += Convert.ToDouble(dgvTitulos.CurrentRow.Cells[4].Value);
            }
            lblTotal.Text = selecao.ToString("c");
            dgvTitulos.ClearSelection();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDinheiro.Text)) txtDinheiro.Text = "0,00";
            if (String.IsNullOrWhiteSpace(txtCartao.Text)) txtCartao.Text = "0,00";
            if (String.IsNullOrWhiteSpace(txtCheque.Text)) txtCheque.Text = "0,00";

            if (selecao <= Convert.ToDouble(txtDinheiro.Text) + Convert.ToDouble(txtCartao.Text) + Convert.ToDouble(txtCheque.Text))
            {
                foreach (DataGridViewRow linha in dgvTitulos.Rows)
                {
                    if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                    {
                        Global.Conexao.Open();
                        Global.Comando = new MySqlCommand("UPDATE contas_receber SET status = true where id_venda = ?id and parcela = ?parcela", Global.Conexao);
                        Global.Comando.Parameters.AddWithValue("?id", Convert.ToInt16(linha.Cells[1].Value));
                        Global.Comando.Parameters.AddWithValue("?parcela", Convert.ToInt16(linha.Cells[2].Value));
                        Global.Comando.ExecuteNonQuery();
                        Global.Conexao.Close();
                    }
                }
                Global.Conexao.Open();
                Global.Comando = new MySqlCommand("INSERT INTO caixa (Data, Dinheiro, Cartao, Cheque, Tipo) " +
                                                  "VALUE (?Data, ?Dinheiro, ?Cartao, ?Cheque, ?Tipo)", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?Data", Convert.ToDateTime(txtData.Text));
                Global.Comando.Parameters.AddWithValue("?Dinheiro", Convert.ToDouble(txtDinheiro.Text));
                Global.Comando.Parameters.AddWithValue("?Cartao", Convert.ToDouble(txtCartao.Text));
                Global.Comando.Parameters.AddWithValue("?Cheque", Convert.ToDouble(txtCheque.Text));
                Global.Comando.Parameters.AddWithValue("?Tipo", 1);
                Global.Comando.ExecuteNonQuery();
                Global.Conexao.Close();

                LimpaForm();
            }
            else
            {
                MessageBox.Show("Valor pago não pode ser menor que o total", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
    }
}