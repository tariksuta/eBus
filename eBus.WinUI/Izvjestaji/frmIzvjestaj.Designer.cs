namespace eBus.WinUI.Izvjestaji
{
    partial class frmIzvjestaj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPutnici = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.cmbPutnici);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaj o rezervisanim kartama po putnicima";
            // 
            // cmbPutnici
            // 
            this.cmbPutnici.FormattingEnabled = true;
            this.cmbPutnici.Location = new System.Drawing.Point(25, 52);
            this.cmbPutnici.Name = "cmbPutnici";
            this.cmbPutnici.Size = new System.Drawing.Size(237, 24);
            this.cmbPutnici.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(348, 52);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(123, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 154);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIzvjestaj";
            this.Text = "frmIzvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbPutnici;
    }
}