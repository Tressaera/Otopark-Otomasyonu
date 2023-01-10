using Otopark_Otomasyonu.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu.Formlar
{
    public partial class frmAracOtoparkCikisi : Form
    {
        public frmAracOtoparkCikisi()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmAracOtoparkCikisi_Load(object sender, EventArgs e)
        {
            #region FormLoad
            //comboSaatUcreti.SelectedIndex = 0;
            Yenile();
            var markagetir = db.TBLMarka.ToList();
            comboMarka.DataSource = markagetir;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";
            #endregion
        }
        private void Yenile()
        {
            comboPlakaAra.Text = "";
            comboPlakaAra.Items.Clear();
            var plakagetir = db.TBLAracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                comboPlakaAra.Items.Add(item.Plaka);
            }

            var bosparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            comboParkYeri.DataSource = bosparkyerleri;
            comboParkYeri.DisplayMember = "Park Yerleri";
            comboParkYeri.ValueMember = "ID";
            var doluparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();
            comboParkYeriAra.DataSource = doluparkyerleri;
            comboParkYeriAra.DisplayMember = "Park Yerleri";
            comboParkYeriAra.ValueMember = "ID";
            comboParkYeriAra.Text = "";
            comboParkYeri.Text = "";
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)comboMarka.SelectedValue).ToList();
                comboSeri.DataSource = serigetir;
                comboSeri.DisplayMember = "seri";
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
            comboSeri.DisplayMember = "seri";
            comboSeri.ValueMember = "ID";
        }

        //Arama Bölümleri
        void UcretHesapla()
        {
            try
            {
                lblCikisTarihi.Text = DateTime.Now.ToString(); 
                TimeSpan fark;
                fark = DateTime.Parse(lblCikisTarihi.Text)- DateTime.Parse(lblGirisTarihi.Text);
                decimal saatUcreti = 0,  sure = 0, tutar = 0;
                lblSure.Text = fark.TotalHours.ToString("0.00");
                saatUcreti = decimal.Parse(comboSaatUcreti.Text);
                sure = decimal.Parse(lblSure.Text);
                tutar = sure * saatUcreti;
                lblUcret.Text = tutar.ToString("0.00");
            }
            catch(Exception)
            {

            }
        }
        private void txtIDAra_TextChanged(object sender, EventArgs e)
        {
            if(txtIDAra.Text=="")
            {
             foreach(Control item in panelBilgiler.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            #region IDAra
            var IDAra = (from x in db.TBLAracParkBilgileri
                         join y in db.TBLMarka on x.MarkaID
                         equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.GirisTarihi,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri
                         }).Where(ara => ara.ID.ToString()==txtIDAra.Text).ToList();
            foreach(var item in IDAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text =item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblGirisTarihi.Text =item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            if (txtMusteriIDAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            #region MusteriID_Ara
            var MusteriIDAra = (from x in db.TBLAracParkBilgileri
            join y in db.TBLMarka on x.MarkaID
                         equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.GirisTarihi,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri
                         }).Where(ara => ara.MusteriID.ToString() == txtMusteriIDAra.Text).ToList();
            foreach (var item in MusteriIDAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAdSoyadAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            #region AdSoyad_Ara
            var AdSoyadAra = (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on x.MarkaID
                                             equals y.ID
                                join z in db.TBLSeri
                    on x.SeriID equals z.ID
                                join w in db.TBLAracParkYerleri on x.ParkYeriID
                                equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.seri,
                                    w.ParkYerleri
                                }).Where(ara => ara.AdiSoyadi.ToString() == txtAdSoyadAra.Text).ToList();
            foreach (var item in AdSoyadAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void comboPlakaAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Plaka_Ara
            var PlakaAra = (from x in db.TBLAracParkBilgileri
                              join y in db.TBLMarka on x.MarkaID
                                           equals y.ID
                              join z in db.TBLSeri
                  on x.SeriID equals z.ID
                              join w in db.TBLAracParkYerleri on x.ParkYeriID
                              equals w.ID
                              select new
                              {
                                  x.ID,
                                  x.MusteriID,
                                  x.AdiSoyadi,
                                  x.Telefon,
                                  x.Plaka,
                                  x.Renk,
                                  x.Aciklama,
                                  x.GirisTarihi,
                                  y.MarkaAdi,
                                  z.seri,
                                  w.ParkYerleri
                              }).Where(ara => ara.Plaka.ToString() == comboPlakaAra.Text).ToList();
            foreach (var item in PlakaAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void comboParkYeriAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ParkYeriAra
            var ParkYeriAra = (from x in db.TBLAracParkBilgileri
                            join y in db.TBLMarka on x.MarkaID
                                         equals y.ID
                            join z in db.TBLSeri
                on x.SeriID equals z.ID
                            join w in db.TBLAracParkYerleri on x.ParkYeriID
                            equals w.ID
                            select new
                            {
                                x.ID,
                                x.MusteriID,
                                x.AdiSoyadi,
                                x.Telefon,
                                x.Plaka,
                                x.Renk,
                                x.Aciklama,
                                x.GirisTarihi,
                                y.MarkaAdi,
                                z.seri,
                                w.ParkYerleri
                            }).Where(ara => ara.ParkYerleri.ToString() == comboParkYeriAra.Text).ToList();
            foreach (var item in ParkYeriAra)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                comboMarka.Text = item.MarkaAdi;
                comboSeri.Text = item.seri;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                comboParkYeri.Text = item.ParkYerleri;
                txtAciklama.Text = item.Aciklama;
                lblGirisTarihi.Text = item.GirisTarihi.ToString();
                UcretHesapla();
            }
            #endregion
        }

        private void comboPlakaAra_TextChanged(object sender, EventArgs e)
        {
            if (comboPlakaAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
        }

        private void comboParkYeriAra_TextChanged(object sender, EventArgs e)
        {
            if (comboParkYeriAra.Text == "")
            {
                foreach (Control item in panelBilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
        }

        private void btnParkYeriGuncelle_Click(object sender, EventArgs e)
        {
            var DoluParkYeriDegistir = db.TBLAracParkYerleri.FirstOrDefault(x=>x.ParkYerleri==comboParkYeriAra.Text);
            DoluParkYeriDegistir.Durumu = "BOŞ";
            db.SaveChanges();
            var BosParkYeriDegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeri.Text);
            BosParkYeriDegistir.Durumu = "DOLU";
            db.SaveChanges();
            var aracparkyeridegistir = db.TBLAracParkBilgileri.FirstOrDefault(x=>x.Plaka == txtPlaka.Text);
            aracparkyeridegistir.ParkYeriID = (int)comboParkYeri.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Araca yeni seri güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Yenile();
            btnTemizle.PerformClick();
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach(Control item in panelArama.Controls)
            {
             if(item is TextBox)
             {
                    item.Text = "";
             }
            if (item is ComboBox)
            {
                    item.Text = "";
            }
            }

            foreach (Control item in panelBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    if(item!=comboSaatUcreti)
                    {
                     item.Text = "";
                    }
                    
                }
            }
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region sil
            KayitSil();
            #endregion
            MessageBox.Show("Araca yeni seri silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboParkYeriAra.Items.Clear();
            Yenile();
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
            btnTemizle.PerformClick();
        }
        private void KayitSil()
        {
            var sil = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka == txtPlaka.Text);
            db.TBLAracParkBilgileri.Remove(sil);
            db.SaveChanges();

            var aracparkyerleribosalt = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == comboParkYeri.Text);
            aracparkyerleribosalt.Durumu = "BOŞ";
            db.SaveChanges();
        }

        private void btnAracCikisi_Click(object sender, EventArgs e)
        {
            #region araccikisi
            if (comboParkYeriAra.Text!="")
            {
                var ekle = new Satis();
                ekle.SatisID = int.Parse(txtID.Text);
                ekle.MusteriID = int.Parse(txtMusteriID.Text);
                ekle.AdiSoyadi = txtAdiSoyadi.Text;
                ekle.Telefon = txtTelefon.Text;
                ekle.MarkaID = (int)comboMarka.SelectedValue;
                ekle.SeriID = (int)comboSeri.SelectedValue;
                ekle.Plaka = txtPlaka.Text;
                ekle.Yil = "Belirtilmedi";
                ekle.Renk = txtPlaka.Text;
                ekle.ParkYeriID = (int)comboParkYeriAra.SelectedValue;
                ekle.saatUcreti = decimal.Parse(comboSaatUcreti.Text);
                ekle.Sure = decimal.Parse(lblSure.Text);
                ekle.Tutar = decimal.Parse(lblUcret.Text);
                ekle.Aciklama = txtAciklama.Text;
                ekle.GirisTarihi = DateTime.Parse(lblGirisTarihi.Text);
                ekle.CikisTarihi = DateTime.Parse(lblCikisTarihi.Text);
                db.TBLSatis.Add(ekle);
                db.SaveChanges();
                MessageBox.Show("Araç otopark çıkışı yapıldı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboParkYeriAra.Items.Clear();
                Yenile();
                KayitSil();  
                btnTemizle.PerformClick();
                lblSure.Text = "0.00";
                lblUcret.Text = "0.00";
                lblGirisTarihi.Text = DateTime.Now.ToString();
                lblCikisTarihi.Text = DateTime.Now.ToString();
            }
          
            else
            {
             MessageBox.Show("Dolu park yerinin seçilmesi gerekir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           #endregion
        }

        private void comboSaatUcreti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.TBLAracParkBilgileri.FirstOrDefault(x => x.ID.ToString() == txtID.Text);
            guncelle.MarkaID = (int)comboMarka.SelectedValue;
            guncelle.SeriID = (int)comboSeri.SelectedValue;
            guncelle.Plaka = txtPlaka.Text;
            guncelle.Renk = txtRenk.Text;
            guncelle.Aciklama = txtAciklama.Text;
            MessageBox.Show("Araç bilgileri güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboParkYeriAra.Items.Clear();
            Yenile();
            btnTemizle.PerformClick();
            lblSure.Text = "0.00";
            lblUcret.Text = "0.00";
            lblGirisTarihi.Text = DateTime.Now.ToString();
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }
    }
    }

