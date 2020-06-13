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

namespace eBus.WinUI.Vozilo
{
    public partial class frmVozila : Form
    {
        private APIService _vozila = new APIService("Vozilo");
        private APIService _kompanije = new APIService("Kompanija");
        public frmVozila()
        {
            InitializeComponent();
            dgvVozila.AutoGenerateColumns = false;
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {

            try
            {
                var search = new VoziloSearchRequest()
                {
                    KompanijaId = int.Parse(cmbKompanije.SelectedValue.ToString())
                };

                var lista = await _vozila.Get<List<Model.Vozilo>>(search);

               
                dgvVozila.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Vozilo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private async void frmVozila_Load(object sender, EventArgs e)
        {
            var lista = await _kompanije.Get<List<Model.Kompanija>>(null);
            lista.Insert(0, new Model.Kompanija());
            cmbKompanije.DataSource = lista;
            cmbKompanije.ValueMember = "Id";
            cmbKompanije.DisplayMember = "Naziv";
        }

        private void dgvVozila_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var el = dgvVozila.SelectedRows[0].Cells[0].Value.ToString();

            if(int.TryParse(el, out int id))
            {
                frmVozilaDetalji frm = new frmVozilaDetalji(id);

                frm.Show();
            }
        }
    }
}
