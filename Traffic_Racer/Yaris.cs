using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Racer.Properties;

namespace Traffic_Racer
{
    public partial class Yaris : Form
    {
        #region Form Açılma

        public Yaris()
        {
            InitializeComponent();
        }
        int speed = 5;
        int maxSpeed = 0;
        Random r = new Random();
        ResourceManager rm = Resources.ResourceManager;
        ArrayList araclar = new ArrayList();
        ArrayList seritler = new ArrayList();
        ArrayList bosSerit = new ArrayList();
        ArrayList bölgeKontrol = new ArrayList();
        ArrayList bölgeKontrol2 = new ArrayList();
        int Y = -40, say = 0;
        bool b = true;

        // Oyuncu Aracı:
        public void ResimDegistir(Image resim, int maksHız)
        {
            pictureBox2.Image = resim;
            maxSpeed = maksHız;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Oyuna Başlama:
            MessageBox.Show("Oyuna Başlamak için 'Enter' Tuşuna Basınız.", "Oyuna Başla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (pictureBox2.Image == (Image)rm.GetObject("Stock"))
            {
                speed = 5;
            }

            // Sanal Bölge:
            bölgeKontrol.Add(new Point(21, 1));
            bölgeKontrol.Add(new Point(85, 1));
            bölgeKontrol.Add(new Point(116, 1));
            bölgeKontrol.Add(new Point(180, 1));
            button_ustSınır.Visible = false;

            // Trafikteki Araçlar
            for (int i = 0; i < 5; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Width = 47;
                pbx.Height = 60;
                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                pbx.Image = (Image)rm.GetObject((r.Next(1, 5)).ToString());
                pbx.Name = "pbx" + i.ToString();
                pbx.Visible = true;
                pbx.BackColor = Color.DimGray;
                pbx.Location = new Point(r.Next(21, 211), -70);
                araclar.Add(pbx);
                Y += 70;

                // Bölge Kontrolü (G. Araçların Üst Üste Gelme Kontrolü):
                for (int j = 0; j < bölgeKontrol.Count; j++)
                {
                    if (pbx.Location.X >= ((Point)bölgeKontrol[j]).X && pbx.Location.X <= ((Point)bölgeKontrol[j]).X)
                    {
                        b = false;
                        break;
                    }
                    else
                    {
                        b = true;
                    }
                }
                if (b)
                {
                    b = false;

                    Controls.Add(pbx);
                    pictureBox_Yol.SendToBack();
                }
            }
            foreach (PictureBox item in araclar)
            {
                item.Visible = false;
            }

            // Şerit Çizgileri:
            int serX = 70, serY = -70, serSayi = 0;
            for (int i = 0; i < 36; i++)
            {
                PictureBox serit = new PictureBox();
                serit.Size = new Size(10, 30);
                serit.BackColor = Color.White;
                serit.Location = new Point(serX, serY);
                Controls.Add(serit);
                seritler.Add(serit);
                pictureBox_Yol.SendToBack();
                serSayi++;
                serY += 70;
                if (serSayi == 6)
                {
                    serX += 70;
                    serY = -70;
                    serSayi = 0;
                }
            }
        }
        #endregion

        #region Timer
        int parSay = 0;
        public static int kazPara;
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Kontrol ve Hareket
            // Trafik Hareket:
            foreach (PictureBox item in araclar)
            {

                if (item.Visible)
                {
                    if (speed > maxSpeed)
                    {
                        speed = maxSpeed;
                    }

                    item.Location = new Point(item.Location.X, item.Location.Y + speed);
                }
                // Gelen Araçların Çarpma Kontrolü (G. Araçlar - Kenarlar):
                foreach (PictureBox gelAr in araclar)
                {
                    if (item != gelAr && item.Visible && gelAr.Visible)
                    {
                        if (gelAr.Bounds.IntersectsWith(item.Bounds))
                        {
                            item.Visible = false;
                            item.Location = new Point(r.Next(23, 235), -150);
                        }
                    }
                }
                if (item.Bounds.IntersectsWith(carEraser.Bounds))
                {
                    // Arabaların Değişmesi:
                    say++;
                    item.Image = (Image)rm.GetObject(r.Next(1, 5).ToString());
                    item.Location = new Point(r.Next(23, 235), -150);
                    if (say == 3)
                    {
                        say = 0;
                        foreach (Button a in bosSerit)
                        {
                            Controls.Remove(a);
                        }
                    }
                }
                else if (item.Bounds.IntersectsWith(button_YanSınır.Bounds) || item.Bounds.IntersectsWith(button_yanSinir.Bounds))
                {
                    item.Visible = false;
                    item.Location = new Point(r.Next(23, 235), -150);

                    // Arabaların Değişmesi:
                    item.Image = (Image)rm.GetObject(r.Next(1, 6).ToString());
                }

                // Gelen Araçların Çarpma Kontrolü (Oyuncu - G. Araçlar):
                else if (item.Bounds.IntersectsWith(pictureBox2.Bounds) && item.Visible == true)
                {
                    timer1.Stop();
                    MessageBox.Show("Kaza Yaptınız..!", "KAZA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    item.Location = new Point(r.Next(23, 235), -150);
                    Sıfırla();
                }

                // Gelen Arabaların Şeritlerden Gelmesi:
                foreach (PictureBox serit in seritler)
                {
                    if (item.Bounds.IntersectsWith(serit.Bounds) && item.Visible)
                    {
                        item.Visible = false;
                        item.Location = new Point(r.Next(23, 280), -150);
                    }
                }

                item.Visible = true;
            }

            // Oyuncu Yana Hareket Kontrolleri:
            if (pictureBox2.Bounds.IntersectsWith(button_YanSınır.Bounds))
            {
                pictureBox2.Location = new Point((pictureBox2.Location.X - 70), pictureBox2.Location.Y);

            }
            else if (pictureBox2.Bounds.IntersectsWith(button_yanSinir.Bounds) || pictureBox2.Location.X <= (button_yanSinir.Location.X + button_yanSinir.Width))
            {
                pictureBox2.Location = new Point((pictureBox2.Location.X + 70), pictureBox2.Location.Y);
            }

            // Şerit Hareket:
            foreach (PictureBox item in seritler)
            {
                item.Location = new Point(item.Location.X, (item.Location.Y + 10));
                if (item.Bounds.IntersectsWith(carEraser.Bounds))
                {
                    item.Location = new Point(item.Location.X, -70);
                }
            }

            #endregion

            #region KM/H Yazma
            if (speed < 0)
            {
                speed = 5;
            }
            label_Km.Text = (speed * 10).ToString() + " KM/H";
            #endregion

            #region Para Yazma
            parSay++;
            if (parSay == 5)
            {
                kazPara++;
                parSay = 0;
                label_kazPara.Text = kazPara.ToString() + " OP";
            }

            #endregion

        }

        private void Yaris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris.topPara += kazPara;
            kazPara = 0;
            label_kazPara.Text = kazPara.ToString() + " OP";
            string path = @"cashSave.txt";
            Uyeler para = new Uyeler();
            para.Bilgiler.Add(new Para
            {
                OyuncuPara = Giris.topPara.ToString()
            });
            string a = JsonConvert.SerializeObject(para);
            File.WriteAllText(path, a);
        }

