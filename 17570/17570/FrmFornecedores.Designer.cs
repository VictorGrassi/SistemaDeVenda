namespace _17570
{
    partial class FrmFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedores));
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.cboCidades = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblBarro = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.grbPesquisa.Controls.Add(this.dgvFornecedores);
            this.grbPesquisa.Controls.Add(this.txtPesquisa);
            this.grbPesquisa.Controls.Add(this.btnPesquisar);
            this.grbPesquisa.Location = new System.Drawing.Point(12, 214);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(565, 206);
            this.grbPesquisa.TabIndex = 96;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Pesquisa";
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFornecedores.Location = new System.Drawing.Point(5, 56);
            this.dgvFornecedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.RowHeadersWidth = 20;
            this.dgvFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFornecedores.RowTemplate.Height = 24;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(555, 145);
            this.dgvFornecedores.TabIndex = 37;
            this.dgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedoers_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.Location = new System.Drawing.Point(5, 23);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(511, 20);
            this.txtPesquisa.TabIndex = 61;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(520, 12);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisar.TabIndex = 62;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUF.Location = new System.Drawing.Point(511, 120);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 95;
            this.lblUF.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUF.Location = new System.Drawing.Point(514, 136);
            this.txtUF.Margin = new System.Windows.Forms.Padding(2);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(63, 20);
            this.txtUF.TabIndex = 94;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(14, 98);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 20);
            this.txtEmail.TabIndex = 93;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEmail.Location = new System.Drawing.Point(11, 83);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 92;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtContato
            // 
            this.txtContato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtContato.Location = new System.Drawing.Point(322, 61);
            this.txtContato.Margin = new System.Windows.Forms.Padding(2);
            this.txtContato.MaxLength = 40;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(255, 20);
            this.txtContato.TabIndex = 91;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblContato.Location = new System.Drawing.Point(322, 46);
            this.lblContato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(47, 13);
            this.lblContato.TabIndex = 90;
            this.lblContato.Text = "Contato:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTelefone.Location = new System.Drawing.Point(409, 98);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 20);
            this.txtTelefone.TabIndex = 89;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTelefone.Location = new System.Drawing.Point(406, 83);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 88;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtIE
            // 
            this.txtIE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIE.Location = new System.Drawing.Point(170, 61);
            this.txtIE.Margin = new System.Windows.Forms.Padding(2);
            this.txtIE.MaxLength = 15;
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(148, 20);
            this.txtIE.TabIndex = 87;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCidade.Location = new System.Drawing.Point(338, 120);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 86;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCNPJ.Location = new System.Drawing.Point(11, 46);
            this.lblCNPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 85;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIE.Location = new System.Drawing.Point(167, 46);
            this.lblIE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(20, 13);
            this.lblIE.TabIndex = 84;
            this.lblIE.Text = "IE:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCNPJ.Location = new System.Drawing.Point(14, 61);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(2);
            this.txtCNPJ.MaxLength = 18;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(152, 20);
            this.txtCNPJ.TabIndex = 83;
            // 
            // cboCidades
            // 
            this.cboCidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboCidades.FormattingEnabled = true;
            this.cboCidades.Location = new System.Drawing.Point(341, 135);
            this.cboCidades.Margin = new System.Windows.Forms.Padding(2);
            this.cboCidades.Name = "cboCidades";
            this.cboCidades.Size = new System.Drawing.Size(169, 21);
            this.cboCidades.TabIndex = 82;
            this.cboCidades.SelectedIndexChanged += new System.EventHandler(this.cboCidades_SelectedIndexChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBairro.Location = new System.Drawing.Point(201, 135);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(136, 20);
            this.txtBairro.TabIndex = 81;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEndereco.Location = new System.Drawing.Point(14, 136);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(183, 20);
            this.txtEndereco.TabIndex = 80;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFantasia.Location = new System.Drawing.Point(366, 24);
            this.txtFantasia.Margin = new System.Windows.Forms.Padding(2);
            this.txtFantasia.MaxLength = 30;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(211, 20);
            this.txtFantasia.TabIndex = 79;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(107, 24);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazaoSocial.MaxLength = 40;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(255, 20);
            this.txtRazaoSocial.TabIndex = 78;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtID.Location = new System.Drawing.Point(14, 24);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 77;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFantasia.Location = new System.Drawing.Point(363, 9);
            this.lblFantasia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblFantasia.TabIndex = 76;
            this.lblFantasia.Text = "Nome Fantasia:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEndereco.Location = new System.Drawing.Point(11, 120);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 75;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblBarro
            // 
            this.lblBarro.AutoSize = true;
            this.lblBarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBarro.Location = new System.Drawing.Point(198, 120);
            this.lblBarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarro.Name = "lblBarro";
            this.lblBarro.Size = new System.Drawing.Size(37, 13);
            this.lblBarro.TabIndex = 74;
            this.lblBarro.Text = "Bairro:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRazaoSocial.Location = new System.Drawing.Point(104, 9);
            this.lblRazaoSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 73;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblID.Location = new System.Drawing.Point(11, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 72;
            this.lblID.Text = "ID:";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(486, 170);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 39);
            this.btnFechar.TabIndex = 71;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(391, 170);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 39);
            this.btnImprimir.TabIndex = 70;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(296, 170);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 39);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(201, 170);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 39);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(106, 170);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(91, 39);
            this.btnAtualizar.TabIndex = 67;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIncluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(11, 170);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(91, 39);
            this.btnIncluir.TabIndex = 66;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 426);
            this.ControlBox = false;
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtIE);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblIE);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.cboCidades);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFantasia);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblBarro);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedores_Load);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.ComboBox cboCidades;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblBarro;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}