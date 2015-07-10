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
    public partial class ReportShippers : Form
    {
        public ReportShippers()
        {
            InitializeComponent();
        }

        private void ReportShippers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSPNETDB_DataSet.View_Shippers' table. You can move, or remove it, as needed.
            this.view_ShippersTableAdapter.Fill(this.aSPNETDB_DataSet.View_Shippers);

        }

        private void ReportShippers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }
    }
}
