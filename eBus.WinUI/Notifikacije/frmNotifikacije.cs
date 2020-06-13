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

namespace eBus.WinUI.Notifikacije
{
    public partial class frmNotifikacije : Form
    {
        private APIService _notifikacije = new APIService("Notifikacije");
        private APIService _novosti = new APIService("Novosti");
        public frmNotifikacije()
        {
            InitializeComponent();
            dgvNotifikacije.AutoGenerateColumns = false;
        }

        private async void frmNotifikacije_Load(object sender, EventArgs e)
        {

            try
            {
                var lista = await _notifikacije.Get<List<Model.Notifikacije>>(null);

               

                dgvNotifikacije.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Notifikacija", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private async void txtNaslov_TextChanged(object sender, EventArgs e)
        {
            var search = new NotifikacijeSearchRequest()
            {
                Naslov = txtNaslov.Text
            };

            var lista = await _notifikacije.Get<List<Model.Notifikacije>>(search);

            dgvNotifikacije.DataSource = lista;
        }
    }
}
