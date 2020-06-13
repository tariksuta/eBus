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

namespace eBus.WinUI.Karta
{
    public partial class frmKarta : Form
    {
        private APIService _karte = new APIService("Karta");
        
        public frmKarta()
        {
            InitializeComponent();
            dgvKarte.AutoGenerateColumns = false;
        }

        private  void frmKarta_Load(object sender, EventArgs e)
        {

            try
            {
               
                //var lista = await _karte.Get<List<Model.Karta>>(null);

                //dgvKarte.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Karta", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

       

       

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {

            try
            {
                var search = new KartaSearchRequest()
                {
                    PoAngzuje = false,
                    PoVozilu = false,
                    DatumIzdavanja = dtpDatumIzdavanja.Value
                };

                var lista = await _karte.Get<List<Model.Karta>>(search);

               

                dgvKarte.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Karta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvKarte_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                var el = dgvKarte.SelectedRows[0].Cells[0].Value.ToString();

                if (int.TryParse(el, out int id))
                {
                    frmKartaDetalji frm = new frmKartaDetalji(id);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Karta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
