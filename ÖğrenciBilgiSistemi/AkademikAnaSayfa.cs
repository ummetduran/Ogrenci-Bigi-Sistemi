using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ÖğrenciBilgiSistemi
{
    public partial class AkademikAnaSayfa : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt = new MySqlCommand();
        public AkademikAnaSayfa()
        {
            InitializeComponent();
            kmt = new MySqlCommand("select * from lecturer where id=" + loginForm.userID, connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            oku.Read();
            isimLabel.Text = oku["ad_soyad"].ToString();
        }

        private void notGirButton_Click(object sender, EventArgs e)
        {
            NotGir not = new NotGir();
            not.Show();
        }
    }
}
