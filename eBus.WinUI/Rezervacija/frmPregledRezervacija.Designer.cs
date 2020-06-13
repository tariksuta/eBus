namespace eBus.WinUI.Rezervacija
{
    partial class frmPregledRezervacija
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
            this.pbQRcode = new System.Windows.Forms.PictureBox();
            this.txtDatumIsteka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumKreiranja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbQRcode);
            this.groupBox1.Controls.Add(this.txtDatumIsteka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDatumKreiranja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacija";
            // 
            // pbQRcode
            // 
            this.pbQRcode.Location = new System.Drawing.Point(104, 107);
            this.pbQRcode.Name = "pbQRcode";
            this.pbQRcode.Size = new System.Drawing.Size(296, 246);
            this.pbQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRcode.TabIndex = 8;
            this.pbQRcode.TabStop = false;
            // 
            // txtDatumIsteka
            // 
            this.txtDatumIsteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumIsteka.Location = new System.Drawing.Point(325, 62);
            this.txtDatumIsteka.Name = "txtDatumIsteka";
            this.txtDatumIsteka.ReadOnly = true;
            this.txtDatumIsteka.Size = new System.Drawing.Size(161, 28);
            this.txtDatumIsteka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum isteka";
            // 
            // txtDatumKreiranja
            // 
            this.txtDatumKreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumKreiranja.Location = new System.Drawing.Point(49, 62);
            this.txtDatumKreiranja.Name = "txtDatumKreiranja";
            this.txtDatumKreiranja.ReadOnly = true;
            this.txtDatumKreiranja.Size = new System.Drawing.Size(170, 28);
            this.txtDatumKreiranja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum kreiranja";
            // 
            // frmPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregledRezervacija";
            this.Text = "frmPregledRezervacija";
            this.Load += new System.EventHandler(this.frmPregledRezervacija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatumIsteka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbQRcode;
    }
}