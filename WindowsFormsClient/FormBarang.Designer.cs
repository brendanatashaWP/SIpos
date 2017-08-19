namespace WindowsFormsClient
{
    partial class FormBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmbsatuan = new System.Windows.Forms.ComboBox();
            this.TxthargaJual = new System.Windows.Forms.TextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label4 = new System.Windows.Forms.Label();
            this.Txtstok = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxthargaBeli = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtnamaBarang = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.DgvBarang = new System.Windows.Forms.DataGridView();
            this.TxtkodeBarang = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Satuan";
            this.Column6.HeaderText = " Satuan";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HargaJual";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = " Harga Jual";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // BtnUndo
            // 
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.Location = new System.Drawing.Point(521, 288);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(39, 37);
            this.BtnUndo.TabIndex = 59;
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Visible = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Stok";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = " Stok";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // Cmbsatuan
            // 
            this.Cmbsatuan.FormattingEnabled = true;
            this.Cmbsatuan.Items.AddRange(new object[] {
            "Eksemplar",
            "Biji",
            "Batang",
            "Meter",
            "Cm",
            "Box",
            "Lusin",
            "Lembar",
            "Rim",
            "Karton"});
            this.Cmbsatuan.Location = new System.Drawing.Point(536, 32);
            this.Cmbsatuan.Name = "Cmbsatuan";
            this.Cmbsatuan.Size = new System.Drawing.Size(97, 21);
            this.Cmbsatuan.TabIndex = 57;
            // 
            // TxthargaJual
            // 
            this.TxthargaJual.Location = new System.Drawing.Point(409, 32);
            this.TxthargaJual.Name = "TxthargaJual";
            this.TxthargaJual.Size = new System.Drawing.Size(74, 20);
            this.TxthargaJual.TabIndex = 53;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HargaBeli";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = " Harga Beli";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(347, 35);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 13);
            this.Label4.TabIndex = 44;
            this.Label4.Text = "Harga Jual";
            // 
            // Txtstok
            // 
            this.Txtstok.Location = new System.Drawing.Point(536, 9);
            this.Txtstok.Name = "Txtstok";
            this.Txtstok.Size = new System.Drawing.Size(37, 20);
            this.Txtstok.TabIndex = 56;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(489, 35);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 13);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "Satuan";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(489, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "Stok";
            // 
            // TxthargaBeli
            // 
            this.TxthargaBeli.Location = new System.Drawing.Point(409, 9);
            this.TxthargaBeli.Name = "TxthargaBeli";
            this.TxthargaBeli.Size = new System.Drawing.Size(74, 20);
            this.TxthargaBeli.TabIndex = 51;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(347, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Harga Beli";
            // 
            // TxtnamaBarang
            // 
            this.TxtnamaBarang.Location = new System.Drawing.Point(90, 32);
            this.TxtnamaBarang.MaxLength = 40;
            this.TxtnamaBarang.Name = "TxtnamaBarang";
            this.TxtnamaBarang.Size = new System.Drawing.Size(237, 20);
            this.TxtnamaBarang.TabIndex = 50;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Nama Barang";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NamaBarang";
            this.Column2.HeaderText = "  Nama Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(521, 245);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(39, 37);
            this.BtnEdit.TabIndex = 54;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnd.Image")));
            this.BtnEnd.Location = new System.Drawing.Point(129, 245);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(39, 37);
            this.BtnEnd.TabIndex = 63;
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KodeBarang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = " Kode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // BtnNext
            // 
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(91, 245);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(39, 37);
            this.BtnNext.TabIndex = 62;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(483, 288);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(39, 37);
            this.BtnSave.TabIndex = 58;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(624, 245);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 37);
            this.BtnClose.TabIndex = 67;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.Location = new System.Drawing.Point(445, 245);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(39, 37);
            this.BtnFind.TabIndex = 65;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(53, 245);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(39, 37);
            this.BtnBack.TabIndex = 61;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.Location = new System.Drawing.Point(559, 245);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(39, 37);
            this.BtnDel.TabIndex = 66;
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(407, 245);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(39, 37);
            this.BtnPrint.TabIndex = 64;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.Image = ((System.Drawing.Image)(resources.GetObject("BtnTop.Image")));
            this.BtnTop.Location = new System.Drawing.Point(15, 245);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(39, 37);
            this.BtnTop.TabIndex = 60;
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 49;
            this.Label1.Text = "Kode";
            // 
            // DgvBarang
            // 
            this.DgvBarang.AllowUserToAddRows = false;
            this.DgvBarang.AllowUserToDeleteRows = false;
            this.DgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvBarang.Location = new System.Drawing.Point(15, 65);
            this.DgvBarang.Name = "DgvBarang";
            this.DgvBarang.ReadOnly = true;
            this.DgvBarang.Size = new System.Drawing.Size(648, 174);
            this.DgvBarang.TabIndex = 55;
            // 
            // TxtkodeBarang
            // 
            this.TxtkodeBarang.Location = new System.Drawing.Point(90, 6);
            this.TxtkodeBarang.MaxLength = 5;
            this.TxtkodeBarang.Name = "TxtkodeBarang";
            this.TxtkodeBarang.Size = new System.Drawing.Size(58, 20);
            this.TxtkodeBarang.TabIndex = 45;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(483, 245);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(39, 37);
            this.BtnNew.TabIndex = 52;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 336);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.Cmbsatuan);
            this.Controls.Add(this.TxthargaJual);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Txtstok);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TxthargaBeli);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtnamaBarang);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnTop);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DgvBarang);
            this.Controls.Add(this.TxtkodeBarang);
            this.Controls.Add(this.BtnNew);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.ComboBox Cmbsatuan;
        internal System.Windows.Forms.TextBox TxthargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Txtstok;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxthargaBeli;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtnamaBarang;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Button BtnNext;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnFind;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnDel;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button BtnTop;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView DgvBarang;
        internal System.Windows.Forms.TextBox TxtkodeBarang;
        internal System.Windows.Forms.Button BtnNew;
    }
}