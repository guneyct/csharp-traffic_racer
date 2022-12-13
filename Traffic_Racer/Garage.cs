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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Racer
{
    public partial class Garage : Form
    {
        public Garage()
        {
            InitializeComponent();
        }
        public Image arac;
        public static int hiz;
        Yaris f1 = new Yaris();
        public static ArrayList sahip = new ArrayList();
        private void pictureBox_Stock_Click(object sender, EventArgs e)
        {
            arac = ((PictureBox)sender).Image;
            ((PictureBox)sender).BackColor = Color.Transparent;
            
            if ((PictureBox)sender == pictureBox_Stock)
            {
                hiz = 15;
            }
            else if ((PictureBox)sender == pictureBox_Truck)
            {
                hiz = 25;
            }
            else if ((PictureBox)sender == pictureBox_Coop)
            {
                hiz = 40;
            }
            else
            {
                hiz = 55;
            }
            f1.ResimDegistir(arac, hiz);
            f1.Show();
            this.Close();
        }

        private void pictureBox_Stock_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.PaleGreen;
        }

        private void pictureBox_Stock_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void aracKontrol_Tick(object sender, EventArgs e)
        {
            Uyeler arac = new Uyeler();
            Giris giris = new Giris();
            if (Market.satinAlinanlar.Contains(pictureBox_Truck.Name) == true)
            {
                sahip.Add(pictureBox_Truck.Name);
                pictureBox_Truck.Enabled = true;
                label_kilitTruck.Visible = false;
                if (Market.satinAlinanlar.Contains(pictureBox_Coop.Name))
                {
                    sahip.Add(pictureBox_Coop.Name);
                    pictureBox_Coop.Enabled = true;
                    label_kilitCoop.Visible = false;
                    if (Market.satinAlinanlar.Contains(pictureBox_Ford.Name))
                    {
                        sahip.Add(pictureBox_Ford.Name);
                        pictureBox_Ford.Enabled = true;
                        label_kilitFord.Visible = false;
                    }
                }
                else if (Market.satinAlinanlar.Contains(pictureBox_Ford.Name))
                {
                    sahip.Add(pictureBox_Ford.Name);
                    pictureBox_Ford.Enabled = true;
                    label_kilitFord.Visible = false;
                    if (Market.satinAlinanlar.Contains(pictureBox_Coop.Name))
                    {
                        sahip.Add(pictureBox_Coop.Name);
                        pictureBox_Coop.Enabled = true;
                        label_kilitCoop.Visible = false;
                    }
                }
            }
            else if (Market.satinAlinanlar.Contains(pictureBox_Coop.Name) == true)
            {
                sahip.Add(pictureBox_Coop.Name);
                pictureBox_Coop.Enabled = true;
                label_kilitCoop.Visible = false;
                if (Market.satinAlinanlar.Contains(pictureBox_Truck.Name))
                {
                    sahip.Add(pictureBox_Truck.Name);
                    pictureBox_Truck.Enabled = true;
                    label_kilitTruck.Visible = false;
                    if (Market.satinAlinanlar.Contains(pictureBox_Ford.Name))
                    {
                        sahip.Add(pictureBox_Ford.Name);
                        pictureBox_Ford.Enabled = true;
                        label_kilitFord.Visible = false;
                    }
                }
                else if (Market.satinAlinanlar.Contains(pictureBox_Ford.Name))
                {
                    sahip.Add(pictureBox_Ford.Name);
                    pictureBox_Ford.Enabled = true;
                    label_kilitFord.Visible = false;
                    if (Market.satinAlinanlar.Contains(pictureBox_Truck.Name))
                    {
                        sahip.Add(pictureBox_Truck.Name);
                        pictureBox_Truck.Enabled = true;
                        label_kilitTruck.Visible = false;
                    }
                }
            }
            else if (Market.satinAlinanlar.Contains(pictureBox_Ford.Name) == true)
            {
                sahip.Add(pictureBox_Ford.Name);
                pictureBox_Ford.Enabled = true;
                label_kilitFord.Visible = false;
                if (Market.satinAlinanlar.Contains(pictureBox_Coop.Name))
                {
                    sahip.Add(pictureBox_Coop.Name);
                    pictureBox_Coop.Enabled = true;
                    label_kilitCoop.Visible = false;
                    if (Market.satinAlinanlar.Contains(pictureBox_Truck.Name))
                    {
                        sahip.Add(pictureBox_Truck.Name);
                        pictureBox_Truck.Enabled = true;
                        label_kilitTruck.Visible = false;
                    }
                }
                else if (Market.satinAlinanlar.Contains(pictureBox_Truck.Name))
                {
                    sahip.Add(pictureBox_Truck.Name);
                    pictureBox_Truck.Enabled = true;
                    label_kilitTruck.Visible = false;
                    if (Market.satinAlinanlar.Contains(pictureBox_Coop.Name))
                    {
                        sahip.Add(pictureBox_Coop.Name);
                        pictureBox_Coop.Enabled = true;
                        label_kilitCoop.Visible = false;
                    }
                }
            }
        }

        private void Garage_Load(object sender, EventArgs e)
        {
            Uyeler arac = new Uyeler();
            string path = @"carSave.txt";
            if (File.Exists(path))
            {
                string a = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(a))
                {
                    arac = JsonConvert.DeserializeObject<Uyeler>(a);
                }
                foreach (Arac item in arac.aracBilgiler)
                {
                    Market.satinAlinanlar.Add(item.SahipAracalar);
                }
            }
            aracKontrol.Start();
        }

        private void label_menuDon_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.PaleGreen;
        }

        private void label_menuDon_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Black;
        }

        private void label_menuDon_Click(object sender, EventArgs e)
        {
            Giris gir = new Giris();
            gir.Show();
            this.Close();
        }
    }
}
