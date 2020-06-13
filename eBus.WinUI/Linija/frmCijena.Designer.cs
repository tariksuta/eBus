namespace eBus.WinUI.Linija
{
    partial class frmCijena
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
            this.dgvCijena = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kompanija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNazivLinije = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijena)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCijena);
            this.groupBox1.Location = new System.Drawing.Point(0, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista cijena";
            // 
            // dgvCijena
            // 
            this.dgvCijena.AllowUserToAddRows = false;
            this.dgvCijena.AllowUserToDeleteRows = false;
            this.dgvCijena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Iznos,
            this.Popust,
            this.Kompanija});
            this.dgvCijena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCijena.Location = new System.Drawing.Point(3, 18);
            this.dgvCijena.Name = "dgvCijena";
            this.dgvCijena.ReadOnly = true;
            this.dgvCijena.RowHeadersWidth = 51;
            this.dgvCijena.RowTemplate.Height = 24;
            this.dgvCijena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCijena.Size = new System.Drawing.Size(435, 200);
            this.dgvCijena.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "CijenaID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Iznos
            // 
            this.Iznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.MinimumWidth = 6;
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // Popust
            // 
            this.Popust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust";
            this.Popust.MinimumWidth = 6;
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNazivLinije);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalji linije";
            // 
            // txtNazivLinije
            // 
            this.txtNazivLinije.Location = new System.Drawing.Point(40, 44);
            this.txtNazivLinije.Name = "txtNazivLinije";
            this.txtNazivLinije.Size = new System.Drawing.Size(337, 22);
            this.txtNazivLinije.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(341, 347);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmCijena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 378);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCijena";
            this.Text = "Cijena linije";
            this.Load += new System.EventHandler(this.frmCijena_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijena)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCijena;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNazivLinije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kompanija;
    }
}