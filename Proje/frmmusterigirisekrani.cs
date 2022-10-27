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
    public partial class frmmusterigirisekrani : Form
    {
        public frmmusterigirisekrani()
        {
            InitializeComponent();
        }

        private void geri_butonu_musteri_giris_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();                        //ANA EKRANA DÖNÜYOR
        }
    }
}
