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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        SelectItem slct = new SelectItem();

        public Login()
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
            Register rgtr = new Register();
            rgtr.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length < 3 || txtPass.Text.Length < 3)
                MessageBox.Show("Username or password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);     
            slct.SelectData(txtUser.Text, txtPass.Text);
        }
    }
}
