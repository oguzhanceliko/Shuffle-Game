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

namespace Shuffle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9LA2R8V;Initial Catalog=Shuffledb;Integrated Security=True"); // Veritabanı kaynağı.

        private void Cikis_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Oyna_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kullaniciveitabani where kullanici=@kullaniciadi and sifre=@sifresi", baglanti); // Veritabanından verileri çeker ve belirtilen şarta uygunsa çalışır.
            komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text); // Parametreleri girdiğimiz textbox'dan alır.
            komut.Parameters.AddWithValue("@sifresi", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader(); // Okuma işlemini gerçekleştirir.
            if (dr.Read())
            {
                Form1 fr = new Form1(); // Doğru şekilde okuma işlemi yapıldıysa form1'i açar ve gizler.
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            baglanti.Close();
         
        }

        private void Kayıtol_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Kullaniciveitabani(kullanici,sifre) values ('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti); // Veritabanına textbox'dan girilen değeri ekler.
            komut.ExecuteNonQuery(); // Komutu çalıştırır.
            baglanti.Close();
            MessageBox.Show("Başarıyla Kayıt Olundu");
        }

        private void Kullaniciadi_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Sifre_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
