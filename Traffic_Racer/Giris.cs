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
using System.Media;
using System.Resources;
using Traffic_Racer.Properties;

namespace Traffic_Racer
{

    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        // Çıkış Butonu:
        string path = "cashSave.txt";
        private void label_Exit_Click(object sender, EventArgs e)
        {
            Uyeler para = new Uyeler();
            para.Bilgiler.Add(new Para
            {
                OyuncuPara = Giris.topPara.ToString()
            });
            string a = JsonConvert.SerializeObject(para);
            File.WriteAllText(path, a);
            Application.Exit();
        }

        // Oyunu Başlatma:
        Yaris yaris = new Yaris();
        private void label_GameStart_Click(object sender, EventArgs e)
        {
            Garage gar = new Garage();
            gar.Show();
            this.Hide();
        }

        // Butonların Renk Değiştirmesi:
        private void label_GameStart_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.ForestGreen;
        }
        private void label_GameStart_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.White;
        }

        Market mark = new Market();
        private void label_Market_Click(object sender, EventArgs e)
        {
            mark.Show();
            this.Hide();
        }

        public static int topPara;

        private void Giris_Load(object sender, EventArgs e)
        {
            topPara += Yaris.kazPara;
            label_GenPara.Text = "Oyuncu Para: " + topPara.ToString() + " OP";
            Uyeler para = new Uyeler();
            if (File.Exists(path) && Yaris.kazPara == 0)
            {
                string a = File.ReadAllText(path);
                if (!string.IsNullOrEmpty(a))
                {
                    para = JsonConvert.DeserializeObject<Uyeler>(a);
                }
                foreach (Para item in para.Bilgiler)
                {
                    topPara = int.Parse(item.OyuncuPara);
                }
            }
            label_GenPara.Text = "Oyuncu Para: " + topPara.ToString() + " OP";
            Yaris.kazPara = 0;
        }

        private void label_Garage_Click(object sender, EventArgs e)
        {
            Garage gar = new Garage();
            gar.Show();
            this.Hide();
        }

        private void label_About_Click(object sender, EventArgs e)
        {
            Hakkında about = new Hakkında();
            about.Show();
            this.Hide();
        }
    }
    public class Para
    {
        public string OyuncuPara { get; set; }
    }
    public class Arac
    {
        public string SahipAracalar { get; set; }
    }
    public class Uyeler
    {
        public Uyeler()
        {
            this.Bilgiler = new List<Para>();
            this.aracBilgiler = new List<Arac>();

        }
        public List<Para> Bilgiler { get; set; }
        public List<Arac> aracBilgiler { get; set; }
    }
}
