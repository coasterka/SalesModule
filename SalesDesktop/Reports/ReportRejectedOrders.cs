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
    public partial class ReportRejectedOrders : Form
    {
        public ReportRejectedOrders()
        {
            InitializeComponent();
        }

        private void rejectedOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rejectedOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aSPNETDB_MDFDataSet1);

        }

        private void ReportRejectedOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSPNETDB_MDFDataSet1.RejectedOrders' table. You can move, or remove it, as needed.
            this.rejectedOrdersTableAdapter.Fill(this.aSPNETDB_MDFDataSet1.RejectedOrders);
            if (rejectedOrdersDataGridView.Rows.Count == 0)
            {
                rejectedOrdersDataGridView.Visible = false;
                lblHelp.Visible = true;
                lblHelp.Text = "There are no rejected orders at the moment!";
            }
        }

        private void ReportRejectedOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }
    }
}
