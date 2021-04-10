using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginEncrpyt
{
    class Connection
    {
        static string server = "127.0.0.1;";
        static string database = "loginencript;";
        static string Uid = "root;";
        static string password = ";";

        public static MySqlConnection connMaster;
        public static MySqlConnection DataSource()
        {
            connMaster = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return connMaster;
        }

        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }
    }
}
