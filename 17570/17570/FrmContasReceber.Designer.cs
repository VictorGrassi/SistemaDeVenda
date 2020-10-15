namespace _17570
{
    partial class FrmContasReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasReceber));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSelecionados = new System.Windows.Forms.Label();
            this.grbCaixa = new System.Windows.Forms.GroupBox();
            this.lblCheque = new System.Windows.Forms.Label();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.grbCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.grbClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(331, 311);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 23);
            this.btnFechar.TabIndex = 24;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(260, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(189, 311);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 23);
            this.btnGravar.TabIndex = 22;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(98, 315);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // lblSelecionados
            // 
            this.lblSelecionados.AutoSize = true;
            this.lblSelecionados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSelecionados.Location = new System.Drawing.Point(18, 316);
            this.lblSelecionados.Name = "lblSelecionados";
            this.lblSelecionados.Size = new System.Drawing.Size(74, 13);
            this.lblSelecionados.TabIndex = 20;
            this.lblSelecionados.Text = "Selecionados:";
            // 
            // grbCaixa
            // 
            this.grbCaixa.BackColor = System.Drawing.Color.Transparent;
            this.grbCaixa.Controls.Add(this.lblCheque);
            this.grbCaixa.Controls.Add(this.lblCartao);
            this.grbCaixa.Controls.Add(this.lblDinheiro);
            this.grbCaixa.Controls.Add(this.txtCartao);
            this.grbCaixa.Controls.Add(this.txtCheque);
            this.grbCaixa.Controls.Add(this.txtDinheiro);
            this.grbCaixa.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbCaixa.Location = new System.Drawing.Point(12, 229);
            this.grbCaixa.Name = "grbCaixa";
            this.grbCaixa.Size = new System.Drawing.Size(384, 76);
            this.grbCaixa.TabIndex = 19;
            this.grbCaixa.TabStop = false;
            this.grbCaixa.Text = "Caixa";
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.BackColor = System.Drawing.SystemColors.Control;
            this.lblCheque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheque.Location = new System.Drawing.Point(256, 23);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(47, 13);
            this.lblCheque.TabIndex = 7;
            this.lblCheque.Text = "Cheque:";
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.BackColor = System.Drawing.SystemColors.Control;
            this.lblCartao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartao.Location = new System.Drawing.Point(131, 23);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(41, 13);
            this.lblCartao.TabIndex = 6;
            this.lblCartao.Text = "Cartão:";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.BackColor = System.Drawing.SystemColors.Control;
            this.lblDinheiro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.Location = new System.Drawing.Point(6, 23);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(49, 13);
            this.lblDinheiro.TabIndex = 5;
            this.lblDinheiro.Text = "Dinheiro:";
            // 
            // txtCartao
            // 
            this.txtCartao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCartao.Location = new System.Drawing.Point(134, 39);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(119, 20);
            this.txtCartao.TabIndex = 2;
            // 
            // txtCheque
            // 
            this.txtCheque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheque.Location = new System.Drawing.Point(259, 39);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(119, 20);
            this.txtCheque.TabIndex = 1;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDinheiro.Location = new System.Drawing.Point(9, 39);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(119, 20);
            this.txtDinheiro.TabIndex = 0;
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AllowUserToAddRows = false;
            this.dgvTitulos.AllowUserToDeleteRows = false;
            this.dgvTitulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTitulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTitulos.Location = new System.Drawing.Point(12, 116);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.ReadOnly = true;
            this.dgvTitulos.RowHeadersWidth = 20;
            this.dgvTitulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitulos.Size = new System.Drawing.Size(384, 107);
            this.dgvTitulos.TabIndex = 18;
            this.dgvTitulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtitulos_CellClick);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesmarcar.Location = new System.Drawing.Point(271, 87);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(100, 23);
            this.btnDesmarcar.TabIndex = 17;
            this.btnDesmarcar.Text = "Desmarcar Todos";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btndesmarcar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcar.Location = new System.Drawing.Point(158, 87);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(107, 23);
            this.btnMarcar.TabIndex = 16;
            this.btnMarcar.Text = "Marcar Todos";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnmarcar_Click);
            // 
            // grbClientes
            // 
            this.grbClientes.BackColor = System.Drawing.Color.Transparent;
            this.grbClientes.Controls.Add(this.lblData);
            this.grbClientes.Controls.Add(this.lblCliente);
            this.grbClientes.Controls.Add(this.btnCarregar);
            this.grbClientes.Controls.Add(this.txtData);
            this.grbClientes.Controls.Add(this.cboClientes);
            this.grbClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbClientes.Location = new System.Drawing.Point(12, 6);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(384, 75);
            this.grbClientes.TabIndex = 15;
            this.grbClientes.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.Control;
            this.lblData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.Location = new System.Drawing.Point(285, 40);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(74, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btncarregar_Click);
            // 
            // txtData
            // 
            this.txtData.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(54, 40);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(124, 20);
            this.txtData.TabIndex = 1;
            // 
            // cboClientes
            // 
            this.cboClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(54, 13);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(324, 21);
            this.cboClientes.TabIndex = 0;
            // 
            // FrmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSelecionados);
            this.Controls.Add(this.grbCaixa);
            this.Controls.Add(this.dgvTitulos);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.grbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.FrmContasReceber_Load);
            this.grbCaixa.ResumeLayout(false);
            this.grbCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSelecionados;
        private System.Windows.Forms.GroupBox grbCaixa;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ComboBox cboClientes;
    }
}