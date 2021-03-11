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
    public partial class Notlar : Form
    {


        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
        public Notlar()
        {
            InitializeComponent();
            connect.baglan();
            listele();

        }

        void listele()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[0].Width = 60;


            string sql = "SELECT sınav_notu.*,lesson.name,lecturer.ad_soyad FROM sınav_notu LEFT JOIN lesson ON ders_id=code LEFT JOIN lecturer ON lecturer.id=lesson.lecturer_id where sınav_notu.student_id=" + loginForm.userID;
            kmt = new MySqlCommand(sql, connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                //double basariNotu =Int16.Parse( oku["vize"].ToString())*0.4 + Int16.Parse(oku["final"].ToString())*0.6;
                
                dataGridView1.Rows.Add(oku["ders_id"].ToString(), oku["name"].ToString(), oku["ad_soyad"], oku["vize"], oku["final"], oku["basari_notu"], oku["harf_notu"]);
                dataGridView1.Rows[i].Height = 60;
                    i++;
            }


        }

    }
}
