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

namespace eBus.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private APIService _korisnici = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                var search = new KorisniciSearchRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text
                };

                var lista = await _korisnici.Get<List<Model.Korisnici>>(search);

                dgvKorisnici.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var kor = dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString();

            if(int.TryParse(kor, out int id))
            {
               

                frmKorisniciDetalji frm = new frmKorisniciDetalji(id);
                frm.Show();
            }
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
