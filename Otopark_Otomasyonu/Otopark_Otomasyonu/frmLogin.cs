using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otopark_Otomasyonu
{
    public partial class frmLogin : Form

    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=X\\SQLEXPRESS;Initial Catalog=Otopark;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from kullanici_bilgi where kullanici_adi='" + textBox1.Text +
            "'and sifre='"+ textBox2.Text + "'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                frmAnasayfa gecis = new frmAnasayfa();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            con.Close();
        }
    }
}
