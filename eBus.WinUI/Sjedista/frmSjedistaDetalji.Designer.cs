namespace eBus.WinUI.Sjedista
{
    partial class frmSjedistaDetalji
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojRedova = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBrojRedova);
            this.groupBox1.Controls.Add(this.btnSpasi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbVozila);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKolona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRed);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o sjedištima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj redova";
            // 
            // txtBrojRedova
            // 
            this.txtBrojRedova.Location = new System.Drawing.Point(109, 106);
            this.txtBrojRedova.Name = "txtBrojRedova";
            this.txtBrojRedova.Size = new System.Drawing.Size(50, 22);
            this.txtBrojRedova.TabIndex = 7;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(392, 52);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(97, 28);
            this.btnSpasi.TabIndex = 6;
            this.btnSpasi.Text = "Sačuvaj";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vozilo";
            // 
            // cmbVozila
            // 
            this.cmbVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(109, 52);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(242, 28);
            this.cmbVozila.TabIndex = 0;
            this.cmbVozila.SelectedIndexChanged += new System.EventHandler(this.cmbVozila_SelectedIndexChanged);
            this.cmbVozila.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVozila_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "KOLONA";
            // 
            // txtKolona
            // 
            this.txtKolona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolona.Location = new System.Drawing.Point(367, 148);
            this.txtKolona.Name = "txtKolona";
            this.txtKolona.Size = new System.Drawing.Size(122, 26);
            this.txtKolona.TabIndex = 2;
            this.txtKolona.Validating += new System.ComponentModel.CancelEventHandler(this.txtKolona_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RED";
            // 
            // txtRed
            // 
            this.txtRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.Location = new System.Drawing.Point(109, 148);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(117, 26);
            this.txtRed.TabIndex = 1;
            this.txtRed.Validating += new System.ComponentModel.CancelEventHandler(this.txtRed_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSjedistaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 230);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSjedistaDetalji";
            this.Text = "frmSjedistaDetalji";
            this.Load += new System.EventHandler(this.frmSjedistaDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVozila;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojRedova;
    }
}