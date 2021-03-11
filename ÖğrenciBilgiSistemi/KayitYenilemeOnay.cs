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
    public partial class KayitYenilemeOnay : Form
    {
        DatabaseConnection connect = new DatabaseConnection();

        public KayitYenilemeOnay()
        {
            
            InitializeComponent();
            connect.baglan();
        }

        private void araButton_Click(object sender, EventArgs e)
        {

            MySqlCommand sql = new MySqlCommand("select durum from student where id=" + ogrNoTextBox.Text, connect.baglan());
            MySqlDataReader read = sql.ExecuteReader();
            read.Read();
            //string durum = sql.ExecuteScalar().ToString();
            if (read["durum"].ToString() == "Kayıt Yenileme")
            {

                dataGridView3.ColumnCount = 3;
                dataGridView3.Columns[0].Width = 178;
                dataGridView3.Columns[1].Width = 355;
                dataGridView3.Columns[2].Width = 144;


                MySqlCommand kmt = new MySqlCommand("SELECT lesson.*,sınav_notu.student_id FROM lesson LEFT JOIN sınav_notu on sınav_notu.ders_id=lesson.code WHERE student_id=" + ogrNoTextBox.Text, connect.baglan());
                MySqlDataReader oku = kmt.ExecuteReader();


                int top_kredi = 0;
                int i = 0;
                while (oku.Read())
                {

                    dataGridView3.Rows.Add(oku["code"].ToString(), oku["name"].ToString(), oku["kredi"]);
                    top_kredi += Int16.Parse((dataGridView3.Rows[i].Cells[2].Value).ToString());
                    i++;
                }

                label19.Text = i.ToString();
                label20.Text = top_kredi.ToString();
            }
            else
                MessageBox.Show("Bu öğrencinin kesin kayıtlanma işlemi yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string durum = "Aktif";
            MySqlCommand kmt = new MySqlCommand("update student set durum='"+durum+"'where id='"+ogrNoTextBox.Text+"'",connect.baglan());
            if(kmt.ExecuteNonQuery()==1)
                MessageBox.Show("Seçim Onaylandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Hata", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand kmt = new MySqlCommand("delete from sınav_notu where student_id=" + ogrNoTextBox.Text, connect.baglan());

            if (kmt.ExecuteNonQuery() == 1)
            {
                

                this.Close();
            }
            else
            {
                MessageBox.Show("Ders seçimi iptal edildi.");
            }
        }
    }
}
