namespace eBus.WinUI.Vozilo
{
    partial class frmVozila
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
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registracija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kompanija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKompanije = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVozila);
            this.groupBox1.Location = new System.Drawing.Point(0, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista vozila";
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Proizvodjac,
            this.Model,
            this.Registracija,
            this.Kompanija,
            this.BrojSjedista});
            this.dgvVozila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVozila.Location = new System.Drawing.Point(3, 18);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(607, 216);
            this.dgvVozila.TabIndex = 0;
            this.dgvVozila.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVozila_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "VoziloId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proizvodjac.DataPropertyName = "Proizvodjac";
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.MinimumWidth = 6;
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Registracija
            // 
            this.Registracija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Registracija.DataPropertyName = "Registracija";
            this.Registracija.HeaderText = "Registracija";
            this.Registracija.MinimumWidth = 6;
            this.Registracija.Name = "Registracija";
            this.Registracija.ReadOnly = true;
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
            // BrojSjedista
            // 
            this.BrojSjedista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "BrojSjedista";
            this.BrojSjedista.MinimumWidth = 6;
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKompanije);
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po kompanijama";
            // 
            // cmbKompanije
            // 
            this.cmbKompanije.FormattingEnabled = true;
            this.cmbKompanije.Location = new System.Drawing.Point(26, 31);
            this.cmbKompanije.Name = "cmbKompanije";
            this.cmbKompanije.Size = new System.Drawing.Size(255, 24);
            this.cmbKompanije.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(394, 49);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(148, 33);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 360);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVozila";
            this.Text = "frmVozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKompanije;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registracija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kompanija;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
    }
}