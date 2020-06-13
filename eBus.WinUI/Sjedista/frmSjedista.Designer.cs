namespace eBus.WinUI.Sjedista
{
    partial class frmSjedista
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
            this.dgvSjedista = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSjedista);
            this.groupBox1.Location = new System.Drawing.Point(2, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Popis sjedišta";
            // 
            // dgvSjedista
            // 
            this.dgvSjedista.AllowUserToAddRows = false;
            this.dgvSjedista.AllowUserToDeleteRows = false;
            this.dgvSjedista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSjedista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Red,
            this.Kolona,
            this.Vozilo});
            this.dgvSjedista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSjedista.Location = new System.Drawing.Point(3, 18);
            this.dgvSjedista.Name = "dgvSjedista";
            this.dgvSjedista.ReadOnly = true;
            this.dgvSjedista.RowHeadersWidth = 51;
            this.dgvSjedista.RowTemplate.Height = 24;
            this.dgvSjedista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSjedista.Size = new System.Drawing.Size(603, 274);
            this.dgvSjedista.TabIndex = 0;
            this.dgvSjedista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSjedista_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "SjedisteId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Red
            // 
            this.Red.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Red.DataPropertyName = "Red";
            this.Red.HeaderText = "Red";
            this.Red.MinimumWidth = 6;
            this.Red.Name = "Red";
            this.Red.ReadOnly = true;
            // 
            // Kolona
            // 
            this.Kolona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kolona.DataPropertyName = "Kolona";
            this.Kolona.HeaderText = "Kolona";
            this.Kolona.MinimumWidth = 6;
            this.Kolona.Name = "Kolona";
            this.Kolona.ReadOnly = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVozila);
            this.groupBox2.Location = new System.Drawing.Point(117, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraži po vozilu";
            // 
            // cmbVozila
            // 
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(52, 42);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(229, 24);
            this.cmbVozila.TabIndex = 0;
            this.cmbVozila.SelectedIndexChanged += new System.EventHandler(this.cmbVozila_SelectedIndexChanged);
            // 
            // frmSjedista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSjedista";
            this.Text = "frmSjedista";
            this.Load += new System.EventHandler(this.frmSjedista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSjedista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozilo;
    }
}