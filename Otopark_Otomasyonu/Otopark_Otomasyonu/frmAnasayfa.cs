using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Formlar.frmMarka marka = new Formlar.frmMarka();
            marka.Show();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            Formlar.frmMarka marka = new Formlar.frmMarka();
            marka.Show();
        }
        private void seriTool_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }
        private void btnSeri_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteri frm = new Formlar.frmMusteri();
            frm.Show();
        }
         private void btnOtoparkYer_Click(object sender, EventArgs e)
         {
            Formlar.frmOtoparkYerleri frm = new Formlar.frmOtoparkYerleri();
            frm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void btnAracOtoparkGirisi_Click(object sender, EventArgs e)
        {
            Formlar.frmAracOtoparkGirisi frm = new Formlar.frmAracOtoparkGirisi();
            frm.Show();
        }

        private void btnOtoparkCik_Click(object sender, EventArgs e)
        {
            Formlar.frmAracOtoparkCikisi frm = new Formlar.frmAracOtoparkCikisi();
            frm.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Formlar.frmSatis frm = new Formlar.frmSatis();
            frm.Show();
        }
    }
}
