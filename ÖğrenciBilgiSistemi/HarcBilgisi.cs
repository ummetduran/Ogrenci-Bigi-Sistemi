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

    public partial class HarcBilgisi : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;

        public HarcBilgisi()
        {
            InitializeComponent();
            connect.baglan();
            listele();
         
        }
        
         public void listele()
        {
            dataGridView1.ReadOnly = true; 
            dataGridView1.AllowUserToDeleteRows = false;
           
            dataGridView1.ColumnCount = 3;
           
            string sql = "select * from harc where ogrenci_id=" + loginForm.userID;
            kmt = new MySqlCommand(sql, connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            
            while (oku.Read())
            {
                dataGridView1.Rows.Add(oku["donem"].ToString(), oku["fiyat"].ToString(),oku["odeme"]);
            }
           
            
        }

      
    }
}
