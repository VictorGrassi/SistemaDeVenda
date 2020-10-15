namespace _17570
{
    partial class FrmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompra));
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.cboDespesa = new System.Windows.Forms.ComboBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.nudParc = new System.Windows.Forms.NumericUpDown();
            this.lblParcelas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCusto.Location = new System.Drawing.Point(12, 138);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(37, 13);
            this.lblCusto.TabIndex = 118;
            this.lblCusto.Text = "Custo:";
            // 
            // txtCusto
            // 
            this.txtCusto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCusto.Location = new System.Drawing.Point(57, 135);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(136, 20);
            this.txtCusto.TabIndex = 119;
            // 
            // dtpData
            // 
            this.dtpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(51, 105);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(91, 20);
            this.dtpData.TabIndex = 117;
            this.dtpData.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblData.Location = new System.Drawing.Point(12, 108);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 116;
            this.lblData.Text = "Data:";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(15, 27);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(228, 21);
            this.cboFornecedor.TabIndex = 115;
            // 
            // cboDespesa
            // 
            this.cboDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDespesa.FormattingEnabled = true;
            this.cboDespesa.Location = new System.Drawing.Point(15, 71);
            this.cboDespesa.Name = "cboDespesa";
            this.cboDespesa.Size = new System.Drawing.Size(263, 21);
            this.cboDespesa.TabIndex = 114;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDespesa.Location = new System.Drawing.Point(12, 53);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(56, 13);
            this.lblDespesa.TabIndex = 113;
            this.lblDespesa.Text = "*Despesa:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFornecedor.Location = new System.Drawing.Point(12, 9);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(68, 13);
            this.lblFornecedor.TabIndex = 112;
            this.lblFornecedor.Text = "*Fornecedor:";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(284, 105);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 42);
            this.btnFechar.TabIndex = 111;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(284, 57);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 42);
            this.btnCancelar.TabIndex = 110;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Location = new System.Drawing.Point(284, 9);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(86, 42);
            this.btnGravar.TabIndex = 109;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // nudParc
            // 
            this.nudParc.Location = new System.Drawing.Point(220, 132);
            this.nudParc.Name = "nudParc";
            this.nudParc.Size = new System.Drawing.Size(49, 20);
            this.nudParc.TabIndex = 108;
            this.nudParc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblParcelas.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblParcelas.Location = new System.Drawing.Point(214, 114);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(64, 17);
            this.lblParcelas.TabIndex = 107;
            this.lblParcelas.Text = "Parcelas:";
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 162);
            this.ControlBox = false;
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cboFornecedor);
            this.Controls.Add(this.cboDespesa);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.nudParc);
            this.Controls.Add(this.lblParcelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "            ";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudParc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.ComboBox cboDespesa;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.NumericUpDown nudParc;
        private System.Windows.Forms.Label lblParcelas;
    }
}