namespace WindowsFormsClient
{
    partial class FormNotaBeli
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaBeli));
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDetailBeli = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtJumlah = new System.Windows.Forms.TextBox();
            this.TxtHarga = new System.Windows.Forms.TextBox();
            this.TxtNoNotaBeli = new System.Windows.Forms.TextBox();
            this.TxtKodeBarang = new System.Windows.Forms.TextBox();
            this.LblKetBackSpace = new System.Windows.Forms.Label();
            this.LblKetDel = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblKeterangan = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtTelpon = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtAlamat = new System.Windows.Forms.TextBox();
            this.TxtKota = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtNamaSupplier = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtKodeSupplier = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtTanggal = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNonota = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPrintPerBarang = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetailBeli)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NoNotaBeli";
            this.Column7.HeaderText = "NoNotaBeli";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NamaBarang";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 230;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "idNotaBeli";
            this.Column6.HeaderText = "IdNotaBeli";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KodeBarang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // DgvDetailBeli
            // 
            this.DgvDetailBeli.AllowUserToAddRows = false;
            this.DgvDetailBeli.AllowUserToDeleteRows = false;
            this.DgvDetailBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetailBeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvDetailBeli.Location = new System.Drawing.Point(9, 121);
            this.DgvDetailBeli.Margin = new System.Windows.Forms.Padding(2);
            this.DgvDetailBeli.Name = "DgvDetailBeli";
            this.DgvDetailBeli.ReadOnly = true;
            this.DgvDetailBeli.RowTemplate.Height = 24;
            this.DgvDetailBeli.Size = new System.Drawing.Size(613, 199);
            this.DgvDetailBeli.TabIndex = 48;
            this.DgvDetailBeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvDetailBeli_KeyDown);
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
            // TxtNoNotaBeli
            // 
            this.TxtNoNotaBeli.Enabled = false;
            this.TxtNoNotaBeli.Location = new System.Drawing.Point(84, 7);
            this.TxtNoNotaBeli.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNoNotaBeli.Name = "TxtNoNotaBeli";
            this.TxtNoNotaBeli.Size = new System.Drawing.Size(76, 20);
            this.TxtNoNotaBeli.TabIndex = 42;
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
            this.TxtKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKodeBarang_KeyUp);
            this.TxtKodeBarang.Leave += new System.EventHandler(this.TxtKodeBarang_Leave);
            this.TxtKodeBarang.Validated += new System.EventHandler(this.TxtKodeBarang_Validated);
            // 
            // LblKetBackSpace
            // 
            this.LblKetBackSpace.AutoSize = true;
            this.LblKetBackSpace.BackColor = System.Drawing.Color.Transparent;
            this.LblKetBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKetBackSpace.ForeColor = System.Drawing.Color.Red;
            this.LblKetBackSpace.Location = new System.Drawing.Point(261, 327);
            this.LblKetBackSpace.Name = "LblKetBackSpace";
            this.LblKetBackSpace.Size = new System.Drawing.Size(76, 13);
            this.LblKetBackSpace.TabIndex = 53;
            this.LblKetBackSpace.Text = "Back Space";
            // 
            // LblKetDel
            // 
            this.LblKetDel.AutoSize = true;
            this.LblKetDel.BackColor = System.Drawing.Color.Transparent;
            this.LblKetDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKetDel.ForeColor = System.Drawing.Color.Red;
            this.LblKetDel.Location = new System.Drawing.Point(46, 327);
            this.LblKetDel.Name = "LblKetDel";
            this.LblKetDel.Size = new System.Drawing.Size(26, 13);
            this.LblKetDel.TabIndex = 52;
            this.LblKetDel.Text = "Del";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(432, 325);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(56, 13);
            this.Label13.TabIndex = 50;
            this.Label13.Text = "Total Rp";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(489, 322);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(108, 21);
            this.TxtTotal.TabIndex = 49;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblKeterangan
            // 
            this.LblKeterangan.AutoSize = true;
            this.LblKeterangan.ForeColor = System.Drawing.Color.Blue;
            this.LblKeterangan.Location = new System.Drawing.Point(11, 327);
            this.LblKeterangan.Name = "LblKeterangan";
            this.LblKeterangan.Size = new System.Drawing.Size(411, 13);
            this.LblKeterangan.TabIndex = 51;
            this.LblKeterangan.Text = "Tekan  Del  pada item pembelian untuk menghapus, Back Space     untuk mengubah";
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
            // TxtTelpon
            // 
            this.TxtTelpon.Enabled = false;
            this.TxtTelpon.Location = new System.Drawing.Point(408, 58);
            this.TxtTelpon.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelpon.Name = "TxtTelpon";
            this.TxtTelpon.Size = new System.Drawing.Size(108, 20);
            this.TxtTelpon.TabIndex = 29;
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
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(369, 61);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(40, 13);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "Telpon";
            // 
            // TxtAlamat
            // 
            this.TxtAlamat.Enabled = false;
            this.TxtAlamat.Location = new System.Drawing.Point(87, 58);
            this.TxtAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAlamat.Name = "TxtAlamat";
            this.TxtAlamat.Size = new System.Drawing.Size(278, 20);
            this.TxtAlamat.TabIndex = 29;
            // 
            // TxtKota
            // 
            this.TxtKota.Enabled = false;
            this.TxtKota.Location = new System.Drawing.Point(408, 36);
            this.TxtKota.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKota.Name = "TxtKota";
            this.TxtKota.Size = new System.Drawing.Size(186, 20);
            this.TxtKota.TabIndex = 29;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TxtTelpon);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.TxtAlamat);
            this.GroupBox1.Controls.Add(this.TxtKota);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.TxtNamaSupplier);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.TxtKodeSupplier);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(6, 29);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(615, 87);
            this.GroupBox1.TabIndex = 46;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " Supplier ";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 61);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Alamat";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(369, 39);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(29, 13);
            this.Label6.TabIndex = 30;
            this.Label6.Text = "Kota";
            // 
            // TxtNamaSupplier
            // 
            this.TxtNamaSupplier.Enabled = false;
            this.TxtNamaSupplier.Location = new System.Drawing.Point(87, 36);
            this.TxtNamaSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNamaSupplier.Name = "TxtNamaSupplier";
            this.TxtNamaSupplier.Size = new System.Drawing.Size(218, 20);
            this.TxtNamaSupplier.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(7, 39);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 13);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "Nama Supplier";
            // 
            // TxtKodeSupplier
            // 
            this.TxtKodeSupplier.Enabled = false;
            this.TxtKodeSupplier.Location = new System.Drawing.Point(87, 14);
            this.TxtKodeSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKodeSupplier.MaxLength = 3;
            this.TxtKodeSupplier.Name = "TxtKodeSupplier";
            this.TxtKodeSupplier.Size = new System.Drawing.Size(38, 20);
            this.TxtKodeSupplier.TabIndex = 0;
            this.TxtKodeSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKodeSupplier_KeyDown);
            this.TxtKodeSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKodeSupplier_KeyUp);
            this.TxtKodeSupplier.Validated += new System.EventHandler(this.TxtKodeSupplier_Validated);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 16);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Kode Supplier";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(444, 9);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Tanggal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "No. Nota Beli";
            // 
            // TxtTanggal
            // 
            this.TxtTanggal.Enabled = false;
            this.TxtTanggal.Location = new System.Drawing.Point(492, 7);
            this.TxtTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTanggal.Name = "TxtTanggal";
            this.TxtTanggal.Size = new System.Drawing.Size(129, 20);
            this.TxtTanggal.TabIndex = 43;
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
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(167, 380);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(187, 13);
            this.Label14.TabIndex = 56;
            this.Label14.Text = "Developed by Katon Wijana, Oct 2016";
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
            this.GroupBox2.Location = new System.Drawing.Point(8, 121);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Size = new System.Drawing.Size(613, 71);
            this.GroupBox2.TabIndex = 47;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = " Item Data Entry ";
            // 
            // cmbNonota
            // 
            this.cmbNonota.FormattingEnabled = true;
            this.cmbNonota.Location = new System.Drawing.Point(84, 7);
            this.cmbNonota.Name = "cmbNonota";
            this.cmbNonota.Size = new System.Drawing.Size(76, 21);
            this.cmbNonota.TabIndex = 80;
            this.cmbNonota.Visible = false;
            this.cmbNonota.SelectedValueChanged += new System.EventHandler(this.cmbNonota_SelectedValueChanged);
            // 
            // btnPrintPerBarang
            // 
            this.btnPrintPerBarang.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPerBarang.Image")));
            this.btnPrintPerBarang.Location = new System.Drawing.Point(369, 399);
            this.btnPrintPerBarang.Name = "btnPrintPerBarang";
            this.btnPrintPerBarang.Size = new System.Drawing.Size(39, 37);
            this.btnPrintPerBarang.TabIndex = 82;
            this.btnPrintPerBarang.UseVisualStyleBackColor = true;
            this.btnPrintPerBarang.Click += new System.EventHandler(this.btnPrintPerBarang_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(369, 356);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(39, 37);
            this.BtnPrint.TabIndex = 81;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.Location = new System.Drawing.Point(483, 356);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(39, 37);
            this.BtnUndo.TabIndex = 71;
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Visible = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(483, 356);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(39, 37);
            this.BtnEdit.TabIndex = 69;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnd.Image")));
            this.BtnEnd.Location = new System.Drawing.Point(122, 356);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(39, 37);
            this.BtnEnd.TabIndex = 75;
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(84, 356);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(39, 37);
            this.BtnNext.TabIndex = 74;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(445, 356);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(39, 37);
            this.BtnSave.TabIndex = 70;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(586, 356);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 37);
            this.BtnClose.TabIndex = 79;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.Location = new System.Drawing.Point(407, 356);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(39, 37);
            this.BtnFind.TabIndex = 77;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(46, 356);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(39, 37);
            this.BtnBack.TabIndex = 73;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.Location = new System.Drawing.Point(521, 356);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(39, 37);
            this.BtnDel.TabIndex = 78;
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.Image = ((System.Drawing.Image)(resources.GetObject("BtnTop.Image")));
            this.BtnTop.Location = new System.Drawing.Point(8, 356);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(39, 37);
            this.BtnTop.TabIndex = 72;
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(445, 356);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(39, 37);
            this.BtnNew.TabIndex = 68;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FormNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 441);
            this.Controls.Add(this.btnPrintPerBarang);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.cmbNonota);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.TxtNoNotaBeli);
            this.Controls.Add(this.BtnTop);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DgvDetailBeli);
            this.Controls.Add(this.LblKetBackSpace);
            this.Controls.Add(this.LblKetDel);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblKeterangan);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtTanggal);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.GroupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotaBeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNotaBeli";
            this.Load += new System.EventHandler(this.FormNotaBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetailBeli)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridView DgvDetailBeli;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.TextBox TxtJumlah;
        internal System.Windows.Forms.TextBox TxtHarga;
        internal System.Windows.Forms.TextBox TxtNoNotaBeli;
        internal System.Windows.Forms.TextBox TxtKodeBarang;
        internal System.Windows.Forms.Label LblKetBackSpace;
        internal System.Windows.Forms.Label LblKetDel;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox TxtTotal;
        internal System.Windows.Forms.Label LblKeterangan;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TxtTelpon;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TxtAlamat;
        internal System.Windows.Forms.TextBox TxtKota;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtNamaSupplier;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtKodeSupplier;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtTanggal;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TxtNamaBarang;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BtnUndo;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnEnd;
        internal System.Windows.Forms.Button BtnNext;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnFind;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnDel;
        internal System.Windows.Forms.Button BtnTop;
        internal System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ComboBox cmbNonota;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button btnPrintPerBarang;

    }
}