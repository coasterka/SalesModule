using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.ClientServices.Providers;
using System.Web.Security;
using System.Windows.Forms;

namespace SalesDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string msg = "";
            if ((!Membership.ValidateUser(txtBoxUserName.Text, txtBoxPassword.Text)) || !Thread.CurrentPrincipal.IsInRole("Admin"))
            {
                msg = "Invalid Username or Password!";
                MessageBox.Show(msg);
                txtBoxUserName.Clear();
                txtBoxPassword.Clear();
            }
            else
            {
                msg = "Welcome, " + txtBoxUserName.Text + "! [Admin]";
                MessageBox.Show(msg);
                this.Hide();                
            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            Form form = (Form)Application.OpenForms["MainForm"];
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
