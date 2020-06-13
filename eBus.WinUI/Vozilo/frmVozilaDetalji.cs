﻿using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Vozilo
{
    public partial class frmVozilaDetalji : Form
    {
        private APIService _vozilo = new APIService("Vozilo");
        private APIService _kompanije = new APIService("Kompanija");

        private int? _id;
        public frmVozilaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    var vozilo = new VoziloUpsertRequest();

                    vozilo.Proizvodjac = txtProizvodjac.Text;
                    vozilo.Model = txtModel.Text;
                    vozilo.Registracija = txtRegistracijskeOznake.Text;
                    vozilo.KompanijaId = int.Parse(cmbKompanije.SelectedValue.ToString());
                    vozilo.BrojSjedista = int.Parse(txtBrojSjedista.Text);

                    if (!_id.HasValue)
                    {
                        await _vozilo.Insert<Model.Vozilo>(vozilo);
                        MessageBox.Show("Vozilo je uspješno dodano");
                    }
                    else
                    {
                        await _vozilo.Update<Model.Vozilo>(_id.Value, vozilo);
                        MessageBox.Show("Vozilo je uspješno izmjenjen");

                    }

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Vozilo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private async Task LoadKompanije()
        {
            try
            {
                var lista = await _kompanije.Get<List<Model.Kompanija>>(null);

                lista.Insert(0, new Model.Kompanija());
                cmbKompanije.DataSource = lista;
                cmbKompanije.DisplayMember = "Naziv";
                cmbKompanije.ValueMember = "Id";
                cmbKompanije.SelectedText = "--Odaberi kompaniju--";
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private async void frmVozilaDetalji_Load(object sender, EventArgs e)
        {
            await LoadKompanije();

            if (_id.HasValue)
            {
                var vozilo = await _vozilo.GetById<Model.Vozilo>(_id.Value);

                txtBrojSjedista.Text = vozilo.BrojSjedista.ToString();
                txtModel.Text = vozilo.Model;
                txtProizvodjac.Text = vozilo.Proizvodjac;
                txtRegistracijskeOznake.Text = vozilo.Registracija;
                cmbKompanije.SelectedValue = vozilo.KompanijaId;
            }
        }

        private void txtProizvodjac_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtProizvodjac.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtProizvodjac, Properties.Resources.Upozorenje);
            }
            else
            {
                errorProvider.SetError(txtProizvodjac, null);
            }
        }

        private void txtModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtModel, Properties.Resources.Upozorenje);
            }
            else
            {
                errorProvider.SetError(txtModel, null);
            }
        }

        private void txtRegistracijskeOznake_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistracijskeOznake.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtRegistracijskeOznake, Properties.Resources.Upozorenje);
            }
            else
            {
                errorProvider.SetError(txtRegistracijskeOznake, null);
            }
        }

        private void txtBrojSjedista_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojSjedista.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojSjedista, Properties.Resources.Upozorenje);
            }
            else if (!Regex.IsMatch(txtBrojSjedista.Text, @"[1-9]{2}"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojSjedista, Properties.Resources.NeispravanFormat);
            }
            else
            {
                errorProvider.SetError(txtBrojSjedista, null);
            }
        }
    }
}