using eBus.Model;
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
    public partial class frmNovostiDetalji : Form
    {

        private APIService _korisnici = new APIService("Korisnici");
        private APIService _novosti = new APIService("Novosti");
        private APIService _notifikacije = new APIService("Notifikacije");
        private APIService _putnikNotifikacije = new APIService("PutnikNotifikacije");
        private APIService _putnici = new APIService("Putnik");
        private int? _id;
        public frmNovostiDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmNovostiDetalji_Load(object sender, EventArgs e)
        {
           
            if (_id.HasValue)
            {
                var novost = await _novosti.GetById<Model.Novosti>(_id.Value);

                txtNaslov.Text = novost.Naslov;
                txtSadrzaj.Text = novost.Sadrzaj;
                dtpDatumObjave.Value = novost.DatumObjave.Value;
           
            }
        }

      

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    var novost = new NovostiUpsertRequest();

                    novost.Naslov = txtNaslov.Text;
                    novost.Sadrzaj = txtSadrzaj.Text;
                    novost.DatumObjave = dtpDatumObjave.Value;

                    var search = new KorisniciSearchRequest()
                    {
                        KorisnickoIme = APIService.KorisnickoIme
                    };

                    var listaKorisnika = await _korisnici.Get<List<Model.Korisnici>>(search);
                    Model.Korisnici korisnik = null;
                    foreach (var item in listaKorisnika)
                    {
                        if(item.KorisnickoIme == APIService.KorisnickoIme)
                        {
                            korisnik = item;
                            break;
                        }
                    }

                    novost.KorisnikId = korisnik.Id;

                    if (!_id.HasValue)
                    {
                      var n=  await _novosti.Insert<Model.Novosti>(novost);

                        MessageBox.Show("Novost je dodana");

                        if(n != null)
                        {
                            var notif = new NotifikacijaUpsertRequest();

                            notif.DatumSlanja = DateTime.Now;
                            notif.Naslov = novost.Naslov;
                            notif.NovostId = n.Id;
                            notif.Procitano = false;
                           var notifikaicija = await _notifikacije.Insert<Model.Notifikacije>(notif);

                            var listaPutnika = await _putnici.Get<List<Model.Putnik>>(null);

                            foreach (var item in listaPutnika)
                            {
                                await _putnikNotifikacije.Insert<PutnikNotifikacije>(new PutnikNotifikacijeUpsertRequest()
                                {
                                    NotifikacijaId = notifikaicija.Id,
                                    PutnikId = item.Id,
                                    Pregledana = false
                                });
                            }
                        }
                      
                    }
                    else
                    {
                        await _novosti.Update<Model.Novosti>(_id.Value, novost);
                    }
                   
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Novosti detalji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaslov.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNaslov, Properties.Resources.Upozorenje);
            }
            else
            {
                errorProvider1.SetError(txtNaslov, null);

            }
        }

        private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSadrzaj.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSadrzaj, Properties.Resources.Upozorenje);
            }
            else
            {
                errorProvider1.SetError(txtSadrzaj, null);

            }
        }

       
        
    }
}
