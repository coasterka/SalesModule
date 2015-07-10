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
    public partial class ReportOrders : Form
    {
        public static int CurrentOrderID;
        public ReportOrders()
        {
            InitializeComponent();
        }

        private void ReportOrders_Load(object sender, EventArgs e)
        {
            // load data into the 'view_Order_Details_DataSet.View_Order_Details' table. You can move, or remove it, as needed.
            this.view_Order_DetailsTableAdapter1.Fill(this.view_Order_Details_DataSet.View_Order_Details);
            // load data into the 'aSPNETDB_DataSet.View_Order_Details' table. You can move, or remove it, as needed.
            this.view_Order_DetailsTableAdapter.Fill(this.aSPNETDB_DataSet.View_Order_Details);

            if (view_Order_DetailsDataGridView.Rows.Count == 0)
            {
                view_Order_DetailsDataGridView.Visible = false;
                lblHelp.Text = "There are no waiting orders at the moment!";
            }
        }

        private void ReportOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void view_Order_DetailsDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CurrentOrderID = Convert.ToInt16(view_Order_DetailsDataGridView.SelectedRows[0].Cells[0].Value);
            ManageOrder manageOrderFrm = new ManageOrder();
            manageOrderFrm.Owner = this;
            manageOrderFrm.ShowDialog();
        }
    }
}
