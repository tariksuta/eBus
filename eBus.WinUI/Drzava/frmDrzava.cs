using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Drzava
{
    public partial class frmDrzava : Form
    {

        private APIService _drzave = new APIService("Drzava");
        public frmDrzava()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
        }

        private async void frmDrzava_Load(object sender, EventArgs e)
        {
            try
            {
                var lista = await _drzave.Get<List<Model.Drzava>>(null);

                dgvDrzave.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Drzava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            var search = new DrzavaSearchRequest()
            {
                Naziv = txtNaziv.Text
            };

            var lista = await _drzave.Get<List<Model.Drzava>>(search);

            dgvDrzave.DataSource = lista;
        }
    }
}
