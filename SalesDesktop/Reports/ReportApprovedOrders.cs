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
    public partial class ReportApprovedOrders : Form
    {
        public ReportApprovedOrders()
        {
            InitializeComponent();
        }

        private void approvedOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.approvedOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aSPNETDB_MDFDataSet1);
        }

        private void ReportApprovedOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSPNETDB_MDFDataSet1.ApprovedOrders' table. You can move, or remove it, as needed.
            this.approvedOrdersTableAdapter.Fill(this.aSPNETDB_MDFDataSet1.ApprovedOrders);
            if (approvedOrdersDataGridView.Rows.Count == 0)
            {
                approvedOrdersDataGridView.Visible = false;
                lblHelp.Visible = true;
                lblHelp.Text = "There are no approved orders at the moment!";
            }
        }

        private void ReportApprovedOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }
    }
}
