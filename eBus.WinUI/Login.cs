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

namespace eBus.WinUI
{
    public partial class Login : Form
    {

        private readonly APIService _korisniciService = new APIService("Korisnici");
        private readonly APIService _putnikService = new APIService("Putnik");

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.KorisnickoIme = txtKorisnickoIme.Text;
                APIService.Lozinka = txtLozinka.Text;

                var search = new PutnikSearchRequest()
                {
                    KorisnickoIme = APIService.KorisnickoIme
                };

                var listaPutnika = await _putnikService.Get<List<Model.Putnik>>(search);

                bool prolaz = true;

                foreach (var item in listaPutnika)
                {
                    if (item.KorisnickoIme == APIService.KorisnickoIme)
                    {
                        prolaz = false;
                        break;
                    }
                }

                if (prolaz)
                {
                    await _korisniciService.Get<dynamic>(null);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nema te pravo pristupa");
                }
                

            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message,"Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
