using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ÖğrenciBilgiSistemi
{
    public partial class anaSayfaForm : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
        
        public anaSayfaForm()
        {
            InitializeComponent();
            
            kmt = new MySqlCommand("select * from student where id=" + loginForm.userID,connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                isimLabel.Text = oku["ad_soyad"].ToString();
                fakulteLabel.Text = oku["faculty"].ToString();
                bolumLabel.Text = oku["department"].ToString();
                durumLabel.Text = oku["durum"].ToString();
            }
        }

        
        
            private void dersProgButton_MouseEnter(object sender, EventArgs e)
        {
            

            toolTip1.IsBalloon = true;
            
            toolTip1.SetToolTip(harcButton, "Harç bilgilerini görüntüle");
            toolTip1.SetToolTip(genelBilgiButton, "Genel bilgilerini görüntüle");
            toolTip1.SetToolTip(notButton, "Notlarını görüntüle");
            toolTip1.SetToolTip(transkriptButton, "Transkriptini görüntüle");
            toolTip1.SetToolTip(kayıtYenilemeButton, "Kayıt yenileme işlemleri");





        }

        private void genelBilgiButton_Click(object sender, EventArgs e)
        {
            Form GenelBilgiler = new GenelBilgiler();
            GenelBilgiler.Show();
        }

        private void harcButton_Click(object sender, EventArgs e)
        {
            Form HarcBilgisi = new HarcBilgisi();
            HarcBilgisi.Show();
        }

        private void dersProgButton_Click(object sender, EventArgs e)
        {
            Form DersProgrami = new DersProgrami();
            DersProgrami.Show();
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            Form Notlar = new Notlar();
            Notlar.Show();
        }

        private void transkriptButton_Click(object sender, EventArgs e)
        {
            Form Transkript = new Transkript();
            Transkript.Show();

        }

        private void kayıtYenilemeButton_Click(object sender, EventArgs e)
        {
            Form KayitYenileme = new KayitYenileme();
            KayitYenileme.Show();
        }

       
    }
}
