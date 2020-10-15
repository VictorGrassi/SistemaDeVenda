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
    public partial class FrmVendas : Form
    {
        double total;

        public FrmVendas()
        {
            InitializeComponent();
        }

        void Limpar()
        {
            dgvProdutos.DataSource = "";
            cboProduto.DataSource = null;
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            picFoto.ImageLocation = "";
            nudParc.Value = 0;
            lblTotal.Text = 0.ToString("c");
            grbProduto.Enabled = false;
            grbCliente.Enabled = true;
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            cboClientes.DataSource = Global.ConsultarClientes("");
            cboClientes.DisplayMember = "Nome";
            cboClientes.ValueMember = "ID";
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            grbCliente.Enabled = false;
            grbProduto.Enabled = true;
            cboProduto.DataSource = Global.ConsultarProdutos("");
            cboProduto.DisplayMember = "Produto";
            cboProduto.ValueMember = "ID";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            { MessageBox.Show("O campo Quantidade é obrigatoóro", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else if (Convert.ToDouble(txtQuantidade.Text) <= 0)
            { MessageBox.Show("A Quantidade deve ser maior ou igual a 1", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            double vluni, quantidade, estoque;

            estoque = Convert.ToDouble(txtEstoque.Text);
            vluni = Convert.ToDouble(txtPreco.Text);
            quantidade = Convert.ToDouble(txtQuantidade.Text);

            if (quantidade < estoque)
            {
                dgvProdutos.Rows.Add(cboProduto.SelectedValue, cboProduto.Text, txtPreco.Text, txtQuantidade.Text);
                total += vluni * quantidade;
                lblTotal.Text = total.ToString("c");
                cboProduto.SelectedIndex = 0;
                txtQuantidade.Clear();
                dgvProdutos.ClearSelection();
            }
            else
            {
                MessageBox.Show("quantidade exed o estoque");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            double vluni, quantidade;

            if (dgvProdutos.SelectedRows.Count == 1)
            {
                quantidade = Convert.ToDouble(dgvProdutos.CurrentRow.Cells[3].Value);
                vluni = Convert.ToDouble(dgvProdutos.CurrentRow.Cells[2].Value);

                total -= vluni * quantidade;
                lblTotal.Text = total.ToString("c");
                cboProduto.SelectedIndex = 0;
                txtQuantidade.Clear();
                dgvProdutos.ClearSelection();

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentCell.RowIndex);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int Nparc = Convert.ToInt16(nudParc.Value);

            Global.Conexao.Open();

            Global.Comando = new MySqlCommand("INSERT INTO venda_cab (id_cliente, data, total, id_vendedor)" +
                  "VALUES (?id_cliente, ?data, ?total, ?id_vendedor )", Global.Conexao);
            Global.Comando.Parameters.AddWithValue("?id_cliente", cboClientes.SelectedValue);
            Global.Comando.Parameters.AddWithValue("?data", Convert.ToDateTime(txtData.Text));
            Global.Comando.Parameters.AddWithValue("?total", (total));
            Global.Comando.Parameters.AddWithValue("?id_vendedor", 0);
            Global.Comando.ExecuteNonQuery();

            int IDVenda = Convert.ToInt32(Global.Comando.LastInsertedId);

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                Global.Comando = new MySqlCommand("INSERT INTO venda_det (id_venda, id_produto, qtde, vlr_unit)" +
                                            "Values (?id_venda, ?id_produto, ?qtde, ?vlr_unit)", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id_venda", (IDVenda));
                Global.Comando.Parameters.AddWithValue("?id_produto", linha.Cells[0].Value);
                Global.Comando.Parameters.AddWithValue("?qtde", Convert.ToDouble(linha.Cells[3].Value));
                Global.Comando.Parameters.AddWithValue("?vlr_unit", Convert.ToDouble(linha.Cells[2].Value));
                Global.Comando.ExecuteNonQuery();

                Global.Comando = new MySqlCommand("UPDATE produtos SET estoque = estoque -?qtde  where id = ?id", Global.Conexao);
                Global.Comando.Parameters.AddWithValue("?id", (linha.Cells[0].Value));
                Global.Comando.Parameters.AddWithValue("?qtde", (linha.Cells[3].Value));
                Global.Comando.ExecuteNonQuery();
            }

            if (nudParc.Value >= 1)
            {
                for (int i = 1; i <= Nparc; i++)
                {
                    DateTime vencto = Convert.ToDateTime(txtData.Text);
                    Double ValorParc = total / Nparc;

                    vencto = vencto.AddMonths(1);

                    Global.Comando = new MySqlCommand("INSERT INTO contas_receber (id_venda, id_cliente, parcela, data_venda, data_vencto, data_pgto, vlr_parcela, status) " +
                                                    "VALUES (?id_venda, ?id_cliente, ?parcela, ?data_venda, ?data_vencto, ?data_pgto, ?vlr_parcela, ?status)", Global.Conexao);
                    Global.Comando.Parameters.AddWithValue("?id_venda", (IDVenda));
                    Global.Comando.Parameters.AddWithValue("?id_cliente", cboClientes.SelectedValue);
                    Global.Comando.Parameters.AddWithValue("?parcela", (i));
                    Global.Comando.Parameters.AddWithValue("?data_venda", Convert.ToDateTime(txtData.Text));
                    Global.Comando.Parameters.AddWithValue("?data_vencto", vencto);
                    Global.Comando.Parameters.AddWithValue("?data_pgto", Convert.ToDateTime("01/01/0001"));
                    Global.Comando.Parameters.AddWithValue("?vlr_parcela", Convert.ToDouble(ValorParc));
                    Global.Comando.Parameters.AddWithValue("?status", false);
                    Global.Comando.ExecuteNonQuery();
                }
            }
            Global.Conexao.Close();

            MessageBox.Show("Venda Efetuada com Sucesso !!! ", "Venda");
            Limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o formulario? ", "Fechando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ConsultarProdutos(cboProduto.Text);

            if (Global.datTabela.Rows.Count > 0)
            {
                txtPreco.Text = Global.datTabela.Rows[0].Field<decimal>("Valor de Venda").ToString();
                txtEstoque.Text = Global.datTabela.Rows[0].Field<decimal>("Estoque").ToString();
                picFoto.ImageLocation = Global.datTabela.Rows[0].Field<String>("Foto");
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}