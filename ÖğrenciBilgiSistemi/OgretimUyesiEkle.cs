using MySql.Data.MySqlClient;
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
    public partial class OgretimUyesiEkle : Form
    {
        DatabaseConnection connect = new DatabaseConnection();

        public OgretimUyesiEkle()
        {
            InitializeComponent();
            connect.baglan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt2= new MySqlCommand("insert into users(id,name,mail) values('" + idTextBox.Text + "','" + adSoyadTextBox.Text + "','" + mailTextBox.Text + "')", connect.baglan());
            MySqlCommand kmt1 = new MySqlCommand("insert into lecturer(id,ad_soyad,mail) values('"+ idTextBox.Text +"','" + adSoyadTextBox.Text+"','"+ mailTextBox.Text+"')", connect.baglan());

            if (kmt2.ExecuteNonQuery() == 1 && kmt1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kaydedildi");
                this.Close();
            }
            else
                MessageBox.Show("Kayıt Başarısız");
        }
    }
}
