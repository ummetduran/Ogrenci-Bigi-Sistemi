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
    public partial class NotGir : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        public NotGir()
        {
            InitializeComponent();
        }

        private void ogrNoTextBox_TextChanged(object sender, EventArgs e)
        {

            MySqlCommand kmt = new MySqlCommand("SELECT lesson.name from lesson LEFT JOIN sınav_notu ON lesson.code= sınav_notu.ders_id where lecturer_id='" + loginForm.userID.ToString() + "' and sınav_notu.student_id='" + ogrNoTextBox.Text + "'", connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["name"].ToString());
            }
        }
        private void kaydetButton_Click(object sender, EventArgs e)
        {
            string combo_name = comboBox1.Text;
            MySqlCommand ders = new MySqlCommand("select code from lesson where name='" + combo_name+"';", connect.baglan());
            MySqlDataReader oku = ders.ExecuteReader();
            int ders_id = 0;
            oku.Read();
            
            ders_id = Int32.Parse(oku["code"].ToString());

            double basari_notu = Int16.Parse(vizeTextBox.Text) * 0.4 + Int16.Parse(finalTextBox.Text) * 0.6;
            string harf_notu;
            if (basari_notu <= 100 && basari_notu >= 87)
                harf_notu = "AA";
            else if (basari_notu < 87 && basari_notu >= 81)
                harf_notu = "BA";
            else if (basari_notu < 81 && basari_notu >= 74)
                harf_notu = "BB";
            else if (basari_notu < 74 && basari_notu >= 67)
                harf_notu = "CB";
            else if (basari_notu < 67 && basari_notu >= 60)
                harf_notu = "CC";
            else if (basari_notu < 60 && basari_notu >= 53)
                harf_notu = "DC";
            else if (basari_notu < 53 && basari_notu >= 46)
                harf_notu = "DD";
            else if (basari_notu < 46 && basari_notu >= 39)
                harf_notu = "FD";
            else
                harf_notu = "FF";

            string query = "UPDATE sınav_notu SET vize=@vize,final=@final,basari_notu=@basari_notu,harf_notu=@harf_notu WHERE ders_id=@ders_id AND student_id=@student_id";
            MySqlCommand kmt = new MySqlCommand();
            kmt.CommandText = query;
            kmt.Parameters.AddWithValue("@ders_id", ders_id);

            kmt.Parameters.AddWithValue("@student_id",ogrNoTextBox.Text);

            kmt.Parameters.AddWithValue("@vize", vizeTextBox.Text);
            kmt.Parameters.AddWithValue("@final", finalTextBox.Text);
            kmt.Parameters.AddWithValue("@basari_notu", basari_notu);
            kmt.Parameters.AddWithValue("@harf_notu", harf_notu);
            kmt.Connection = connect.baglan();

            if (kmt.ExecuteNonQuery() == 1)
                MessageBox.Show("Not girişri tamamlandı");
            else
                MessageBox.Show("Hata!");
        }

        private void ogrNoTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ogrNoTextBox.Text = "";
        }
    }
}
