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

namespace eBus.WinUI.Novosti
{
    public partial class frmNovosti : Form
    {
        private APIService _novosti = new APIService("Novosti");
        private APIService _korisnici = new APIService("Korisnici");
        public frmNovosti()
        {
            InitializeComponent();
            dgvNovosti.AutoGenerateColumns = false;
        }

        private  void frmNovosti_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNovosti(null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void LoadNovosti( NovostiSearchRequest search = null)
        {
            var lista = await _novosti.Get<List<Model.Novosti>>(search);

           

            dgvNovosti.DataSource = lista;
        }

        private  void txtNaslov_TextChanged(object sender, EventArgs e)
        {
            var search = new NovostiSearchRequest()
            {
                Naslov = txtNaslov.Text
            };
            LoadNovosti(search);
        }

        private  void btnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new NovostiSearchRequest()
            {
                Naslov = txtNaslov.Text,
                DatumObjave = dtpDatumObjave.Value
            };
            LoadNovosti(search);
        }

        private void dgvNovosti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var el = dgvNovosti.SelectedRows[0].Cells[0].Value.ToString();
            if(int.TryParse(el, out int id))
            {
                frmNovostiDetalji frm = new frmNovostiDetalji(id);
                frm.Show();
            }
        }
    }
}
