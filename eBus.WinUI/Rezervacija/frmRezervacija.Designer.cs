namespace eBus.WinUI.Rezervacija
{
    partial class frmRezervacija
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
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Karta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazana = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Putnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QRcode = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPutnici = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(-2, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista rezervacija";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumKreiranja,
            this.DatumIsteka,
            this.Karta,
            this.Otkazana,
            this.Putnik,
            this.QRcode});
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacije.Location = new System.Drawing.Point(3, 18);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(796, 280);
            this.dgvRezervacije.TabIndex = 0;
            this.dgvRezervacije.DoubleClick += new System.EventHandler(this.dgvRezervacije_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "RezervacijaId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.MinimumWidth = 6;
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIsteka.DataPropertyName = "DatumIsteka";
            this.DatumIsteka.HeaderText = "Datum Isteka";
            this.DatumIsteka.MinimumWidth = 6;
            this.DatumIsteka.Name = "DatumIsteka";
            this.DatumIsteka.ReadOnly = true;
            // 
            // Karta
            // 
            this.Karta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Karta.DataPropertyName = "Karta";
            this.Karta.HeaderText = "Karta";
            this.Karta.MinimumWidth = 6;
            this.Karta.Name = "Karta";
            this.Karta.ReadOnly = true;
            // 
            // Otkazana
            // 
            this.Otkazana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Otkazana.DataPropertyName = "Otkazana";
            this.Otkazana.HeaderText = "Otkazana";
            this.Otkazana.MinimumWidth = 6;
            this.Otkazana.Name = "Otkazana";
            this.Otkazana.ReadOnly = true;
            // 
            // Putnik
            // 
            this.Putnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Putnik.DataPropertyName = "Putnik";
            this.Putnik.HeaderText = "Putnik";
            this.Putnik.MinimumWidth = 6;
            this.Putnik.Name = "Putnik";
            this.Putnik.ReadOnly = true;
            // 
            // QRcode
            // 
            this.QRcode.DataPropertyName = "QRcode";
            this.QRcode.HeaderText = "QR kod";
            this.QRcode.MinimumWidth = 6;
            this.QRcode.Name = "QRcode";
            this.QRcode.ReadOnly = true;
            this.QRcode.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPutnici);
            this.groupBox2.Location = new System.Drawing.Point(211, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraži po putniku";
            // 
            // cmbPutnici
            // 
            this.cmbPutnici.FormattingEnabled = true;
            this.cmbPutnici.Location = new System.Drawing.Point(22, 42);
            this.cmbPutnici.Name = "cmbPutnici";
            this.cmbPutnici.Size = new System.Drawing.Size(288, 24);
            this.cmbPutnici.TabIndex = 0;
            this.cmbPutnici.SelectedIndexChanged += new System.EventHandler(this.cmbPutnici_SelectedIndexChanged);
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacija";
            this.Text = "frmRezervacija";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPutnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Karta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Otkazana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putnik;
        private System.Windows.Forms.DataGridViewImageColumn QRcode;
    }
}