using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciBilgiSistemi
{
    public partial class OgrenciisleriAnaSayfa : Form
    {
        public OgrenciisleriAnaSayfa()
        {
            InitializeComponent();
        }
        private void ogrenciEkleButton_Click(object sender, EventArgs e)
        {
            Form OgrenciEkle = new OgrenciEkle();
            OgrenciEkle.Show();
        }
        private void ogretimUyesiButton_Click(object sender, EventArgs e)
        {
            OgretimUyesiEkle ogretimUyesiEkle = new OgretimUyesiEkle();
            ogretimUyesiEkle.Show();
        }
        private void kayitYenilemeButton_Click_1(object sender, EventArgs e)
        {
            KayitYenilemeOnay onay = new KayitYenilemeOnay();
            onay.Show();
        }
        private void harcButton_Click_1(object sender, EventArgs e)
        {
            HarcIslemleri harc = new HarcIslemleri();
            harc.Show();
        }
    }
}
