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
    public partial class HarcIslemleri : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        public static string user_id;
        

        public HarcIslemleri()
        {
            InitializeComponent();
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            user_id = ogrNoTextBox.Text.ToString();
            ogrNoTextBox.Visible = false;
            label1.Visible = false;
            araButton.Visible = false;

            HarcShow show = new HarcShow("Önceki Ödemeler");
            HarcEdit edit = new HarcEdit("Ödeme Gir");
            show.MdiParent = this;

            edit.MdiParent= this;
            
            show.Show();
            edit.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
