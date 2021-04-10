using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginEncrpyt
{
    class insertData
    {
        Connection con = new Connection();
        Encrypt en = new Encrypt();

        public string InsertData(string userInsert, string passInsert, string insertDateTime)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO users (userName, Password, Registered) values (@name, @password, @datetime)";
                command.Parameters.AddWithValue("@name", userInsert);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(passInsert));
                command.Parameters.AddWithValue("@datetime", insertDateTime);
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Account created", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                con.connClose();

                return userInsert + passInsert + insertDateTime;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return null;
            }
            finally
            {
                con.connClose();
            }
        }

    }
}
