namespace eBus.WinUI.Novosti
{
    partial class frmNovostiDetalji
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumObjave = new System.Windows.Forms.DateTimePicker();
            this.Sadržaj = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDatumObjave);
            this.groupBox1.Controls.Add(this.Sadržaj);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Location = new System.Drawing.Point(28, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novost";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Black;
            this.btnSacuvaj.Location = new System.Drawing.Point(507, 259);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(173, 29);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum objave";
            // 
            // dtpDatumObjave
            // 
            this.dtpDatumObjave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumObjave.Location = new System.Drawing.Point(126, 262);
            this.dtpDatumObjave.Name = "dtpDatumObjave";
            this.dtpDatumObjave.Size = new System.Drawing.Size(267, 26);
            this.dtpDatumObjave.TabIndex = 4;
            // 
            // Sadržaj
            // 
            this.Sadržaj.AutoSize = true;
            this.Sadržaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sadržaj.ForeColor = System.Drawing.Color.Black;
            this.Sadržaj.Location = new System.Drawing.Point(38, 147);
            this.Sadržaj.Name = "Sadržaj";
            this.Sadržaj.Size = new System.Drawing.Size(58, 18);
            this.Sadržaj.TabIndex = 3;
            this.Sadržaj.Text = "Sadržaj";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(126, 114);
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(583, 108);
            this.txtSadrzaj.TabIndex = 2;
            this.txtSadrzaj.Text = "";
            this.txtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSadrzaj_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(126, 46);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(583, 26);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNovostiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 385);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "frmNovostiDetalji";
            this.Text = "frmNovostiDetalji";
            this.Load += new System.EventHandler(this.frmNovostiDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Sadržaj;
        private System.Windows.Forms.RichTextBox txtSadrzaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumObjave;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}