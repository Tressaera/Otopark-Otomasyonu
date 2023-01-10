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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmMusteri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }
        void Temizle()
        {
         foreach(Control item in Controls)
            {
              if(item is TextBox)
                {
                    item.Text = "";
                    
                }
            }
            pictureBox1.ImageLocation = "";
            dateTimeTarih.Value = DateTime.Now;
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.TBLMusteri
                      where x.ID.ToString()==txtID.Text
                      select x;
            foreach (var item in ara)
            {
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                txtAdres.Text = item.Adres;
                txtEmail.Text = item.Email;
                pictureBox1.ImageLocation = item.Resim;
                dateTimeTarih.Value = item.Tarih;
            }
            if(txtID.Text=="")

            {
                Temizle();
            }
            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ekle = new Musteri();
            ekle.AdiSoyadi = txtAdiSoyadi.Text;
            ekle.Telefon = txtTelefon.Text;
            ekle.Adres = txtAdres.Text;
            ekle.Email = txtEmail.Text;
            ekle.Resim = pictureBox1.ImageLocation;
            ekle.Tarih = dateTimeTarih.Value;
            db.TBLMusteri.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.TBLMusteri.FirstOrDefault(x=>x.ID==id);
            db.TBLMusteri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TBLMusteri.FirstOrDefault(x=>x.ID==id);
            guncelle.AdiSoyadi = txtAdiSoyadi.Text;
            guncelle.Telefon = txtTelefon.Text;
            guncelle.Adres = txtAdres.Text;
            guncelle.Email = txtEmail.Text;
            guncelle.Resim = pictureBox1.ImageLocation;
            guncelle.Tarih = dateTimeTarih.Value;
            db.TBLMusteri.Add(guncelle);
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();




        }
    }
}
