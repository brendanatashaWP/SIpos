﻿namespace WindowsFormsClient
{
    partial class FormNotaJual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaJual));
            this.Label11 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtNoNotaJual = new System.Windows.Forms.TextBox();
            this.DgvDetailJual = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblKetDel = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblKeterangan = new System.Windows.Forms.Label();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.LblKetBackSpace = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtTanggal = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.TxtJumlah = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtHarga = new System.Windows.Forms.TextBox();
            this.TxtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNonota = new System.Windows.Forms.ComboBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.btnPrintPerBarang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetailJual)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(398, 16);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 13);
            this.Label11.TabIndex = 30;
            this.Label11.Text = "Harga";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(39, 16);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(32, 13);
            this.Label8.TabIndex = 30;
            this.Label8.Text = "Kode";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(358, 16);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(23, 13);
            this.Label10.TabIndex = 30;
            this.Label10.Text = "Qty";
            // 
            // txtNoNotaJual
            // 
            this.txtNoNotaJual.Enabled = false;
            this.txtNoNotaJual.Location = new System.Drawing.Point(97, 30);
            this.txtNoNotaJual.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoNotaJual.Name = "txtNoNotaJual";
            this.txtNoNotaJual.Size = new System.Drawing.Size(76, 20);
            this.txtNoNotaJual.TabIndex = 80;
            // 
            // DgvDetailJual
            // 
            this.DgvDetailJual.AllowUserToAddRows = false;
            this.DgvDetailJual.AllowUserToDeleteRows = false;
            this.DgvDetailJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetailJual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvDetailJual.Location = new System.Drawing.Point(21, 193);
            this.DgvDetailJual.Margin = new System.Windows.Forms.Padding(2);
            this.DgvDetailJual.Name = "DgvDetailJual";
            this.DgvDetailJual.ReadOnly = true;
            this.DgvDetailJual.RowTemplate.Height = 24;
            this.DgvDetailJual.Size = new System.Drawing.Size(613, 147);
            this.DgvDetailJual.TabIndex = 86;
            this.DgvDetailJual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvDetailJual_KeyDown);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "idNotaJual";
            this.Column7.HeaderText = "idNotaJual";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "noNotaJual";
            this.Column6.HeaderText = "noNotaJual";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KodeBarang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NamaBarang";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 230;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Qty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Harga";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Harga";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Jumlah";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Jumlah";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // LblKetDel
            // 
            this.LblKetDel.AutoSize = true;
            this.LblKetDel.BackColor = System.Drawing.Color.Transparent;
            this.LblKetDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKetDel.ForeColor = System.Drawing.Color.Red;
            this.LblKetDel.Location = new System.Drawing.Point(59, 350);
            this.LblKetDel.Name = "LblKetDel";
            this.LblKetDel.Size = new System.Drawing.Size(26, 13);
            this.LblKetDel.TabIndex = 90;
            this.LblKetDel.Text = "Del";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(445, 348);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(56, 13);
            this.Label13.TabIndex = 88;
            this.Label13.Text = "Total Rp";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(502, 345);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(108, 21);
            this.TxtTotal.TabIndex = 87;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblKeterangan
            // 
            this.LblKeterangan.AutoSize = true;
            this.LblKeterangan.ForeColor = System.Drawing.Color.Blue;
            this.LblKeterangan.Location = new System.Drawing.Point(24, 350);
            this.LblKeterangan.Name = "LblKeterangan";
            this.LblKeterangan.Size = new System.Drawing.Size(411, 13);
            this.LblKeterangan.TabIndex = 89;
            this.LblKeterangan.Text = "Tekan  Del  pada item pembelian untuk menghapus, Back Space     untuk mengubah";
            // 
            // TxtNamaBarang
            // 
            this.TxtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaBarang.Location = new System.Drawing.Point(97, 37);
            this.TxtNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNamaBarang.Name = "TxtNamaBarang";
            this.TxtNamaBarang.ReadOnly = true;
            this.TxtNamaBarang.Size = new System.Drawing.Size(252, 26);
            this.TxtNamaBarang.TabIndex = 1;
            // 
            // LblKetBackSpace
            // 
            this.LblKetBackSpace.AutoSize = true;
            this.LblKetBackSpace.BackColor = System.Drawing.Color.Transparent;
            this.LblKetBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKetBackSpace.ForeColor = System.Drawing.Color.Red;
            this.LblKetBackSpace.Location = new System.Drawing.Point(274, 350);
            this.LblKetBackSpace.Name = "LblKetBackSpace";
            this.LblKetBackSpace.Size = new System.Drawing.Size(76, 13);
            this.LblKetBackSpace.TabIndex = 91;
            this.LblKetBackSpace.Text = "Back Space";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(457, 32);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 82;
            this.Label2.Text = "Tanggal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 32);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 13);
            this.Label1.TabIndex = 83;
            this.Label1.Text = "No. Nota Jual";
            // 
            // TxtTanggal
            // 
            this.TxtTanggal.Enabled = false;
            this.TxtTanggal.Location = new System.Drawing.Point(505, 30);
            this.TxtTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTanggal.Name = "TxtTanggal";
            this.TxtTanggal.Size = new System.Drawing.Size(129, 20);
            this.TxtTanggal.TabIndex = 81;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(180, 403);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(159, 13);
            this.Label14.TabIndex = 92;
            this.Label14.Text = "Developed by Brenda, Oct 2016";
            // 
            // TxtJumlah
            // 
            this.TxtJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJumlah.Location = new System.Drawing.Point(484, 38);
            this.TxtJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.TxtJumlah.Name = "TxtJumlah";
            this.TxtJumlah.ReadOnly = true;
            this.TxtJumlah.Size = new System.Drawing.Size(108, 26);
            this.TxtJumlah.TabIndex = 4;
            this.TxtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtJumlah_KeyDown);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TxtJumlah);
            this.GroupBox2.Controls.Add(this.TxtHarga);
            this.GroupBox2.Controls.Add(this.TxtKodeBarang);
            this.GroupBox2.Controls.Add(this.txtQty);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.TxtNamaBarang);
            this.GroupBox2.Location = new System.Drawing.Point(21, 81);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Size = new System.Drawing.Size(613, 71);
            this.GroupBox2.TabIndex = 85;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = " Item Data Entry ";
            // 
            // TxtHarga
            // 
            this.TxtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHarga.Location = new System.Drawing.Point(394, 37);
            this.TxtHarga.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHarga.Name = "TxtHarga";
            this.TxtHarga.Size = new System.Drawing.Size(86, 26);
            this.TxtHarga.TabIndex = 3;
            this.TxtHarga.Text = "0";
            this.TxtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHarga_KeyDown);
            this.TxtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHarga_KeyPress);
            this.TxtHarga.Validated += new System.EventHandler(this.TxtHarga_Validated);
            // 
            // TxtKodeBarang
            // 
            this.TxtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKodeBarang.Location = new System.Drawing.Point(36, 37);
            this.TxtKodeBarang.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKodeBarang.MaxLength = 5;
            this.TxtKodeBarang.Name = "TxtKodeBarang";
            this.TxtKodeBarang.Size = new System.Drawing.Size(57, 26);
            this.TxtKodeBarang.TabIndex = 0;
            this.TxtKodeBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKodeBarang_KeyDown);
            this.TxtKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKodeBarang_KeyUp_1);
            this.TxtKodeBarang.Leave += new System.EventHandler(this.TxtKodeBarang_Leave);
            this.TxtKodeBarang.Validated += new System.EventHandler(this.TxtKodeBarang_Validated);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(356, 37);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(35, 26);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Validated += new System.EventHandler(this.txtQty_Validated);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(100, 16);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(72, 13);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Nama Barang";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(488, 16);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(40, 13);
            this.Label12.TabIndex = 30;
            this.Label12.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(274, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Back Space";
            // 
            // cmbNonota
            // 
            this.cmbNonota.FormattingEnabled = true;
            this.cmbNonota.Location = new System.Drawing.Point(97, 29);
            this.cmbNonota.Name = "cmbNonota";
            this.cmbNonota.Size = new System.Drawing.Size(76, 21);
            this.cmbNonota.TabIndex = 106;
            this.cmbNonota.Visible = false;
            this.cmbNonota.SelectedValueChanged += new System.EventHandler(this.cmbNonota_SelectedValueChanged);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.Location = new System.Drawing.Point(496, 379);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(39, 37);
            this.BtnUndo.TabIndex = 96;
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Visible = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(496, 379);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(39, 37);
            this.BtnEdit.TabIndex = 94;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnd.Image")));
            this.BtnEnd.Location = new System.Drawing.Point(135, 379);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(39, 37);
            this.BtnEnd.TabIndex = 100;
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(97, 379);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(39, 37);
            this.BtnNext.TabIndex = 99;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(599, 379);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 37);
            this.BtnClose.TabIndex = 104;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(458, 379);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(39, 37);
            this.BtnSave.TabIndex = 95;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.Location = new System.Drawing.Point(420, 379);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(39, 37);
            this.BtnFind.TabIndex = 102;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(59, 379);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(39, 37);
            this.BtnBack.TabIndex = 98;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.Location = new System.Drawing.Point(534, 379);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(39, 37);
            this.BtnDel.TabIndex = 103;
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.Image = ((System.Drawing.Image)(resources.GetObject("BtnTop.Image")));
            this.BtnTop.Location = new System.Drawing.Point(21, 379);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(39, 37);
            this.BtnTop.TabIndex = 97;
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(458, 379);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(39, 37);
            this.BtnNew.TabIndex = 93;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(382, 379);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(39, 37);
            this.BtnPrint.TabIndex = 107;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnPrintPerBarang
            // 
            this.btnPrintPerBarang.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPerBarang.Image")));
            this.btnPrintPerBarang.Location = new System.Drawing.Point(382, 422);
            this.btnPrintPerBarang.Name = "btnPrintPerBarang";
            this.btnPrintPerBarang.Size = new System.Drawing.Size(39, 37);
            this.btnPrintPerBarang.TabIndex = 108;
            this.btnPrintPerBarang.UseVisualStyleBackColor = true;
            this.btnPrintPerBarang.Click += new System.EventHandler(this.btnPrintPerBarang_Click);
            // 
            // FormNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 465);
            this.Controls.Add(this.btnPrintPerBarang);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.cmbNonota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.txtNoNotaJual);
            this.Controls.Add(this.BtnTop);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DgvDetailJual);
            this.Controls.Add(this.LblKetDel);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblKeterangan);
            this.Controls.Add(this.LblKetBackSpace);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtTanggal);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.GroupBox2);
            this.Name = "FormNotaJual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNotaJual";
            this.Load += new System.EventHandler(this.FormNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetailJual)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button BtnUndo;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button BtnEnd;
        internal System.Windows.Forms.Button BtnNext;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnFind;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnDel;
        internal System.Windows.Forms.TextBox txtNoNotaJual;
        internal System.Windows.Forms.Button BtnTop;
        internal System.Windows.Forms.Button BtnNew;
        internal System.Windows.Forms.DataGridView DgvDetailJual;
        internal System.Windows.Forms.Label LblKetDel;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox TxtTotal;
        internal System.Windows.Forms.Label LblKeterangan;
        internal System.Windows.Forms.TextBox TxtNamaBarang;
        internal System.Windows.Forms.Label LblKetBackSpace;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtTanggal;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox TxtJumlah;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TxtHarga;
        internal System.Windows.Forms.TextBox TxtKodeBarang;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbNonota;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button btnPrintPerBarang;
    }
}