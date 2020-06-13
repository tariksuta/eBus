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

namespace eBus.WinUI.Linija
{
    public partial class frmCijena : Form
    {

        private APIService _cijene = new APIService("Cijena");
        private APIService _linije = new APIService("Linija");

        private int? _id;
        public frmCijena(int? id = null)
        {
            InitializeComponent();
            _id = id;

            dgvCijena.AutoGenerateColumns = false;
        }

        private async void frmCijena_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var linija = await _linije.GetById<Model.Linija>(_id.Value);
                txtNazivLinije.Text = linija.Naziv;
               
            }

            var search = new CijenaSearchRequest()
            {
                LinijaID = _id.Value
            };
            var lista = await _cijene.Get<List<Model.Cijena>>(search);
            dgvCijena.DataSource = lista;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                frmCijenaDetalji frm = new frmCijenaDetalji(_id.Value);
                frm.Show();
            }
            
        }
    }
}
