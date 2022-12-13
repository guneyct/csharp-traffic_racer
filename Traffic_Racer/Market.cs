using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Racer
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }

        public static ArrayList satinAlinanlar = new ArrayList();

        private void label_satinAlTruck_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.PaleGreen;
        }

        private void label_satinAlTruck_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        int fiyat;
        private void label_satinAlTruck_Click(object sender, EventArgs e)
        {
            Garage gar = new Garage();
            Giris gir = new Giris();
            if ((Label)sender == label_satinAlTruck && Giris.topPara - 500 >= 0)
            {
                fiyat = 500;
                satinAlinanlar.Add(pictureBox_Truck.Name);
                label_satinAlTruck.Visible = false;
                label_Truck.Visible = true;
                CashSaveFunction(fiyat);
            }
            else if ((Label)sender == label_satinAlCoop && Giris.topPara - 1000 >= 0)
            {
                fiyat = 1000;
                satinAlinanlar.Add(pictureBox_Coop.Name);       
                label_satinAlCoop.Visible = false;
                label_Coop.Visible = true;
                CashSaveFunction(fiyat);
            }
            else if ((Label)sender == label_satinAlFord && Giris.topPara - 2500 >= 0)
            {
                fiyat = 2500;
                satinAlinanlar.Add(pictureBox_Ford.Name);
                label_satinAlFord.Visible = false;
                label_Ford.Visible = true;
                CashSaveFunction(fiyat);
            }
            else
            {
                MessageBox.Show("Yeterli Paranız Yok..!");
            }
            gir.Show();
            this.Hide();
        }

        private void Market_Load(object sender, EventArgs e)
        {
            Uyeler arac = new Uyeler();
            string path = @"carSave.txt";
            if (File.Exists(path))
            {
                string a = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(a))
                {
                    arac = JsonConvert.DeserializeObject<Uyeler>(a);

                    foreach (Arac item in arac.aracBilgiler)
                    {
                        Garage.sahip.Add(item.SahipAracalar);
                        satinAlinanlar.Add(item.SahipAracalar);
                    }
                }
                
            }

            label_para.Text = "Oyuncu Para: " + Giris.topPara.ToString() + " OP";
            satinAlinanKontrol.Start();
        }

        private void satinAlinanKontrol_Tick(object sender, EventArgs e)
        {        
            if (satinAlinanlar.Contains(pictureBox_Truck.Name))
            {
                label_Truck.Visible = true;
                label_satinAlTruck.Enabled = false;
                if (satinAlinanlar.Contains(pictureBox_Coop.Name))
                {
                    label_Coop.Visible = true;
                    label_satinAlCoop.Enabled = false;
                    if (satinAlinanlar.Contains(pictureBox_Ford.Name))
                    {
                        label_Ford.Visible = true;
                        label_satinAlFord.Enabled = false;
                    }
                }
                else if (satinAlinanlar.Contains(pictureBox_Ford.Name))
                {
                    label_Ford.Visible = true;
                    label_satinAlFord.Enabled = false;
                    if (satinAlinanlar.Contains(pictureBox_Coop.Name))
                    {
                        label_Coop.Visible = true;
                        label_satinAlCoop.Enabled = false;
                    }
                }
            }
            else if (satinAlinanlar.Contains(pictureBox_Coop.Name))
            {
                label_Coop.Visible = true;
                label_satinAlCoop.Enabled = false;
                if (satinAlinanlar.Contains(pictureBox_Truck.Name))
                {
                    label_Truck.Visible = true;
                    label_satinAlTruck.Enabled = false;
                    if (satinAlinanlar.Contains(pictureBox_Ford.Name))
                    {
                        label_Ford.Visible = true;
                        label_satinAlFord.Enabled = false;
                    }
                }
                else if (satinAlinanlar.Contains(pictureBox_Ford.Name))
                {
                    label_Ford.Visible = true;
                    label_satinAlFord.Enabled = false;
                    if (satinAlinanlar.Contains(pictureBox_Truck.Name))
                    {
                        label_Truck.Visible = true;
                        label_satinAlTruck.Enabled = false;
                    }
                }
            }
            else if (satinAlinanlar.Contains(pictureBox_Ford.Name))
            {
                label_Ford.Visible = true;
                label_satinAlFord.Enabled = false;
                if (satinAlinanlar.Contains(pictureBox_Coop.Name))
                {
                    label_Coop.Visible = true;
                    label_satinAlCoop.Enabled = false;
                    if (satinAlinanlar.Contains(pictureBox_Truck.Name))
                    {
                        label_Truck.Visible = true;
                        label_satinAlTruck.Enabled = false;
                    }
                }
                else if (satinAlinanlar.Contains(pictureBox_Truck.Name))
                {
                    label_Truck.Visible = true;
                    label_satinAlTruck.Enabled = false;
                    if (satinAlinanlar.Contains(pictureBox_Coop.Name))
                    {
                        label_Coop.Visible = true;
                        label_satinAlCoop.Enabled = false;
                    }
                }
            }
        }

        private void label_menuDon_Click(object sender, EventArgs e)
        {
            Giris gir = new Giris();
            gir.Show();
            this.Close();
        }

        private void CashSaveFunction(int fiyat)
        {

            string path = @"carSave.txt";
            Uyeler arac = new Uyeler();
            foreach (string item in satinAlinanlar)
            {
                arac.aracBilgiler.Add(new Arac
                {
                    SahipAracalar = item
                });
            }
            string _json = JsonConvert.SerializeObject(arac);
            File.WriteAllText(path, _json);


            if (fiyat != 0) {
                path = @"cashSave.txt";
                Giris.topPara -= fiyat;
                Uyeler para = new Uyeler();
                para.Bilgiler.Add(new Para
                {
                    OyuncuPara = Giris.topPara.ToString()
                });
                _json = JsonConvert.SerializeObject(para);
                File.WriteAllText(path, _json);
            }
        }
    }
}
