using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Reports;

namespace SalesDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
            CenterToParent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string exitMessage = "Are you sure you want to exit the application?";
            string exitCaption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(exitMessage, exitCaption, buttons, icon);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutFrm = new About();
            aboutFrm.ShowDialog();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.IsMdiContainer != true)
                {
                    form.Close();
                }
            }
        }

        private void searchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchOrder searchOrderFrm = new SearchOrder();
            searchOrderFrm.MdiParent = this;
            searchOrderFrm.WindowState = FormWindowState.Maximized;
            searchOrderFrm.Show();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProduct searchProductFrm = new SearchProduct();
            searchProductFrm.MdiParent = this;
            searchProductFrm.WindowState = FormWindowState.Maximized;
            searchProductFrm.Show();
        }

        private void searchClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClient searchClientFrm = new SearchClient();
            searchClientFrm.MdiParent = this;
            searchClientFrm.WindowState = FormWindowState.Maximized;
            searchClientFrm.Show();
        }

        private void searchGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchGroup searchGroupFrm = new SearchGroup();
            searchGroupFrm.MdiParent = this;
            searchGroupFrm.WindowState = FormWindowState.Maximized;
            searchGroupFrm.Show();
        }

        private void searchPaymentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPaymentType searchPaymentFrm = new SearchPaymentType();
            searchPaymentFrm.MdiParent = this;
            searchPaymentFrm.WindowState = FormWindowState.Maximized;
            searchPaymentFrm.Show();
        }

        private void searchShipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchShipper searchShipperFrm = new SearchShipper();
            searchShipperFrm.MdiParent = this;
            searchShipperFrm.WindowState = FormWindowState.Maximized;
            searchShipperFrm.Show();
        }

        private void clientsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportClients clientsReportFrm = new ReportClients();
            clientsReportFrm.MdiParent = this;
            clientsReportFrm.WindowState = FormWindowState.Maximized;
            clientsReportFrm.Show();
        }

        private void productsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProducts productsReportFrm = new ReportProducts();
            productsReportFrm.MdiParent = this;
            productsReportFrm.WindowState = FormWindowState.Maximized;
            productsReportFrm.Show();
        }

        private void groupsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGroups groupsReportFrm = new ReportGroups();
            groupsReportFrm.MdiParent = this;
            groupsReportFrm.WindowState = FormWindowState.Maximized;
            groupsReportFrm.Show();
        }

        private void paymentTypesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportPaymentTypes paymentTypesReportFrm = new ReportPaymentTypes();
            paymentTypesReportFrm.MdiParent = this;
            paymentTypesReportFrm.WindowState = FormWindowState.Maximized;
            paymentTypesReportFrm.Show();
        }

        private void shippersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportShippers shippersReportFrm = new ReportShippers();
            shippersReportFrm.MdiParent = this;
            shippersReportFrm.WindowState = FormWindowState.Maximized;
            shippersReportFrm.Show();
        }

        private void waitingOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOrders ordersReportFrm = new ReportOrders();
            ordersReportFrm.MdiParent = this;
            ordersReportFrm.WindowState = FormWindowState.Maximized;
            ordersReportFrm.Show();
        }

        private void approvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportApprovedOrders approvedOrdFrm = new ReportApprovedOrders();
            approvedOrdFrm.MdiParent = this;
            approvedOrdFrm.WindowState = FormWindowState.Maximized;
            approvedOrdFrm.Show();
        }

        private void rejectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportRejectedOrders rejectedOrdFrm = new ReportRejectedOrders();
            rejectedOrdFrm.MdiParent = this;
            rejectedOrdFrm.WindowState = FormWindowState.Maximized;
            rejectedOrdFrm.Show();
        }
    }
}
