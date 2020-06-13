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

namespace eBus.WinUI.Grad
{
    public partial class frmGrad : Form
    {
        private APIService _gradovi = new APIService("Grad");
        private APIService _drzave = new APIService("Drzava");
        public frmGrad()
        {
            InitializeComponent();
            dgvGradovi.AutoGenerateColumns = false;
        }

        private async void frmGrad_Load(object sender, EventArgs e)
        {

            try
            {
                var lista = await _gradovi.Get<List<Model.Grad>>(null);

              

                dgvGradovi.DataSource = lista;

                var lista2 = await _drzave.Get<List<Model.Drzava>>(null);

                lista2.Insert(0, new Model.Drzava());
                cmbDrzava.DataSource = lista2;
                cmbDrzava.ValueMember = "Id";
                cmbDrzava.DisplayMember = "Naziv";
                cmbDrzava.SelectedText = "--Odaberi državu--";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Grad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new GradSearchRequest()
            {
                Drzavaid = int.Parse(cmbDrzava.SelectedValue.ToString())
            };

            var lista = await _gradovi.Get<List<Model.Grad>>(search);

          

            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = lista;
        }

        private void dgvGradovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var el = dgvGradovi.SelectedRows[0].Cells[0].Value.ToString();
            if(int.TryParse(el, out int id))
            {
                frmGradDetalji frm = new frmGradDetalji(id);
                frm.Show();
            }
        }
    }
}
