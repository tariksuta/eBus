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

namespace eBus.WinUI.Sjedista
{
    public partial class frmSjedista : Form
    {

        private APIService _sjedista = new APIService("Sjediste");
        private APIService _vozila = new APIService("Vozilo");
        public frmSjedista()
        {
            InitializeComponent();
            dgvSjedista.AutoGenerateColumns = false;
        }

        private async void frmSjedista_Load(object sender, EventArgs e)
        {
            try
            {
                await  LoadVozila();
                var lista = await _sjedista.Get<List<Model.Sjediste>>(null);

                

                dgvSjedista.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message, "Sjediste", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private async Task LoadVozila()
        {
            var lista = await _vozila.Get<List<Model.Vozilo>>(null);

            lista.Insert(0, new Model.Vozilo());

            cmbVozila.DataSource = lista;
            cmbVozila.DisplayMember = "Model";
            cmbVozila.ValueMember = "Id";
            cmbVozila.SelectedText = "---Odaberi vozilo---";
            
            
        }

        private async void cmbVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
               if(int.TryParse( cmbVozila.SelectedValue.ToString() ,out int id))
                {
                    var search = new SjedisteSearchRequest()
                    {
                        VoziloId = id
                    };

                    var lista = await _sjedista.Get<List<Model.Sjediste>>(search);

                    
                    //dgvSjedista.DataSource = null;
                    dgvSjedista.DataSource = lista;
                }
           


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sjediste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSjedista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var obj = dgvSjedista.SelectedRows[0].Cells[0].Value;

            if(int.TryParse(obj.ToString() , out int id))
            {
                frmSjedistaDetalji frm = new frmSjedistaDetalji(id);
                frm.Show();
            }
        }
    }
}
