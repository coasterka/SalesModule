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
    public partial class ReportProducts : Form
    {
        public ReportProducts()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aSPNETDB_DataSet);

        }

        private void ReportProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSPNETDB_DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.aSPNETDB_DataSet.Products);

        }

        private void ReportProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }
    }
}
