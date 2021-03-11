using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ÖğrenciBilgiSistemi
{
    public partial class loginForm : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        string kullaniciAdi;
        public static string userID;
        MySqlCommand kmt;
        public loginForm()
        {
            InitializeComponent();
            connect.baglan();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            kullaniciAdi = kullaniciAdiTextBox.Text;
            string mail = kullaniciAdi +"@"+ mailComboBox.Text;
            kmt = new MySqlCommand("select * from users where mail='" + mail + "';", connect.baglan());
            MySqlDataReader oku = kmt.ExecuteReader();
            if (kullaniciAdiTextBox.Text == "" || parolaTextBox.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz.");
            }
            else if (oku.Read())
            {
                userID = oku["id"].ToString();
                if (mailComboBox.Text.Equals("ogrenci.edu.tr"))
                {
                    Form AnaSayfa = new anaSayfaForm();
                    AnaSayfa.Show();
                }
                else if (mailComboBox.Text.Equals("personel.edu.tr"))
                {
                    Form OgrenciisleriAnaSayfa = new OgrenciisleriAnaSayfa();
                    OgrenciisleriAnaSayfa.Show();
                }
                else if (mailComboBox.Text.Equals("akademik.edu.tr"))
                {
                    Form AkademikAnaSayfa = new AkademikAnaSayfa();
                    AkademikAnaSayfa.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok.");

            }

           

        }
    }
}
