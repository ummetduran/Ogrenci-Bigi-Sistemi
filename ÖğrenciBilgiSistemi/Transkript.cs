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
    public partial class Transkript : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
        public Transkript()
        {
            InitializeComponent();
            connect.baglan();
            listele();
        }

        void listele()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnCount = 5;

            string sql = "SELECT lesson.code,lesson.name,lesson.kredi,sınav_notu.basari_notu, sınav_notu.harf_notu from lesson LEFT JOIN sınav_notu ON lesson.code=sınav_notu.ders_id where sınav_notu.student_id=" + loginForm.userID;
            kmt = new MySqlCommand(sql, connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            int kredi = 0;
            int gno_top = 0;
            int i = 0;
            while (oku.Read())
            {
                kredi += Int16.Parse(oku["kredi"].ToString());
                dataGridView1.Rows.Add(oku["code"].ToString(), oku["name"].ToString(), oku["kredi"], oku["basari_notu"], oku["harf_notu"]);
                gno_top+= Int16.Parse(oku["kredi"].ToString())* Int16.Parse(oku["basari_notu"].ToString()); ;
                dataGridView1.Rows[i].Height = 40 ;
                i++;
            }
            krediLabel.Text = kredi.ToString();
            gnoLabel.Text = (gno_top / kredi).ToString();


        }
    }
}
