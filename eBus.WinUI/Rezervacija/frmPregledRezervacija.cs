using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Rezervacija
{
    public partial class frmPregledRezervacija : Form
    {
        private APIService _rezervacija = new APIService("Rezervacija");
        
        private int _id;
        public frmPregledRezervacija(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmPregledRezervacija_Load(object sender, EventArgs e)
        {
            var rez = await _rezervacija.GetById<Model.Rezervacija>(_id);

           

            txtDatumIsteka.Text = rez.DatumIsteka.ToString("dd.MM.yyyy");
            txtDatumKreiranja.Text = rez.DatumKreiranja.ToString("dd.MM.yyyy");
            

            pbQRcode.Image = Helper.ImageHelper.FromByteToImage(rez.Qrcode);
        }
    }
}
