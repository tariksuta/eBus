using eBus.WinUI.Angazuje;
using eBus.WinUI.Drzava;
using eBus.WinUI.Grad;
using eBus.WinUI.Izvjestaji;
using eBus.WinUI.Karta;
using eBus.WinUI.Kompanija;
using eBus.WinUI.Korisnici;
using eBus.WinUI.Linija;
using eBus.WinUI.Notifikacije;
using eBus.WinUI.Novosti;
using eBus.WinUI.Ocjena;
using eBus.WinUI.Putnik;
using eBus.WinUI.Rezervacija;
using eBus.WinUI.Sjedista;
using eBus.WinUI.Vozilo;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciDetalji frm = new frmKorisniciDetalji();
            frm.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.Show();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKompanija frm = new frmKompanija();
            frm.Show();
        }

        private void pregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVozila frm = new frmVozila();
            frm.Show();
        }

        private void pregledToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmDrzava frm = new frmDrzava();
            frm.Show();
        }

        private void pregledToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGrad frm = new frmGrad();
            frm.Show();
        }

        private void pregledToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmLinija frm = new frmLinija();
            frm.Show();
        }

        private void pCijenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCijena frm = new frmCijena();
            frm.Show();
        }

        private void pregledToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmSjedista frm = new frmSjedista();
            frm.Show();
        }

        private void pregledToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmNovosti frm = new frmNovosti();
            frm.Show();
        }

        private void pregledToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmNotifikacije frm = new frmNotifikacije();
            frm.Show();
        }

        private void pregledToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmPutnik frm = new frmPutnik();
            frm.Show();
        }

        private void pregledToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmOcjena frm = new frmOcjena();
            frm.Show();
        }

        private void pregledToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmKarta frm = new frmKarta();
            frm.Show();
        }

        private void pregledToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmAngazuje frm = new frmAngazuje();

            frm.Show();
        }

        private void pregledToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmRezervacija frm = new frmRezervacija();
            frm.Show();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDrzavaDetalji frm = new frmDrzavaDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGradDetalji frm = new frmGradDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmVozilaDetalji frm = new frmVozilaDetalji();
            frm.Show();
           
        }

        private void dodajToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmKartaDetalji frm = new frmKartaDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmAngazujeDetalji frm = new frmAngazujeDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmSjedistaDetalji frm = new frmSjedistaDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmKompanijaDetalji frm = new frmKompanijaDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmNovostiDetalji frm = new frmNovostiDetalji();
            frm.Show();
        }

        private void dodajLinijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinijaDetalji frm = new frmLinijaDetalji();
            frm.Show();
        }

        private void dodajToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmPutnikDetalji frm = new frmPutnikDetalji();
            frm.Show();
        }

      

        private void izvjestaOKartamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmKarteIzvjestaj frm = new frmKarteIzvjestaj();
            frmIzvjestaj frm = new frmIzvjestaj();
            frm.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KorisnickiProfil frm = new KorisnickiProfil();
            frm.Show();
        }

        private void cijenovnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCijenaDetalji frm = new frmCijenaDetalji();
            frm.Show();
        }

        private void kartePoKompanijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmIzvjestajKarte frm = new frmIzvjestajKarte();

            frmIzvjestajKompanije frm = new frmIzvjestajKompanije();
            frm.Show();
        }

        private void kartePoLinijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvještajRelacije frm = new frmIzvještajRelacije();
            frm.Show();
        }
    }
}
