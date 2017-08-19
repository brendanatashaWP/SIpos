namespace WindowsFormsClient
{
    partial class FormDataReader
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
            this.rtbBarang = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbBarang
            // 
            this.rtbBarang.Location = new System.Drawing.Point(12, 12);
            this.rtbBarang.Name = "rtbBarang";
            this.rtbBarang.Size = new System.Drawing.Size(236, 142);
            this.rtbBarang.TabIndex = 0;
            this.rtbBarang.Text = "";
            // 
            // FormDataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 160);
            this.Controls.Add(this.rtbBarang);
            this.Name = "FormDataReader";
            this.Text = "FormDataReader";
            this.Load += new System.EventHandler(this.FormDataReader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBarang;

    }
}