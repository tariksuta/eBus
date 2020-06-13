namespace eBus.WinUI.Linija
{
    partial class frmLinijaDetalji
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
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.Odredište = new System.Windows.Forms.Label();
            this.cmbOdrediste = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPolaziste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKreiraj);
            this.groupBox1.Controls.Add(this.Odredište);
            this.groupBox1.Controls.Add(this.cmbOdrediste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPolaziste);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o liniji";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(466, 218);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(146, 32);
            this.btnKreiraj.TabIndex = 14;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // Odredište
            // 
            this.Odredište.AutoSize = true;
            this.Odredište.Location = new System.Drawing.Point(384, 104);
            this.Odredište.Name = "Odredište";
            this.Odredište.Size = new System.Drawing.Size(82, 20);
            this.Odredište.TabIndex = 5;
            this.Odredište.Text = "Odredište";
            // 
            // cmbOdrediste
            // 
            this.cmbOdrediste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdrediste.FormattingEnabled = true;
            this.cmbOdrediste.Location = new System.Drawing.Point(387, 138);
            this.cmbOdrediste.Name = "cmbOdrediste";
            this.cmbOdrediste.Size = new System.Drawing.Size(287, 28);
            this.cmbOdrediste.TabIndex = 4;
            this.cmbOdrediste.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOdrediste_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Polazište";
            // 
            // cmbPolaziste
            // 
            this.cmbPolaziste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPolaziste.FormattingEnabled = true;
            this.cmbPolaziste.Location = new System.Drawing.Point(75, 138);
            this.cmbPolaziste.Name = "cmbPolaziste";
            this.cmbPolaziste.Size = new System.Drawing.Size(287, 28);
            this.cmbPolaziste.TabIndex = 2;
            this.cmbPolaziste.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPolaziste_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(75, 64);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(599, 26);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLinijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 326);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLinijaDetalji";
            this.Text = "frmLinijaDetalji";
            this.Load += new System.EventHandler(this.frmLinijaDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label Odredište;
        private System.Windows.Forms.ComboBox cmbOdrediste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPolaziste;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}