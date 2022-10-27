using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void personel_giris_buton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();                 //PERSONEL GİRİŞ ANA SAYFASINA YÖNLENDİRİR.
            f2.Show();
            this.Hide();
        }

        private void musteri_giris_buton_Click(object sender, EventArgs e)
        {
            frmmusterigirisekrani f3 = new frmmusterigirisekrani();                 //MÜŞTERİ GİRİŞ ANA SAYFASINA YÖNLENDİRİR.
            f3.Show();
            this.Hide();
        }

        private void yonetici_giris_buton_Click(object sender, EventArgs e)
        {
            frmyoneticigirisekrani f4 = new frmyoneticigirisekrani();                 //YÖNETİCİ GİRİŞ ANA SAYFASINA YÖNLENDİRİR.
            f4.Show();
            this.Hide();
        }
    }
}
