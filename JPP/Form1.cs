using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle
{
    public partial class Form1 : Form
    {
        int x;
        Point Nokta;
        Image BoyutDegistir;

        public Form1()
        {
            InitializeComponent();
            BoyutDegistir = pictureBox1.Image; // Tek kaynaktan resim almak yerine kullanıcının istediği resim üzerinde oynamasına olanak sağlar.
            pictureBox1.BackgroundImage = BoyutDegistir;
            Nokta.X = 330;
            Nokta.Y = 330;
            ButonaResimEkle(ParcalaraAyirma(ResmiBoyutlandir(BoyutDegistir), 110, 110));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buttons_Click(object sender, EventArgs e)
        {

            ButonuIlerlet((Button)sender);
            x++; // Her butona tıklandığında hamle sayısını 1 arttırır.
            label2.Text = x.ToString();

        }

        private void ButonuIlerlet(Button button) // Noktamızdan tıklanan butonun x ve y koordinatini alıp çıkarır ve yer değiştirir.
        {
            int x = Nokta.X - button.Location.X;
            int px = x < 0 ? -x : x;

            int y = Nokta.Y - button.Location.Y;
            int py = y < 0 ? -y : y;

            // Butonların sağa ve sola hareket etmesini sağlar.
            if (button.Location.Y.Equals(Nokta.Y) && px.Equals(button.Size.Width))
            {
                button.Location = new Point(button.Location.X + x, button.Location.Y);
                Nokta.X -= x;
            }

            // Butonların yukarı ve aşağı hareket etmesini sağlar.
            if (button.Location.X.Equals(Nokta.X) && py.Equals(button.Size.Width))
            {
                button.Location = new Point(button.Location.X, button.Location.Y + y);
                Nokta.Y -= y;
            }
        }

        public void ButonaResimEkle(ArrayList resim_parcasi) // Yeni bir dizi oluşturur ve Shuffle fonksiyonunu çağırarak resmin her parçasını karışık bir şekilde ekler.
        {
            int x = 0;
            int[] c = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }; 

            Shuffle(c);

            foreach (Button b in panel1.Controls)
            {
                if (x < c.Length)
                {
                    b.Image = (Image)resim_parcasi[c[x]];
                    x++;
                }
            }
        }

        public ArrayList ParcalaraAyirma(Bitmap Kirp, int x, int y) // Resimleri 16 parçaya ayırma işlemi yapar ve her butona sırayla ekleme işlemi yapar.
        {
            ArrayList img_resim_parcasi = new ArrayList();
            int SagaveSola = 0;
            int AsagiveYukari = 0;

            for (int k = 0; k < 16; k++)
            {
                Bitmap resim_parcasi = new Bitmap(x, y);

                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        resim_parcasi.SetPixel(i, j, Kirp.GetPixel(i + SagaveSola, j + AsagiveYukari)); 
                img_resim_parcasi.Add(resim_parcasi);

                SagaveSola += 110;

                if (SagaveSola == 440) { SagaveSola = 0; AsagiveYukari += 110; }
                if (AsagiveYukari == 440) { break; }
            }

            return img_resim_parcasi;
        }

        private void Yeniresim_btn_Click(object sender, EventArgs e) //Yeni'ye tıklandığında başka bir resim eklemek için bilgisayardan resim seçer.
        {
            OpenFileDialog DosyaAcma = new OpenFileDialog();

            DosyaAcma.Filter = "Image Files (JPEG,GIF,BMP,PNG,JPG)|*.jpeg;*.bmp;*.png;*.jpg"; // Bu tür dosyaların oyun için açılmasını sağlar.


            DosyaAcma.RestoreDirectory = true;
            if (DosyaAcma.ShowDialog() == DialogResult.OK)
            {
                BoyutDegistir = Image.FromFile(DosyaAcma.FileName);
                pictureBox1.Image = ResmiBoyutlandir(BoyutDegistir);
                ButonaResimEkle(ParcalaraAyirma(ResmiBoyutlandir(BoyutDegistir), 110, 110));
                
            }
        }

        private Bitmap ResmiBoyutlandir(Image img)
        {
            int w = 440;   
            int h = 440;   

            
            Bitmap bitmap = new Bitmap(w, h); // Resme göre yeni bir Bitmap oluşturur.
            Graphics grafik = Graphics.FromImage((Image)bitmap); // Bitmap'e göre yeni bir grafik oluşturur.
            grafik.InterpolationMode = InterpolationMode.HighQualityBicubic; // Yeniden boyutlandırılmış resmi çeker.
            grafik.DrawImage(img, 0, 0, w, h); 
            grafik.Dispose(); // Resmi geri döndürür.
            return bitmap;
        }

        private void Genislet_btn_Click(object sender, EventArgs e) // ">>>" tıklandığında resmin tam hali görülür.
        {
            if (Genislet_btn.Text == "<<<")
            {
                Genislet_btn.Text = ">>>";
                this.Size = new Size(513, 567);
            }
            else if (Genislet_btn.Text == ">>>")
            {
                Genislet_btn.Text = "<<<";
                this.Size = new Size(965, 567);
            }
        }

        private void Shuffle_btn_Click(object sender, EventArgs e)
        {
            ButonaResimEkle(ParcalaraAyirma(ResmiBoyutlandir(BoyutDegistir), 110, 110));
            x=x*0;
            label2.Text = x.ToString();
        }

        private int[] Shuffle(int[] array) // Shuffle butonuna tıklandığında dizinin içerisindeki sayıları random karıştırarak yer değiştirir.
        {
            Random r = new Random();

            int start = r.Next(1, array.Length);

            for (int i = 0; i < array.Length; i++)
                for (int j = start; j > 0; j--)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            return array;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Hamlesayisi_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
