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
    public partial class SearchClient : Form
    {
        public SearchClient()
        {
            InitializeComponent();
        }

        private void btnCancelSearchClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CloseForm(this, e);
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            SqlConnection con = Program.CreateConnection();
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                if (txtBoxUserID.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE UserId LIKE '%" + txtBoxUserID.Text + "%' ", con);
                    txtBoxUserID.Clear();
                }
                else if (txtBoxUsername.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE UserName LIKE '%" + txtBoxUsername.Text + "%' ", con);
                    txtBoxUsername.Clear();
                }
                else if (txtBoxFirstName.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE CustFName LIKE '%" + txtBoxFirstName.Text + "%' ", con);
                    txtBoxFirstName.Clear();
                }
                else if (txtBoxLastName.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE CustLName LIKE '%" + txtBoxLastName.Text + "%' ", con);
                    txtBoxLastName.Clear();
                }
                else if (txtBoxCity.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE CustCity LIKE '%" + txtBoxCity.Text + "%' ", con);
                    txtBoxCity.Clear();
                }
                else if (txtBoxEmail.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE CustEmail LIKE '%" + txtBoxEmail.Text + "%' ", con);
                    txtBoxEmail.Clear();
                }
                else if (txtBoxAddress.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE CustAddress LIKE '%" + txtBoxAddress.Text + "%' ", con);
                    txtBoxAddress.Clear();
                }
                else if (txtBoxHasDebt.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE HasDebt LIKE '" + txtBoxHasDebt.Text + "%' ", con);
                    txtBoxHasDebt.Clear();
                }
                else if (txtBoxDebtAmount.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE DebtAmount LIKE '%" + txtBoxDebtAmount.Text + "%' ", con);
                    txtBoxDebtAmount.Clear();
                }
                else if (txtBoxIsRisky.Text != "")
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users WHERE isRisky LIKE '" + txtBoxIsRisky.Text + "%' ", con);
                    txtBoxIsRisky.Clear();
                }
                else
                {
                    sda = new SqlDataAdapter("SELECT UserId, UserName, CustFName, CustLName, CustCity, CustEmail, CustAddress, HasDebt, DebtAmount, isRisky FROM aspnet_Users", con);
                }
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSearchClient.DataSource = dt;
            }
        }
    }
}
