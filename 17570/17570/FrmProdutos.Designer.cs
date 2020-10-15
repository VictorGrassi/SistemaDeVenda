namespace _17570
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.btnVideo = new System.Windows.Forms.Button();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.chkForaDeLinha = new System.Windows.Forms.CheckBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoDeBarras = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.grbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVideo
            // 
            this.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideo.Image")));
            this.btnVideo.Location = new System.Drawing.Point(368, 125);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(52, 40);
            this.btnVideo.TabIndex = 94;
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.grbPesquisa.Controls.Add(this.dgvProdutos);
            this.grbPesquisa.Controls.Add(this.txtPesquisa);
            this.grbPesquisa.Controls.Add(this.btnPesquisa);
            this.grbPesquisa.Location = new System.Drawing.Point(14, 213);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(556, 194);
            this.grbPesquisa.TabIndex = 93;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Pesquisa";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProdutos.Location = new System.Drawing.Point(5, 56);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 20;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(546, 130);
            this.dgvProdutos.TabIndex = 37;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.Location = new System.Drawing.Point(5, 23);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.MaxLength = 40;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(502, 20);
            this.txtPesquisa.TabIndex = 60;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(511, 12);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisa.TabIndex = 61;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFoto.Location = new System.Drawing.Point(430, 38);
            this.picFoto.Margin = new System.Windows.Forms.Padding(2);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(127, 127);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 92;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // chkForaDeLinha
            // 
            this.chkForaDeLinha.AutoSize = true;
            this.chkForaDeLinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkForaDeLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkForaDeLinha.Location = new System.Drawing.Point(450, 11);
            this.chkForaDeLinha.Margin = new System.Windows.Forms.Padding(2);
            this.chkForaDeLinha.Name = "chkForaDeLinha";
            this.chkForaDeLinha.Size = new System.Drawing.Size(87, 17);
            this.chkForaDeLinha.TabIndex = 91;
            this.chkForaDeLinha.Text = "Fora de linha";
            this.chkForaDeLinha.UseVisualStyleBackColor = true;
            // 
            // txtVideo
            // 
            this.txtVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtVideo.Location = new System.Drawing.Point(14, 136);
            this.txtVideo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVideo.MaxLength = 100;
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(349, 20);
            this.txtVideo.TabIndex = 90;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVideo.Location = new System.Drawing.Point(11, 121);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(37, 13);
            this.lblVideo.TabIndex = 89;
            this.lblVideo.Text = "Video:";
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtValorCusto.Location = new System.Drawing.Point(317, 99);
            this.txtValorCusto.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorCusto.MaxLength = 11;
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(103, 20);
            this.txtValorCusto.TabIndex = 88;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCusto.Location = new System.Drawing.Point(314, 84);
            this.lblCusto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(64, 13);
            this.lblCusto.TabIndex = 87;
            this.lblCusto.Text = "Valor Custo:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtValorVenda.Location = new System.Drawing.Point(216, 99);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorVenda.MaxLength = 11;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(97, 20);
            this.txtValorVenda.TabIndex = 86;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVenda.Location = new System.Drawing.Point(214, 84);
            this.lblVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(68, 13);
            this.lblVenda.TabIndex = 85;
            this.lblVenda.Text = "Valor Venda:";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(115, 99);
            this.txtEstoqueMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstoqueMinimo.MaxLength = 11;
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(97, 20);
            this.txtEstoqueMinimo.TabIndex = 84;
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(112, 84);
            this.lblEstoqueMinimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(85, 13);
            this.lblEstoqueMinimo.TabIndex = 83;
            this.lblEstoqueMinimo.Text = "Estoque Minimo:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEstoque.Location = new System.Drawing.Point(14, 99);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstoque.MaxLength = 11;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(97, 20);
            this.txtEstoque.TabIndex = 82;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEstoque.Location = new System.Drawing.Point(11, 84);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 81;
            this.lblEstoque.Text = "Estoque:";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(217, 61);
            this.cboFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(203, 21);
            this.cboFornecedor.TabIndex = 80;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFornecedor.Location = new System.Drawing.Point(214, 46);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 79;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(11, 61);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(201, 21);
            this.cboCategoria.TabIndex = 78;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCategoria.Location = new System.Drawing.Point(11, 46);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 77;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(301, 24);
            this.txtCodigoDeBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoDeBarras.MaxLength = 14;
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(119, 20);
            this.txtCodigoDeBarras.TabIndex = 76;
            // 
            // lblCodigoDeBarras
            // 
            this.lblCodigoDeBarras.AutoSize = true;
            this.lblCodigoDeBarras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCodigoDeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCodigoDeBarras.Location = new System.Drawing.Point(298, 9);
            this.lblCodigoDeBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            this.lblCodigoDeBarras.Size = new System.Drawing.Size(91, 13);
            this.lblCodigoDeBarras.TabIndex = 75;
            this.lblCodigoDeBarras.Text = "Código de Barras:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescricao.Location = new System.Drawing.Point(67, 24);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.MaxLength = 40;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(230, 20);
            this.txtDescricao.TabIndex = 74;
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
            this.txtID.Size = new System.Drawing.Size(49, 20);
            this.txtID.TabIndex = 73;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDescricao.Location = new System.Drawing.Point(64, 9);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 72;
            this.lblDescricao.Text = "Descrição:";
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
            this.lblID.TabIndex = 71;
            this.lblID.Text = "ID:";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(481, 169);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(89, 39);
            this.btnFechar.TabIndex = 70;
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
            this.btnImprimir.Location = new System.Drawing.Point(388, 169);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 39);
            this.btnImprimir.TabIndex = 69;
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
            this.btnExcluir.Location = new System.Drawing.Point(295, 169);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 39);
            this.btnExcluir.TabIndex = 68;
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
            this.btnCancelar.Location = new System.Drawing.Point(202, 169);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 39);
            this.btnCancelar.TabIndex = 67;
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
            this.btnAtualizar.Location = new System.Drawing.Point(109, 169);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(89, 39);
            this.btnAtualizar.TabIndex = 66;
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
            this.btnIncluir.Location = new System.Drawing.Point(16, 169);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(89, 39);
            this.btnIncluir.TabIndex = 65;
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
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 412);
            this.ControlBox = false;
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.chkForaDeLinha);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.txtValorCusto);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.lblEstoqueMinimo);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.cboFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.lblCodigoDeBarras);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDescricao);
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
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.CheckBox chkForaDeLinha;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.Label lblCodigoDeBarras;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}