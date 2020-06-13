using eBus.Model.Requests;
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

namespace eBus.WinUI.Drzava
{
    public partial class frmDrzavaDetalji : Form
    {

        private APIService _drzava = new APIService("Drzava");
        public frmDrzavaDetalji()
        {
            InitializeComponent();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var drzava = new DrzavaUpsertRequest();

                drzava.Naziv = txtNaziv.Text;

                await _drzava.Insert<Model.Drzava>(drzava);

                MessageBox.Show("Drzava je uspješno dodana");

                Close();
            }
           
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Properties.Resources.Upozorenje);
            }else if(!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z -]+$")) {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }
    }
}
