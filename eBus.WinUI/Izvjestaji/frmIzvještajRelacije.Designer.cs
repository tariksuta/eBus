namespace eBus.WinUI.Izvjestaji
{
    partial class frmIzvještajRelacije
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
            this.cmbLinije = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.Linija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kompanija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreuzmi = new System.Windows.Forms.Button();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLinije
            // 
            this.cmbLinije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinije.FormattingEnabled = true;
            this.cmbLinije.Location = new System.Drawing.Point(32, 34);
            this.cmbLinije.Name = "cmbLinije";
            this.cmbLinije.Size = new System.Drawing.Size(194, 28);
            this.cmbLinije.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPretrazi);
            this.groupBox1.Controls.Add(this.cmbLinije);
            this.groupBox1.Location = new System.Drawing.Point(119, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linije";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(312, 35);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(95, 31);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPodaci);
            this.groupBox2.Location = new System.Drawing.Point(-1, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 306);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrirani podaci";
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linija,
            this.BrojKarte,
            this.DatumIzdavanja,
            this.Kompanija,
            this.Cijena,
            this.Vozilo});
            this.dgvPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPodaci.Location = new System.Drawing.Point(3, 18);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.RowHeadersWidth = 51;
            this.dgvPodaci.RowTemplate.Height = 24;
            this.dgvPodaci.Size = new System.Drawing.Size(793, 285);
            this.dgvPodaci.TabIndex = 0;
            // 
            // Linija
            // 
            this.Linija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Linija.DataPropertyName = "Linija";
            this.Linija.HeaderText = "Linija";
            this.Linija.MinimumWidth = 6;
            this.Linija.Name = "Linija";
            this.Linija.ReadOnly = true;
            // 
            // BrojKarte
            // 
            this.BrojKarte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojKarte.DataPropertyName = "BrojKarte";
            this.BrojKarte.HeaderText = "Broj karte";
            this.BrojKarte.MinimumWidth = 6;
            this.BrojKarte.Name = "BrojKarte";
            this.BrojKarte.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.MinimumWidth = 6;
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // Kompanija
            // 
            this.Kompanija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kompanija.DataPropertyName = "Kompanija";
            this.Kompanija.HeaderText = "Kompanija";
            this.Kompanija.MinimumWidth = 6;
            this.Kompanija.Name = "Kompanija";
            this.Kompanija.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Vozilo
            // 
            this.Vozilo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vozilo.DataPropertyName = "Vozilo";
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.MinimumWidth = 6;
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            // 
            // btnPreuzmi
            // 
            this.btnPreuzmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreuzmi.Location = new System.Drawing.Point(664, 496);
            this.btnPreuzmi.Name = "btnPreuzmi";
            this.btnPreuzmi.Size = new System.Drawing.Size(131, 36);
            this.btnPreuzmi.TabIndex = 4;
            this.btnPreuzmi.Text = "Preuzmi";
            this.btnPreuzmi.UseVisualStyleBackColor = true;
            this.btnPreuzmi.Click += new System.EventHandler(this.btnPreuzmi_Click);
            // 
            // txtUkupno
            // 
            this.txtUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupno.Location = new System.Drawing.Point(315, 506);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 26);
            this.txtUkupno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ukupan iznos ";
            // 
            // frmIzvještajRelacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.btnPreuzmi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIzvještajRelacije";
            this.Text = "frmIzvještajRelacije";
            this.Load += new System.EventHandler(this.frmIzvještajRelacije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLinije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Button btnPreuzmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linija;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kompanija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label1;
    }
}