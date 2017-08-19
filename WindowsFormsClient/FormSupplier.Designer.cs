namespace WindowsFormsClient
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbnamaSupplier = new System.Windows.Forms.TextBox();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKota
            // 
            this.tbKota.Enabled = false;
            this.tbKota.Location = new System.Drawing.Point(406, 44);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(106, 20);
            this.tbKota.TabIndex = 102;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(344, 47);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 13);
            this.Label4.TabIndex = 93;
            this.Label4.Text = "Kota";
            // 
            // tbTelepon
            // 
            this.tbTelepon.Enabled = false;
            this.tbTelepon.Location = new System.Drawing.Point(582, 45);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(88, 20);
            this.tbTelepon.TabIndex = 105;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(536, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(46, 13);
            this.Label5.TabIndex = 97;
            this.Label5.Text = "Telepon";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Enabled = false;
            this.tbAlamat.Location = new System.Drawing.Point(406, 21);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(264, 20);
            this.tbAlamat.TabIndex = 100;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(344, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 96;
            this.Label3.Text = "Alamat";
            // 
            // tbnamaSupplier
            // 
            this.tbnamaSupplier.Enabled = false;
            this.tbnamaSupplier.Location = new System.Drawing.Point(97, 44);
            this.tbnamaSupplier.MaxLength = 40;
            this.tbnamaSupplier.Name = "tbnamaSupplier";
            this.tbnamaSupplier.Size = new System.Drawing.Size(237, 20);
            this.tbnamaSupplier.TabIndex = 99;
            // 
            // tbKode
            // 
            this.tbKode.Enabled = false;
            this.tbKode.Location = new System.Drawing.Point(97, 18);
            this.tbKode.MaxLength = 5;
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(58, 20);
            this.tbKode.TabIndex = 94;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 13);
            this.Label2.TabIndex = 95;
            this.Label2.Text = "Nama Supplier";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(500, 257);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(39, 37);
            this.BtnEdit.TabIndex = 103;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnd.Image")));
            this.BtnEnd.Location = new System.Drawing.Point(136, 257);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(39, 37);
            this.BtnEnd.TabIndex = 111;
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(98, 257);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(39, 37);
            this.BtnNext.TabIndex = 110;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(464, 291);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(39, 37);
            this.BtnSave.TabIndex = 106;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(605, 257);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 37);
            this.BtnClose.TabIndex = 115;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.Location = new System.Drawing.Point(426, 257);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(39, 37);
            this.BtnFind.TabIndex = 113;
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(60, 257);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(39, 37);
            this.BtnBack.TabIndex = 109;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.Location = new System.Drawing.Point(540, 257);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(39, 37);
            this.BtnDel.TabIndex = 114;
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(388, 257);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(39, 37);
            this.BtnPrint.TabIndex = 112;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.Image = ((System.Drawing.Image)(resources.GetObject("BtnTop.Image")));
            this.BtnTop.Location = new System.Drawing.Point(22, 257);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(39, 37);
            this.BtnTop.TabIndex = 108;
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 98;
            this.Label1.Text = "Kode";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSupplier.Location = new System.Drawing.Point(22, 77);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.Size = new System.Drawing.Size(648, 174);
            this.dgvSupplier.TabIndex = 104;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodeSupplier";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = " Kode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namaSupplier";
            this.Column2.HeaderText = "Nama Supplier";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "alamat";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Alamat";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "kota";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Kota";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "telpon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Telpon";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(464, 257);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(39, 37);
            this.BtnNew.TabIndex = 101;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.Location = new System.Drawing.Point(500, 291);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(39, 37);
            this.BtnUndo.TabIndex = 107;
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Visible = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 347);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tbTelepon);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbnamaSupplier);
            this.Controls.Add(this.tbKode);
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
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnUndo);
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbKota;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tbTelepon;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tbAlamat;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbnamaSupplier;
        internal System.Windows.Forms.TextBox tbKode;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnEnd;
        internal System.Windows.Forms.Button BtnNext;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnFind;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnDel;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button BtnTop;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvSupplier;
        internal System.Windows.Forms.Button BtnNew;
        internal System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}