﻿namespace eBus.WinUI.Sjedista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSmanji = new System.Windows.Forms.Button();
            this.btn_Izadji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(117, 43);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSmanji);
            this.panel1.Controls.Add(this.btn_Izadji);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 37);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eBus.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSmanji
            // 
            this.btnSmanji.BackColor = System.Drawing.Color.Firebrick;
            this.btnSmanji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmanji.ForeColor = System.Drawing.Color.White;
            this.btnSmanji.Location = new System.Drawing.Point(537, 2);
            this.btnSmanji.Name = "btnSmanji";
            this.btnSmanji.Size = new System.Drawing.Size(33, 31);
            this.btnSmanji.TabIndex = 6;
            this.btnSmanji.Text = "_";
            this.btnSmanji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSmanji.UseVisualStyleBackColor = false;
            this.btnSmanji.Click += new System.EventHandler(this.btnSmanji_Click);
            // 
            // btn_Izadji
            // 
            this.btn_Izadji.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Izadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Izadji.ForeColor = System.Drawing.Color.White;
            this.btn_Izadji.Location = new System.Drawing.Point(576, 2);
            this.btn_Izadji.Name = "btn_Izadji";
            this.btn_Izadji.Size = new System.Drawing.Size(34, 32);
            this.btn_Izadji.TabIndex = 6;
            this.btn_Izadji.Text = "X";
            this.btn_Izadji.UseVisualStyleBackColor = false;
            this.btn_Izadji.Click += new System.EventHandler(this.btn_Izadji_Click);
            // 
            // frmSjedista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSjedista";
            this.Text = "frmSjedista";
            this.Load += new System.EventHandler(this.frmSjedista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSmanji;
        private System.Windows.Forms.Button btn_Izadji;
    }
}