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
    public partial class ReportGroups : Form
    {
        public ReportGroups()
        {
            InitializeComponent();
        }

        private void ReportGroups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSPNETDB_DataSet.View_CustGroups' table. You can move, or remove it, as needed.
            this.view_CustGroupsTableAdapter.Fill(this.aSPNETDB_DataSet.View_CustGroups);

        }

        private void ReportGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }
    }
}
