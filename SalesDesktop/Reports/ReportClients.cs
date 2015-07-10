using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDesktop
{
    public partial class ReportClients : Form
    {
        public ReportClients()
        {
            InitializeComponent();
        }

        private void aspnet_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aspnet_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aSPNETDB_DataSet);

        }

        private void ReportClients_Load(object sender, EventArgs e)
        {
            //load data into the 'aSPNETDB_DataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.aSPNETDB_DataSet.aspnet_Users);
        }

        private void ReportClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void btnChooseFillMethod_Click(object sender, EventArgs e)
        {
            if (btnChooseFillMethod.Text == "Risky clients")
            {
                try
                {
                    this.aspnet_UsersTableAdapter.RiskyCustomers(this.aSPNETDB_DataSet.aspnet_Users);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                btnChooseFillMethod.Text = "All clients";
            }
            else if (btnChooseFillMethod.Text == "All clients")
            {
                try
                {
                    this.aspnet_UsersTableAdapter.Fill(this.aSPNETDB_DataSet.aspnet_Users);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                btnChooseFillMethod.Text = "Risky clients";
            }
        }
    }
}
