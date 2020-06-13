namespace eBus.WinUI.Linija
{
    partial class frmLinija
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
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPolaziste = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbOdrediste = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLinije);
            this.groupBox1.Location = new System.Drawing.Point(4, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(995, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista linija";
            // 
            // dgvLinije
            // 
            this.dgvLinije.AllowUserToAddRows = false;
            this.dgvLinije.AllowUserToDeleteRows = false;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Polaziste,
            this.Odrediste,
            this.Cijena});
            this.dgvLinije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinije.Location = new System.Drawing.Point(4, 23);
            this.dgvLinije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.ReadOnly = true;
            this.dgvLinije.RowHeadersWidth = 51;
            this.dgvLinije.RowTemplate.Height = 24;
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(987, 305);
            this.dgvLinije.TabIndex = 0;
            this.dgvLinije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinije_CellContentClick);
            this.dgvLinije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLinije_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "LinijaID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Polaziste
            // 
            this.Polaziste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Polaziste.DataPropertyName = "Polaziste";
            this.Polaziste.HeaderText = "Polaziste";
            this.Polaziste.MinimumWidth = 6;
            this.Polaziste.Name = "Polaziste";
            this.Polaziste.ReadOnly = true;
            // 
            // Odrediste
            // 
            this.Odrediste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Odrediste.DataPropertyName = "Odrediste";
            this.Odrediste.HeaderText = "Odrediste";
            this.Odrediste.MinimumWidth = 6;
            this.Odrediste.Name = "Odrediste";
            this.Odrediste.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Prikazi";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Text = "Cijena";
            this.Cijena.UseColumnTextForButtonValue = true;
            this.Cijena.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPolaziste);
            this.groupBox2.Location = new System.Drawing.Point(15, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polazište";
            // 
            // cmbPolaziste
            // 
            this.cmbPolaziste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPolaziste.FormattingEnabled = true;
            this.cmbPolaziste.Location = new System.Drawing.Point(8, 49);
            this.cmbPolaziste.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPolaziste.Name = "cmbPolaziste";
            this.cmbPolaziste.Size = new System.Drawing.Size(234, 28);
            this.cmbPolaziste.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbOdrediste);
            this.groupBox3.Location = new System.Drawing.Point(349, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(250, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odredište";
            // 
            // cmbOdrediste
            // 
            this.cmbOdrediste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdrediste.FormattingEnabled = true;
            this.cmbOdrediste.Location = new System.Drawing.Point(8, 46);
            this.cmbOdrediste.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOdrediste.Name = "cmbOdrediste";
            this.cmbOdrediste.Size = new System.Drawing.Size(234, 28);
            this.cmbOdrediste.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(751, 176);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(226, 46);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // button1
            // 
            this.button1.Image = global::eBus.WinUI.Properties.Resources.icons8_synchronize_32;
            this.button1.Location = new System.Drawing.Point(283, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLinija";
            this.Text = "Linije";
            this.Load += new System.EventHandler(this.frmLinija_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPolaziste;
        private System.Windows.Forms.ComboBox cmbOdrediste;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odrediste;
        private System.Windows.Forms.DataGridViewButtonColumn Cijena;
    }
}