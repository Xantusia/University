using System.Security.Principal;
using System.Security.Authentication;
using System.Security.Permissions;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.IO;

namespace Lab1_2
{
    class Identity
    {
        string login, password;
        public void Login_write(string in_login)
        { login = in_login; }
        public void password_write(string in_password)
        { password = in_password; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsolatedStorageFile userStore =
            IsolatedStorageFile.GetUserStoreForAssembly();

            Application.DoEvents();
        }   
            [PrincipalPermission(SecurityAction.Demand, Role = "BUILTIN\\Users")]

        

        private void Button1_Click(object sender, EventArgs e)
        {
            Identity.Login_write(&textBox1.Text);
            Identity.password = textBox3.Text;


        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
