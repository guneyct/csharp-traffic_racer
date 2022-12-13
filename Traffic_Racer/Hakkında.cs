using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Racer
{
    public partial class Hakkında : Form
    {
        public Hakkında()
        {
            InitializeComponent();
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
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }
    }
}
