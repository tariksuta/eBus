namespace eBus.WinUI.Linija
{
    partial class frmCijenaDetalji
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPopust = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLinija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKompanija = new System.Windows.Forms.ComboBox();
            this.btnSačuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPopust);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbLinija);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKompanija);
            this.groupBox1.Controls.Add(this.btnSačuvaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o cijeni";
            // 
            // txtPopust
            // 
            this.txtPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopust.Location = new System.Drawing.Point(246, 51);
            this.txtPopust.Mask = "0,00";
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 26);
            this.txtPopust.TabIndex = 9;
            this.txtPopust.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Linija";
            // 
            // cmbLinija
            // 
            this.cmbLinija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinija.FormattingEnabled = true;
            this.cmbLinija.Location = new System.Drawing.Point(27, 169);
            this.cmbLinija.Name = "cmbLinija";
            this.cmbLinija.Size = new System.Drawing.Size(355, 28);
            this.cmbLinija.TabIndex = 7;
            this.cmbLinija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLinija_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kompanija";
            // 
            // cmbKompanija
            // 
            this.cmbKompanija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKompanija.FormattingEnabled = true;
            this.cmbKompanija.Location = new System.Drawing.Point(24, 109);
            this.cmbKompanija.Name = "cmbKompanija";
            this.cmbKompanija.Size = new System.Drawing.Size(358, 28);
            this.cmbKompanija.TabIndex = 5;
            this.cmbKompanija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKompanija_Validating);
            // 
            // btnSačuvaj
            // 
            this.btnSačuvaj.Location = new System.Drawing.Point(27, 239);
            this.btnSačuvaj.Name = "btnSačuvaj";
            this.btnSačuvaj.Size = new System.Drawing.Size(190, 28);
            this.btnSačuvaj.TabIndex = 4;
            this.btnSačuvaj.Text = "Sačuvaj";
            this.btnSačuvaj.UseVisualStyleBackColor = true;
            this.btnSačuvaj.Click += new System.EventHandler(this.btnSačuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Popust";
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.Location = new System.Drawing.Point(24, 51);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(154, 26);
            this.txtCijena.TabIndex = 1;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cijena";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCijenaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 333);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCijenaDetalji";
            this.Text = "frmCijenaDetalji";
            this.Load += new System.EventHandler(this.frmCijenaDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSačuvaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKompanija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLinija;
        private System.Windows.Forms.MaskedTextBox txtPopust;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}