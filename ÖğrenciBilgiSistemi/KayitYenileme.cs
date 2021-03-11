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
    public partial class KayitYenileme : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
        public KayitYenileme()
        {
            InitializeComponent();
            connect.baglan();
            MySqlCommand sql = new MySqlCommand("select durum from student where id=" + loginForm.userID, connect.baglan());
            MySqlDataReader oku = sql.ExecuteReader();
            oku.Read();
            //string durum = sql.ExecuteScalar().ToString();
            if (oku["durum"].ToString() == "Kayıt Yenileme")
                listele();
            else
                MessageBox.Show("Ders Kayıtlanma Dönemi Aktif Değil!");
                
        }

        void listele()
        {
            dataGridView2.ReadOnly = false;
            dataGridView2.AllowUserToDeleteRows = false; 

            dataGridView2.ColumnCount = 4;
            
            dataGridView2.Columns[0].Width = 165;
            dataGridView2.Columns[1].Width = 339;
            dataGridView2.Columns[2].Width = 250;
            dataGridView2.Columns[3].Width = 71;

            string sql = "SELECT lesson.*,lecturer.ad_soyad FROM `lesson` LEFT JOIN lecturer ON lesson.lecturer_id=lecturer.id";
            kmt = new MySqlCommand(sql, connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            int i = 0;
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            
            dataGridView2.Columns.Add(column);
            column.TrueValue = true;
            column.FalseValue = false;

            while (oku.Read())

            {
                dataGridView2.Rows.Add(oku["code"].ToString(), oku["name"].ToString(), oku["ad_soyad"], oku["kredi"]);
                dataGridView2.Rows[i].Height = 60;
                dataGridView2.Columns[4].Width = 75; 
                i++;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.ReadOnly = false;
            dataGridView3.AllowUserToDeleteRows = false;

            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Width = 190;
            dataGridView3.Columns[1].Width = 387;
            dataGridView3.Columns[2].Width = 250;
            dataGridView3.Columns[3].Width = 73;
            int i = 0;
            int row_count = 0;
            int top_kredi = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    
                }
                else
                {
                    dataGridView3.Rows.Add(row.ToString());
                    for (int j = 0; j < 4; j++)
                    {
                        dataGridView3.Rows[row_count].Cells[j].Value = dataGridView2.Rows[i].Cells[j].Value;
                    }
                    top_kredi += Int16.Parse((dataGridView2.Rows[i].Cells[3].Value).ToString());
                    row_count++;
                }
                i++;
            }
            dataGridView2.EndEdit();
            label19.Text = row_count.ToString();
            label20.Text = top_kredi.ToString();
           
            MessageBox.Show("Seçim tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);   
    }

        private void button4_Click(object sender, EventArgs e)
        {
            object sonuc=0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                MySqlCommand kmt = new MySqlCommand("insert into sınav_notu(ders_id,student_id) values(@ders_id,@student_id)", connect.baglan());
               
                kmt.Parameters.AddWithValue("@ders_id", dataGridView3.Rows[i].Cells[0].Value.ToString());
                kmt.Parameters.AddWithValue("@student_id", loginForm.userID);

                sonuc = kmt.ExecuteNonQuery();
            }
             
            if (sonuc != null)
                MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView3.Rows.Clear();

        }
    }
}
