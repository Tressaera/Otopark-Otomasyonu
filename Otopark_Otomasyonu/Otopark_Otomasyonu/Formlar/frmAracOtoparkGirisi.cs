using Otopark_Otomasyonu.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu.Formlar
{
    public partial class frmAracOtoparkGirisi : Form
    {
        public frmAracOtoparkGirisi()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmAracOtoparkGirisi_Load(object sender, EventArgs e)
        {
            var markagetir = db.TBLMarka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";

            ParkYerleriYenile();
        }
        private void ParkYerleriYenile()
        {
            var parkYerigetir = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = parkYerigetir;
            comboParkYeri.DisplayMember = "ParkYerleri";
            comboParkYeri.ValueMember = "ID";
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TBLSeri.Where(x=>x.MarkaID == (int)comboMarka.SelectedValue).ToList();
                comboSeri.DataSource = serigetir;
                comboSeri.DisplayMember = "Seri";
                comboSeri.ValueMember = "ID";
            }
            catch(Exception)
            {

            }
        }

        private void comboMarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
            comboSeri.DataSource = serigetir;
            comboSeri.DisplayMember = "Seri";
            comboSeri.ValueMember = "ID";
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            try
            {
            var MusteriGetir = db.TBLMusteri.Where(x => x.ID.ToString() == txtMusteriID.Text).ToList();
            foreach(var item in MusteriGetir)
            {
                txtAdSoyad.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
            }
            if(txtMusteriID.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            }
            catch(Exception)
            {

            }
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach(Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ekle = new AracParkBilgileri();
            ekle.MusteriID = int.Parse(txtMusteriID.Text);
            ekle.AdiSoyadi = txtAdSoyad.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.MarkaID = (int)comboMarka.SelectedValue;
            ekle.SeriID = (int)comboSeri.SelectedValue;
            ekle.Plaka = txtPlaka.Text;
            ekle.Yil = txtYil.Text;
            ekle.Renk = txtRenk.Text;
            ekle.ParkYeriID = (int)comboParkYeri.SelectedValue;
            ekle.Aciklama = txtAciklama.Text;
            ekle.GirisTarihi = DateTime.Now;
            db.TBLAracParkBilgileri.Add(ekle);
            db.SaveChanges();

            var parkyeridoldur = db.TBLAracParkYerleri.FirstOrDefault(x => x.ID == (int) comboParkYeri.SelectedValue);
            parkyeridoldur.Durumu= "DOLU";
            db.SaveChanges();
            MessageBox.Show("Araca yeni seri eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            ParkYerleriYenile();
        }
    }
}
