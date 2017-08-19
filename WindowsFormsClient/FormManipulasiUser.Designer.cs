namespace WindowsFormsClient
{
    partial class FormManipulasiUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManipulasiUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLapJual = new System.Windows.Forms.CheckBox();
            this.cbLapBeli = new System.Windows.Forms.CheckBox();
            this.cbTransaksiBeli = new System.Windows.Forms.CheckBox();
            this.cbTransaksiJual = new System.Windows.Forms.CheckBox();
            this.cbSetSup = new System.Windows.Forms.CheckBox();
            this.cbSetBar = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(250, 54);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(143, 20);
            this.txtConfirm.TabIndex = 5;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLapJual);
            this.groupBox1.Controls.Add(this.cbLapBeli);
            this.groupBox1.Controls.Add(this.cbTransaksiBeli);
            this.groupBox1.Controls.Add(this.cbTransaksiJual);
            this.groupBox1.Controls.Add(this.cbSetSup);
            this.groupBox1.Controls.Add(this.cbSetBar);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cbLapJual
            // 
            this.cbLapJual.AutoSize = true;
            this.cbLapJual.Location = new System.Drawing.Point(176, 19);
            this.cbLapJual.Name = "cbLapJual";
            this.cbLapJual.Size = new System.Drawing.Size(171, 17);
            this.cbLapJual.TabIndex = 5;
            this.cbLapJual.Text = "Laporan Penjualan Per Barang";
            this.cbLapJual.UseVisualStyleBackColor = true;
            // 
            // cbLapBeli
            // 
            this.cbLapBeli.AutoSize = true;
            this.cbLapBeli.Location = new System.Drawing.Point(176, 52);
            this.cbLapBeli.Name = "cbLapBeli";
            this.cbLapBeli.Size = new System.Drawing.Size(173, 17);
            this.cbLapBeli.TabIndex = 4;
            this.cbLapBeli.Text = "Laporan Pembelian Per Barang";
            this.cbLapBeli.UseVisualStyleBackColor = true;
            // 
            // cbTransaksiBeli
            // 
            this.cbTransaksiBeli.AutoSize = true;
            this.cbTransaksiBeli.Location = new System.Drawing.Point(176, 84);
            this.cbTransaksiBeli.Name = "cbTransaksiBeli";
            this.cbTransaksiBeli.Size = new System.Drawing.Size(124, 17);
            this.cbTransaksiBeli.TabIndex = 3;
            this.cbTransaksiBeli.Text = "Transaksi Pembelian";
            this.cbTransaksiBeli.UseVisualStyleBackColor = true;
            // 
            // cbTransaksiJual
            // 
            this.cbTransaksiJual.AutoSize = true;
            this.cbTransaksiJual.Location = new System.Drawing.Point(17, 83);
            this.cbTransaksiJual.Name = "cbTransaksiJual";
            this.cbTransaksiJual.Size = new System.Drawing.Size(122, 17);
            this.cbTransaksiJual.TabIndex = 2;
            this.cbTransaksiJual.Text = "Transaksi Penjualan";
            this.cbTransaksiJual.UseVisualStyleBackColor = true;
            // 
            // cbSetSup
            // 
            this.cbSetSup.AutoSize = true;
            this.cbSetSup.Location = new System.Drawing.Point(17, 52);
            this.cbSetSup.Name = "cbSetSup";
            this.cbSetSup.Size = new System.Drawing.Size(95, 17);
            this.cbSetSup.TabIndex = 1;
            this.cbSetSup.Text = "Setup Supplier";
            this.cbSetSup.UseVisualStyleBackColor = true;
            // 
            // cbSetBar
            // 
            this.cbSetBar.AutoSize = true;
            this.cbSetBar.Location = new System.Drawing.Point(17, 19);
            this.cbSetBar.Name = "cbSetBar";
            this.cbSetBar.Size = new System.Drawing.Size(91, 17);
            this.cbSetBar.TabIndex = 0;
            this.cbSetBar.Text = "Setup Barang";
            this.cbSetBar.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(183, 223);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(39, 37);
            this.BtnPrint.TabIndex = 95;
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnUndo
            // 
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.Location = new System.Drawing.Point(297, 223);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(39, 37);
            this.BtnUndo.TabIndex = 87;
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Visible = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(297, 223);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(39, 37);
            this.BtnEdit.TabIndex = 85;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnd.Image")));
            this.BtnEnd.Location = new System.Drawing.Point(126, 223);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(39, 37);
            this.BtnEnd.TabIndex = 91;
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnNext.Image")));
            this.BtnNext.Location = new System.Drawing.Point(88, 223);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(39, 37);
            this.BtnNext.TabIndex = 90;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(259, 266);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(39, 37);
            this.BtnSave.TabIndex = 86;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(335, 266);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 37);
            this.BtnClose.TabIndex = 94;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.Location = new System.Drawing.Point(221, 223);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(39, 37);
            this.BtnFind.TabIndex = 92;
            this.BtnFind.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(50, 223);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(39, 37);
            this.BtnBack.TabIndex = 89;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.Location = new System.Drawing.Point(335, 223);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(39, 37);
            this.BtnDel.TabIndex = 93;
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // BtnTop
            // 
            this.BtnTop.Image = ((System.Drawing.Image)(resources.GetObject("BtnTop.Image")));
            this.BtnTop.Location = new System.Drawing.Point(12, 223);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(39, 37);
            this.BtnTop.TabIndex = 88;
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(259, 223);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(39, 37);
            this.BtnNew.TabIndex = 84;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FormManipulasiUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 310);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnTop);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManipulasiUser";
            this.Text = "FormManipulasiUser";
            this.Load += new System.EventHandler(this.FormManipulasiUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLapJual;
        private System.Windows.Forms.CheckBox cbLapBeli;
        private System.Windows.Forms.CheckBox cbTransaksiBeli;
        private System.Windows.Forms.CheckBox cbTransaksiJual;
        private System.Windows.Forms.CheckBox cbSetSup;
        private System.Windows.Forms.CheckBox cbSetBar;
        internal System.Windows.Forms.Button BtnPrint;
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
    }
}