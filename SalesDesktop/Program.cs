using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDesktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ASPNETDB.MDF;Persist Security Info=True;User ID=sa;Password=1234";
            return conn;
        }

        public static DialogResult CloseForm(Form frm, FormClosingEventArgs fcea)
        {
            string exitMessage = "Are you sure you want to close the " + frm.Text + " form?";
            string exitCaption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult res = MessageBox.Show(exitMessage, exitCaption, buttons, icon);
            if (res == DialogResult.No)
            {
                fcea.Cancel = true;
            }
            return res;
        }
    }
}