using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Izvjestaji
{
    public partial class frmIzvjestaj : Form
    {
        private readonly APIService _putniciService = new APIService("Putnik");
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private async void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            await LoadPutnike();
        }

        private async Task LoadPutnike()
        {
            var lista = await _putniciService.Get<List<Model.Putnik>>(null);

            lista.Insert(0, new Model.Putnik());
            cmbPutnici.DataSource = lista;
            cmbPutnici.DisplayMember = "Podaci";
            cmbPutnici.ValueMember = "Id";
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var tap = cmbPutnici.SelectedValue.ToString();

            if(int.TryParse(tap,out int id))
            {

                frmKarteIzvjestaj frm = new frmKarteIzvjestaj(id);
                frm.Show();
            }
        }
    }
}
