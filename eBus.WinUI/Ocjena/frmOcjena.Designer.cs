namespace eBus.WinUI.Ocjena
{
    partial class frmOcjena
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
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKompanije = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Putnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kompanija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcjenaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOcjene);
            this.groupBox1.Location = new System.Drawing.Point(2, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista ocjena";
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.AllowUserToAddRows = false;
            this.dgvOcjene.AllowUserToDeleteRows = false;
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Putnik,
            this.Kompanija,
            this.OcjenaUsluge,
            this.Komentar});
            this.dgvOcjene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOcjene.Location = new System.Drawing.Point(3, 18);
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.ReadOnly = true;
            this.dgvOcjene.RowHeadersWidth = 51;
            this.dgvOcjene.RowTemplate.Height = 24;
            this.dgvOcjene.Size = new System.Drawing.Size(610, 276);
            this.dgvOcjene.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKompanije);
            this.groupBox2.Location = new System.Drawing.Point(121, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po kompaniji";
            // 
            // cmbKompanije
            // 
            this.cmbKompanije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKompanije.FormattingEnabled = true;
            this.cmbKompanije.Location = new System.Drawing.Point(37, 43);
            this.cmbKompanije.Name = "cmbKompanije";
            this.cmbKompanije.Size = new System.Drawing.Size(272, 28);
            this.cmbKompanije.TabIndex = 0;
            this.cmbKompanije.SelectedIndexChanged += new System.EventHandler(this.cmbKompanije_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "OcjenaID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
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
            // Kompanija
            // 
            this.Kompanija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kompanija.DataPropertyName = "Kompanija";
            this.Kompanija.HeaderText = "Kompanija";
            this.Kompanija.MinimumWidth = 6;
            this.Kompanija.Name = "Kompanija";
            this.Kompanija.ReadOnly = true;
            // 
            // OcjenaUsluge
            // 
            this.OcjenaUsluge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OcjenaUsluge.DataPropertyName = "OcjenaUsluge";
            this.OcjenaUsluge.HeaderText = "OcjenaUsluge";
            this.OcjenaUsluge.MinimumWidth = 6;
            this.OcjenaUsluge.Name = "OcjenaUsluge";
            this.OcjenaUsluge.ReadOnly = true;
            // 
            // Komentar
            // 
            this.Komentar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.MinimumWidth = 6;
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            // 
            // frmOcjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOcjena";
            this.Text = "frmOcjena";
            this.Load += new System.EventHandler(this.frmOcjena_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOcjene;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKompanije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kompanija;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
    }
}