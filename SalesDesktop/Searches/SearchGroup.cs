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
    public partial class SearchGroup : Form
    {
        public SearchGroup()
        {
            InitializeComponent();
        }

        private void btnCancelSearchGroup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }        

        private void btnSearchGroup_Click(object sender, EventArgs e)
        {
            SqlConnection con = Program.CreateConnection();
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                if (txtBoxGroupID.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT GroupID, GroupName, HasDiscount, DiscountPercent FROM CustGroups WHERE GroupID LIKE '%" + txtBoxGroupID.Text + "%' ", con);
                    txtBoxGroupID.Clear();
                }
                else if (txtBoxGroupName.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT GroupID, GroupName, HasDiscount, DiscountPercent FROM CustGroups WHERE GroupName LIKE '%" + txtBoxGroupName.Text + "%' ", con);
                    txtBoxGroupName.Clear();
                }
                else if (txtBoxHasDiscount.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT GroupID, GroupName, HasDiscount, DiscountPercent FROM CustGroups WHERE HasDiscount LIKE '" + txtBoxHasDiscount.Text + "%' ", con);
                    txtBoxHasDiscount.Clear();
                }
                else if (txtBoxDiscountPercent.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT GroupID, GroupName, HasDiscount, DiscountPercent FROM CustGroups WHERE DiscountPercent LIKE '%" + txtBoxDiscountPercent.Text + "%' ", con);
                    txtBoxDiscountPercent.Clear();
                }
                else
                {
                    sda = new SqlDataAdapter("SELECT GroupID, GroupName, HasDiscount, DiscountPercent FROM CustGroups", con);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSearchGroup.DataSource = dt;
            }
        }
    }
}
