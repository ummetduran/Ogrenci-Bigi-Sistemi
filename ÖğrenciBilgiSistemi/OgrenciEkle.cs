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
    public partial class OgrenciEkle : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        public OgrenciEkle()
        {
            InitializeComponent();
            connect.baglan();
        }

        private void kaydetButoon_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt2 = new MySqlCommand("insert into users(id,name,mail) values ('"+ogrnoTextBox.Text+"','" + adSoyadTextBox.Text+"','" + ePostaTextBox.Text+"')", connect.baglan());
            MySqlCommand kmt1 = new MySqlCommand("insert into student(id,ad_soyad,faculty,department, tc_number, birthday,dogum_yeri,start_date,mail,durum) values" +" ('"+ ogrnoTextBox.Text + "','"+ adSoyadTextBox.Text + "','" + fakulteTextBox.Text+"','" + bolumTextBox1.Text+"','" + tcTextBox.Text + "','"+birthdayTextBox.Text+"','"+dogumYeriTextBox.Text+"','"+ baslamaTarihiTextBox.Text+"','"+ ePostaTextBox.Text +"','"+durumTextBox.Text+"' )", connect.baglan());
            
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
