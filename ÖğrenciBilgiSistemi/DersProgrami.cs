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
    public partial class DersProgrami : Form
    {
        DatabaseConnection connect = new DatabaseConnection();
        MySqlCommand kmt;
        public DersProgrami()
        {
            InitializeComponent();
            connect.baglan();

            
        }

     

      
    }
}
