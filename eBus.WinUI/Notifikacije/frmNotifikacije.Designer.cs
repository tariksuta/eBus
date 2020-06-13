namespace eBus.WinUI.Notifikacije
{
    partial class frmNotifikacije
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
            this.dgvNotifikacije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSlanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifikacije)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotifikacije);
            this.groupBox1.Location = new System.Drawing.Point(1, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista notifikacija";
            // 
            // dgvNotifikacije
            // 
            this.dgvNotifikacije.AllowUserToAddRows = false;
            this.dgvNotifikacije.AllowUserToDeleteRows = false;
            this.dgvNotifikacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifikacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.DatumSlanja,
            this.Novost});
            this.dgvNotifikacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotifikacije.Location = new System.Drawing.Point(3, 18);
            this.dgvNotifikacije.Name = "dgvNotifikacije";
            this.dgvNotifikacije.ReadOnly = true;
            this.dgvNotifikacije.RowHeadersWidth = 51;
            this.dgvNotifikacije.RowTemplate.Height = 24;
            this.dgvNotifikacije.Size = new System.Drawing.Size(724, 297);
            this.dgvNotifikacije.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "NotifikacijaID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naslov
            // 
            this.Naslov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.MinimumWidth = 6;
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // DatumSlanja
            // 
            this.DatumSlanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumSlanja.DataPropertyName = "DatumSlanja";
            this.DatumSlanja.HeaderText = "Datum slanja";
            this.DatumSlanja.MinimumWidth = 6;
            this.DatumSlanja.Name = "DatumSlanja";
            this.DatumSlanja.ReadOnly = true;
            // 
            // Novost
            // 
            this.Novost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Novost.DataPropertyName = "Novost";
            this.Novost.HeaderText = "Novost";
            this.Novost.MinimumWidth = 6;
            this.Novost.Name = "Novost";
            this.Novost.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNaslov);
            this.groupBox2.Location = new System.Drawing.Point(176, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po naslovu";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(44, 42);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(287, 26);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.TextChanged += new System.EventHandler(this.txtNaslov_TextChanged);
            // 
            // frmNotifikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNotifikacije";
            this.Text = "frmNotifikacije";
            this.Load += new System.EventHandler(this.frmNotifikacije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifikacije)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNotifikacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSlanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Novost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNaslov;
    }
}