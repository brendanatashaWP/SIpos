namespace WindowsFormsClient
{
    partial class FormOpening
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnJual = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang di Aplikasi Berbasis Desktop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(149, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dibuat oleh: Brenda Natasha Wijaya Pinem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(233, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "72150001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(100, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sistem Informasi Persediaan Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(47, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Silahkan Pilih Menu :";
            // 
            // btnBarang
            // 
            this.btnBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBarang.Location = new System.Drawing.Point(49, 147);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(217, 90);
            this.btnBarang.TabIndex = 6;
            this.btnBarang.Text = "Form Barang";
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSup.Location = new System.Drawing.Point(49, 243);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(217, 91);
            this.btnSup.TabIndex = 7;
            this.btnSup.Text = "Form Supplier";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnBeli
            // 
            this.btnBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBeli.Location = new System.Drawing.Point(272, 147);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(212, 90);
            this.btnBeli.TabIndex = 8;
            this.btnBeli.Text = "Form Nota Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnJual
            // 
            this.btnJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnJual.Location = new System.Drawing.Point(272, 243);
            this.btnJual.Name = "btnJual";
            this.btnJual.Size = new System.Drawing.Size(212, 91);
            this.btnJual.TabIndex = 9;
            this.btnJual.Text = "Form Nota Jual";
            this.btnJual.UseVisualStyleBackColor = true;
            this.btnJual.Click += new System.EventHandler(this.btnJual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Version 2.0";
            // 
            // FormOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsClient.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 365);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnJual);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOpening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnJual;
        private System.Windows.Forms.Label label6;
    }
}