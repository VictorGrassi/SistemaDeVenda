namespace _17570
{
    partial class FrmConVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConVenda));
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.rdbFornecedor = new System.Windows.Forms.RadioButton();
            this.rdbProdutos = new System.Windows.Forms.RadioButton();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lbla = new System.Windows.Forms.Label();
            this.lblPerido = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategoria
            // 
            this.cboCategoria.Enabled = false;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(123, 124);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(238, 21);
            this.cboCategoria.TabIndex = 35;
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Enabled = false;
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(123, 90);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(238, 21);
            this.cboFornecedor.TabIndex = 34;
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Location = new System.Drawing.Point(35, 125);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(73, 17);
            this.rdbCategoria.TabIndex = 33;
            this.rdbCategoria.Text = "Categoria:";
            this.rdbCategoria.UseVisualStyleBackColor = true;
            this.rdbCategoria.CheckedChanged += new System.EventHandler(this.rdbCategoria_CheckedChanged);
            // 
            // rdbFornecedor
            // 
            this.rdbFornecedor.AutoSize = true;
            this.rdbFornecedor.Location = new System.Drawing.Point(35, 91);
            this.rdbFornecedor.Name = "rdbFornecedor";
            this.rdbFornecedor.Size = new System.Drawing.Size(82, 17);
            this.rdbFornecedor.TabIndex = 32;
            this.rdbFornecedor.Text = "Fornecedor:";
            this.rdbFornecedor.UseVisualStyleBackColor = true;
            this.rdbFornecedor.CheckedChanged += new System.EventHandler(this.rdbFornecedor_CheckedChanged);
            // 
            // rdbProdutos
            // 
            this.rdbProdutos.AutoSize = true;
            this.rdbProdutos.Checked = true;
            this.rdbProdutos.Location = new System.Drawing.Point(18, 60);
            this.rdbProdutos.Name = "rdbProdutos";
            this.rdbProdutos.Size = new System.Drawing.Size(113, 17);
            this.rdbProdutos.TabIndex = 31;
            this.rdbProdutos.TabStop = true;
            this.rdbProdutos.Text = "Todos os produtos";
            this.rdbProdutos.UseVisualStyleBackColor = true;
            this.rdbProdutos.CheckedChanged += new System.EventHandler(this.rdbProdutos_CheckedChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(15, 35);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(171, 13);
            this.lblSelect.TabIndex = 30;
            this.lblSelect.Text = "Selecione um filtro para a pesquisa";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(289, 277);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(72, 37);
            this.btnFechar.TabIndex = 29;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Location = new System.Drawing.Point(211, 277);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(72, 37);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(15, 153);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 20;
            this.dgvConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(357, 118);
            this.dgvConsulta.TabIndex = 27;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Location = new System.Drawing.Point(289, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(72, 35);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpData2
            // 
            this.dtpData2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(181, 4);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(92, 20);
            this.dtpData2.TabIndex = 25;
            this.dtpData2.Value = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            // 
            // dtpData1
            // 
            this.dtpData1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(65, 4);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(92, 20);
            this.dtpData1.TabIndex = 24;
            this.dtpData1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbla.Location = new System.Drawing.Point(163, 9);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 23;
            this.lbla.Text = "à";
            // 
            // lblPerido
            // 
            this.lblPerido.AutoSize = true;
            this.lblPerido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPerido.Location = new System.Drawing.Point(12, 9);
            this.lblPerido.Name = "lblPerido";
            this.lblPerido.Size = new System.Drawing.Size(46, 13);
            this.lblPerido.TabIndex = 22;
            this.lblPerido.Text = "Periodo:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // FrmConVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 321);
            this.ControlBox = false;
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboFornecedor);
            this.Controls.Add(this.rdbCategoria);
            this.Controls.Add(this.rdbFornecedor);
            this.Controls.Add(this.rdbProdutos);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpData2);
            this.Controls.Add(this.dtpData1);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblPerido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.FrmConVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.RadioButton rdbCategoria;
        private System.Windows.Forms.RadioButton rdbFornecedor;
        private System.Windows.Forms.RadioButton rdbProdutos;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblPerido;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}