using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDesktop
{
    public partial class SearchShipper : Form
    {
        public SearchShipper()
        {
            InitializeComponent();
        }

        private void btnCancelSearchShipper_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchShipper_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void btnSearchShipper_Click(object sender, EventArgs e)
        {
            SqlConnection con = Program.CreateConnection();
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                if (txtBoxShipperID.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ShipperID, ShipperName, HasTax, TaxPercent FROM Shippers WHERE ShipperID LIKE '%" + txtBoxShipperID.Text + "%' ", con);
                    txtBoxShipperID.Clear();
                }
                else if (txtBoxShipperName.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ShipperID, ShipperName, HasTax, TaxPercent FROM Shippers WHERE ShipperName LIKE '%" + txtBoxShipperName.Text + "%' ", con);
                    txtBoxShipperName.Clear();
                }
                else if (txtBoxHasTax.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ShipperID, ShipperName, HasTax, TaxPercent FROM Shippers WHERE HasTax LIKE '" + txtBoxHasTax.Text + "%' ", con);
                    txtBoxHasTax.Clear();
                }
                else if (txtBoxTaxPercent.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT ShipperID, ShipperName, HasTax, TaxPercent FROM Shippers WHERE TaxPercent LIKE '%" + txtBoxTaxPercent.Text + "%' ", con);
                    txtBoxTaxPercent.Clear();
                }
                else
                {
                    sda = new SqlDataAdapter("SELECT ShipperID, ShipperName, HasTax, TaxPercent FROM Shippers", con);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSearchShipper.DataSource = dt;
            }
        }
    }
}
