using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciBilgiSistemi
{
    class DatabaseConnection
    {
        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection("Server =localhost; Database=ogrencibilgisistemi;Uid=root;Pwd=;");
            baglanti.Open();
            return baglanti;
        }
    }
}
