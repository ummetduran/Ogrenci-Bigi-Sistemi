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
    public partial class HarcEdit : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
        public HarcEdit(string title        )
        {
            InitializeComponent();
            Text = title;
                
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            kmt = new MySqlCommand("insert into harc(ogrenci_id,donem,fiyat,odeme) values('"+HarcIslemleri.user_id.ToString() +"','"+donemTextBox.Text +"','"+fiyatTextBox.Text+"','"+odemeTextBox.Text+"')",connect.baglan());
            if(kmt.ExecuteNonQuery() == 1) {
                MessageBox.Show("Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Kayıt Başarısız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }


    }
}