        private void label_menuDon_MouseEnter(object sender, EventArgs e)
        {
            label_menuDon.BackColor = Color.PaleGreen;
        }

        private void label_menuDon_MouseLeave(object sender, EventArgs e)
        {
            label_menuDon.BackColor = Color.Black;
        }

        private void label_menuDon_Click(object sender, EventArgs e)
        {
            Giris gir = new Giris();
            gir.Show();
            this.Close();
        }

        // Sıfırlama:
        private void Sıfırla()
        {
            pictureBox2.Visible = true;
            this.Close();
            Garage f2 = new Garage();
            f2.Show();
        }

        #endregion

        #region Hareket Etme
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Sola Gitme:
            if (e.KeyCode == Keys.Left)
            {
                pictureBox2.Location = new Point((pictureBox2.Location.X - 70), pictureBox2.Location.Y);
            }

            // Hızlanma:
            else if (e.KeyCode == Keys.Up)
            {
                speed += 5;
            }

            // Yavaşlama:
            else if (e.KeyCode == Keys.Down)
            {
                speed -= 5;
            }

            // Sağa Gitme:
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox2.Location = new Point((pictureBox2.Location.X + 70), pictureBox2.Location.Y);
            }

            // Durdurma:
            else if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                MessageBox.Show("Oyun Durdu. Devam Etmek için 'Tamam' Basınız.", "Durduruldu!", MessageBoxButtons.OK);
                timer1.Start();
            }

            // Başlatma:
            else if (e.KeyCode == Keys.Enter)
            {
                if (pictureBox2.Image != null)
                {
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Araba Seçiniz..!");
                    Garage giris = new Garage();
                    giris.Show();
                    this.Hide();
                }
            }
        }
        #endregion
    }
}
