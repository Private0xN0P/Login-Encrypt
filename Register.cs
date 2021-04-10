using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginEncrpyt
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        insertData insrtd = new insertData();
        Connection con = new Connection();
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (txtUser.Text.Length < 3 || txtPass.Text.Length < 3)
                MessageBox.Show("Username or password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            insrtd.InsertData(txtUser.Text, txtPass.Text, fecha);

        }
    }
}
