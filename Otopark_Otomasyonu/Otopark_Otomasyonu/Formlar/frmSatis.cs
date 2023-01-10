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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmSatis_Load(object sender, EventArgs e)
        {
            TumKayitlar();
        }
        private void TumKayitlar()
        {
            #region KayitGoster
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on x.MarkaID
                                      equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.ID.ToString() == txtIDAra.Text).ToList();
            dataGridView1.DataSource = liste;
            #endregion
        }

        private void txtIDAra_TextChanged(object sender, EventArgs e)
        {
            #region IDAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on x.MarkaID
                                      equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.ID.ToString() == txtIDAra.Text).ToList();
            dataGridView1.DataSource = liste;

            #endregion
        }

        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            #region MusteriIDAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on x.MarkaID
                                      equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.MusteriID.ToString() == txtMusteriIDAra.Text).ToList();
            dataGridView1.DataSource = liste;
            lblTutar.Text =" Toplam Tutar="+db.TBLSatis.Sum(x=>x.Tutar);
            lblKayit.Text = "Toplam" + db.TBLSatis.Count()+ " Kayıt Listelendi ";
            lblOrtalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblMax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);
            lblMin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            if (txtMusteriIDAra.Text == "")
            {

            }

            #endregion
        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            #region AdSoyadAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on x.MarkaID
                                      equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.AdiSoyadi.Contains(txtAdSoyadAra.Text)).ToList();
            dataGridView1.DataSource = liste;
            lblTutar.Text = " Toplam Tutar= " + db.TBLSatis.Sum(x => x.Tutar);
            lblKayit.Text = "Toplam: " + db.TBLSatis.Count() + "  Kayıt Listelendi ";
            lblOrtalama.Text = "Ortalama Tutar " + db.TBLSatis.Average(x => x.Tutar);
            lblMax.Text = "En Yüksek Tutar " + db.TBLSatis.Max(x => x.Tutar);
            lblMin.Text = "En Düşük Tutar " + db.TBLSatis.Min(x => x.Tutar);
            if (txtMusteriIDAra.Text == "")
            {

            }
            #endregion
        }

        private void txtPlakaAra_TextChanged(object sender, EventArgs e)
        {
            #region PlakaAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on x.MarkaID
                                      equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.Plaka.Contains(txtPlakaAra.Text)).ToList();
            dataGridView1.DataSource = liste;
            lblTutar.Text = " Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            lblKayit.Text = "Toplam" + db.TBLSatis.Count() + " Kayıt Listelendi ";
            lblOrtalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblMax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);
            lblMin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            if (txtMusteriIDAra.Text == "")
            {

            }
            #endregion

        }

        private void txtParkYeriAra_TextChanged(object sender, EventArgs e)
        {
            #region ParkYeriAra
            var liste = (from x in db.TBLSatis
                         join y in db.TBLMarka on x.MarkaID
                                      equals y.ID
                         join z in db.TBLSeri
             on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID
                         equals w.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.ParkYerleri.Contains(txtParkYeriAra.Text)).ToList();
            dataGridView1.DataSource = liste;
            lblTutar.Text = " Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            lblKayit.Text = "Toplam" + db.TBLSatis.Count() + " Kayıt Listelendi ";
            lblOrtalama.Text = "Ortalama Tutar" + db.TBLSatis.Average(x => x.Tutar);
            lblMax.Text = "En Yüksek Tutar" + db.TBLSatis.Max(x => x.Tutar);
            lblMin.Text = "En Düşük Tutar" + db.TBLSatis.Min(x => x.Tutar);
            if (txtMusteriIDAra.Text == "")
            {

            }
            #endregion
        }
    }
}
