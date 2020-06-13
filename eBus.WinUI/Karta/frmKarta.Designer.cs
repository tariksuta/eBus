namespace eBus.WinUI.Karta
{
    partial class frmKarta
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
            this.dgvKarte = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angazuje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKarte);
            this.groupBox1.Location = new System.Drawing.Point(0, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista karata";
            // 
            // dgvKarte
            // 
            this.dgvKarte.AllowUserToAddRows = false;
            this.dgvKarte.AllowUserToDeleteRows = false;
            this.dgvKarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BrojKarte,
            this.DatumIzdavanja,
            this.Angazuje,
            this.Sjediste});
            this.dgvKarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKarte.Location = new System.Drawing.Point(3, 18);
            this.dgvKarte.Name = "dgvKarte";
            this.dgvKarte.ReadOnly = true;
            this.dgvKarte.RowHeadersWidth = 51;
            this.dgvKarte.RowTemplate.Height = 24;
            this.dgvKarte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarte.Size = new System.Drawing.Size(1182, 282);
            this.dgvKarte.TabIndex = 0;
            this.dgvKarte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKarte_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "KartaId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // BrojKarte
            // 
            this.BrojKarte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojKarte.DataPropertyName = "BrojKarte";
            this.BrojKarte.HeaderText = "Broj Karte";
            this.BrojKarte.MinimumWidth = 6;
            this.BrojKarte.Name = "BrojKarte";
            this.BrojKarte.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum Izdavanja";
            this.DatumIzdavanja.MinimumWidth = 6;
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // Angazuje
            // 
            this.Angazuje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Angazuje.DataPropertyName = "Angazuje";
            this.Angazuje.HeaderText = "Linija - vozilo";
            this.Angazuje.MinimumWidth = 6;
            this.Angazuje.Name = "Angazuje";
            this.Angazuje.ReadOnly = true;
            // 
            // Sjediste
            // 
            this.Sjediste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sjediste.DataPropertyName = "Sjediste";
            this.Sjediste.HeaderText = "Sjediste";
            this.Sjediste.MinimumWidth = 6;
            this.Sjediste.Name = "Sjediste";
            this.Sjediste.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDatumIzdavanja);
            this.groupBox2.Location = new System.Drawing.Point(134, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po datumu";
            // 
            // dtpDatumIzdavanja
            // 
            this.dtpDatumIzdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumIzdavanja.Location = new System.Drawing.Point(15, 47);
            this.dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            this.dtpDatumIzdavanja.Size = new System.Drawing.Size(347, 26);
            this.dtpDatumIzdavanja.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(683, 92);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(112, 34);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // frmKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 441);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKarta";
            this.Text = "frmKarta";
            this.Load += new System.EventHandler(this.frmKarta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarte)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKarte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanja;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angazuje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sjediste;
    }
}