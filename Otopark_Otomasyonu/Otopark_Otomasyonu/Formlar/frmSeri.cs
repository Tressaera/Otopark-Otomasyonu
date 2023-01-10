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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }
        OtoparkDbContext db = new OtoparkDbContext();
        private void frmSeri_Load(object sender, EventArgs e)
        {
            Listele();
            var comboliste = db.TBLSeri.ToList();
            comboMarka.DataSource = comboliste;
            comboMarka.DisplayMember = "MarkaAdi";
            comboMarka.ValueMember = "ID";
        }
            private void Listele()
            {
            listView1.Items.Clear();
            var liste = from x in db.TBLSeri
                        join y in db.TBLMarka
                        on x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkaAdi,
                            x.seri
                        };
            foreach(var item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdi);
                viewItem.SubItems.Add(item.seri);
                listView1.Items.Add(viewItem);
            }
           
        }
        void Temizle()
        {
            txtID.Text = "";
            txtSeri.Text = "";
            comboMarka.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int markaid = (int)comboMarka.SelectedValue;
            var ekle = new Seri();
            ekle.MarkaID = markaid;
            ekle.seri = txtSeri.Text;
            db.TBLSeri.Add(ekle);
            db.SaveChanges(); 
            MessageBox.Show("Araca yeni seri eklendi","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenID = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.TBLSeri.FirstOrDefault(x => x.ID == secilenID);
            db.TBLSeri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç Serisi Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var guncelle = db.TBLSeri.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaID = (int)comboMarka.SelectedValue;
            guncelle.seri = txtSeri.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Markası Güncellendi", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void frmSeri_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                txtID.Text = secilen.SubItems[0].Text;
                comboMarka.Text = secilen.SubItems[1].Text;
                txtSeri.Text = secilen.SubItems[2].Text;
            }
        }
    }
}
