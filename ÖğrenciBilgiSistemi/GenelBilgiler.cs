using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace ÖğrenciBilgiSistemi
{
    public partial class GenelBilgiler : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
       
        public GenelBilgiler()
        {
            InitializeComponent();
            connect.baglan();
            kmt = new MySqlCommand("select * from student where id="+loginForm.userID, connect.baglan());

            MySqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                adSoyadTextBox.Text = oku["ad_soyad"].ToString();
                ogrnoTextBox.Text = oku["id"].ToString();
                textBox8.Text = oku["faculty"].ToString();
                textBox11.Text = oku["department"].ToString();
                birthdayTextBox.Text = oku["birthday"].ToString().Substring(0,11);
                textBox12.Text = oku["start_date"].ToString().Substring(0,11);
               
                textBox3.Text = oku["durum"].ToString();
                textBox4.Text = oku["tc_number"].ToString();
                
                
                textBox7.Text = oku["dogum_yeri"].ToString();
                textBox10.Text = oku["adres"].ToString();
                sehirComboBox.Text = oku["sehir"].ToString();
                ePostaTextBox.Text = oku["mail"].ToString();
                telefonTextBox.Text = oku["telefon"].ToString();

                }
        }

        private void kaydetButoon_Click(object sender, EventArgs e)
        {
            string query = "UPDATE student SET adres=@adres,sehir=@sehir,mail=@mail,telefon=@telefon WHERE id=@id";
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("id",loginForm.userID);
            cmd.Parameters.AddWithValue("@adres", textBox10.Text);
            cmd.Parameters.AddWithValue("@sehir",sehirComboBox.Text);
            cmd.Parameters.AddWithValue("@telefon",telefonTextBox.Text);
            cmd.Parameters.AddWithValue("@mail", ePostaTextBox.Text);
            cmd.Connection = connect.baglan();
            
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kaydedildi");
                this.Close();
            }
            else
                MessageBox.Show("Kayıt Başarısız");

        }
    }
}
