namespace eBus.WinUI.Angazuje
{
    partial class frmAngazuje
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
            this.dgvAngazuje = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLinije = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazuje)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAngazuje);
            this.groupBox1.Location = new System.Drawing.Point(6, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Popis angažovanih";
            // 
            // dgvAngazuje
            // 
            this.dgvAngazuje.AllowUserToAddRows = false;
            this.dgvAngazuje.AllowUserToDeleteRows = false;
            this.dgvAngazuje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngazuje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Linija,
            this.Vozilo});
            this.dgvAngazuje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAngazuje.Location = new System.Drawing.Point(3, 18);
            this.dgvAngazuje.Name = "dgvAngazuje";
            this.dgvAngazuje.ReadOnly = true;
            this.dgvAngazuje.RowHeadersWidth = 51;
            this.dgvAngazuje.RowTemplate.Height = 24;
            this.dgvAngazuje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAngazuje.Size = new System.Drawing.Size(612, 277);
            this.dgvAngazuje.TabIndex = 0;
            this.dgvAngazuje.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAngazuje_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLinije);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po linijama";
            // 
            // cmbLinije
            // 
            this.cmbLinije.FormattingEnabled = true;
            this.cmbLinije.Location = new System.Drawing.Point(6, 40);
            this.cmbLinije.Name = "cmbLinije";
            this.cmbLinije.Size = new System.Drawing.Size(246, 24);
            this.cmbLinije.TabIndex = 0;
            this.cmbLinije.SelectedIndexChanged += new System.EventHandler(this.cmbLinije_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbVozila);
            this.groupBox3.Location = new System.Drawing.Point(316, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga po vozilima";
            // 
            // cmbVozila
            // 
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(6, 40);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(246, 24);
            this.cmbVozila.TabIndex = 0;
            this.cmbVozila.SelectedIndexChanged += new System.EventHandler(this.cmbVozila_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "AngazujeId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
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
            // Vozilo
            // 
            this.Vozilo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vozilo.DataPropertyName = "Vozilo";
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.MinimumWidth = 6;
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            // 
            // frmAngazuje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAngazuje";
            this.Text = "frmAngazuje";
            this.Load += new System.EventHandler(this.frmAngazuje_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngazuje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAngazuje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLinije;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
    }
}