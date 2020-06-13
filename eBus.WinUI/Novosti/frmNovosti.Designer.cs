namespace eBus.WinUI.Novosti
{
    partial class frmNovosti
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
            this.dgvNovosti = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dtpDatumObjave = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovosti)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNovosti);
            this.groupBox1.Location = new System.Drawing.Point(5, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista novina";
            // 
            // dgvNovosti
            // 
            this.dgvNovosti.AllowUserToAddRows = false;
            this.dgvNovosti.AllowUserToDeleteRows = false;
            this.dgvNovosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.Sadrzaj,
            this.DatumObjave,
            this.Korisnik});
            this.dgvNovosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNovosti.Location = new System.Drawing.Point(3, 18);
            this.dgvNovosti.Name = "dgvNovosti";
            this.dgvNovosti.ReadOnly = true;
            this.dgvNovosti.RowHeadersWidth = 51;
            this.dgvNovosti.RowTemplate.Height = 24;
            this.dgvNovosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNovosti.Size = new System.Drawing.Size(699, 266);
            this.dgvNovosti.TabIndex = 0;
            this.dgvNovosti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNovosti_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNaslov);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po naslovu";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(6, 45);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(242, 26);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.TextChanged += new System.EventHandler(this.txtNaslov_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPretrazi);
            this.groupBox3.Controls.Add(this.dtpDatumObjave);
            this.groupBox3.Location = new System.Drawing.Point(319, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga po datumu objave";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(252, 45);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(104, 36);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dtpDatumObjave
            // 
            this.dtpDatumObjave.Location = new System.Drawing.Point(6, 49);
            this.dtpDatumObjave.Name = "dtpDatumObjave";
            this.dtpDatumObjave.Size = new System.Drawing.Size(225, 22);
            this.dtpDatumObjave.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "NovostiID";
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
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.MinimumWidth = 6;
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "DatumObjave";
            this.DatumObjave.MinimumWidth = 6;
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // frmNovosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovosti";
            this.Text = "frmNovosti";
            this.Load += new System.EventHandler(this.frmNovosti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovosti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNovosti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDatumObjave;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
    }
}