using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesWeb
{
    public partial class UserDetails : System.Web.UI.Page
    {
        //public Details detailsPage;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString();
            SqlConnection sqlConn = new SqlConnection(connStr);

            using (sqlConn)
            {
                //insert user details in dbo.Orders

                SqlCommand command = new SqlCommand("insert_order_2", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "insert_order_2";

                SqlParameter shipperId = new SqlParameter("@ShipperID", SqlDbType.UniqueIdentifier);
                shipperId.Value = Guid.Parse(dropDownShipper.SelectedValue.ToString());
                command.Parameters.Add(shipperId);

                SqlParameter paymentTypeId = new SqlParameter("@PaymentTypeID", SqlDbType.UniqueIdentifier);
                paymentTypeId.Value = Guid.Parse(dropDownPaymentType.SelectedValue.ToString());
                command.Parameters.Add(paymentTypeId);

                SqlParameter shipperName = new SqlParameter("@ShipperName", SqlDbType.NVarChar);
                shipperName.Value = dropDownShipper.SelectedItem.Text;
                command.Parameters.Add(shipperName);

                SqlParameter paymentTypeName = new SqlParameter("@PaymentTypeName", SqlDbType.NVarChar);
                paymentTypeName.Value = dropDownPaymentType.SelectedItem.Text;
                command.Parameters.Add(paymentTypeName);

                SqlParameter custEmail = new SqlParameter("@CustEmail", SqlDbType.NVarChar);
                custEmail.Value = txtBoxCustEmail.Text.ToString();
                command.Parameters.Add(custEmail);

                SqlParameter deliveryNotes = new SqlParameter("@DeliveryNotes", SqlDbType.NVarChar);
                deliveryNotes.Value = txtBoxDeliveryNotes.Text.ToString();
                command.Parameters.Add(deliveryNotes);

                SqlParameter custId = new SqlParameter("@CustID", SqlDbType.UniqueIdentifier);
                custId.Value = Guid.Parse(Membership.GetUser().ProviderUserKey.ToString());
                command.Parameters.Add(custId);

                //insert user details in dbo.aspnet_Users

                SqlCommand commandUsers = new SqlCommand("insert_user_info", sqlConn);
                commandUsers.CommandType = CommandType.StoredProcedure;
                commandUsers.CommandText = "insert_user_info";

                try
                {
                    sqlConn.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error!", "alert('" + se.Message.ToString() + "')", true);
                }
                SqlDataSource3.DeleteParameters["CustID"].DefaultValue = Membership.GetUser().ProviderUserKey.ToString();
                SqlDataSource3.Delete();

                SqlParameter CustFName = new SqlParameter("@CustFName", SqlDbType.NVarChar);
                CustFName.Value = txtBoxCustFName.Text.ToString();
                commandUsers.Parameters.Add(CustFName);

                SqlParameter CustLName = new SqlParameter("@CustLName", SqlDbType.NVarChar);
                CustLName.Value = txtBoxCustLName.Text.ToString();
                commandUsers.Parameters.Add(CustLName);

                SqlParameter CustPhone = new SqlParameter("@CustPhone", SqlDbType.NVarChar);
                CustPhone.Value = txtBoxCustPhone.Text.ToString();
                commandUsers.Parameters.Add(CustPhone);

                SqlParameter CustCity = new SqlParameter("@CustCity", SqlDbType.NVarChar);
                CustCity.Value = txtBoxCustCity.Text.ToString();
                commandUsers.Parameters.Add(CustCity);

                SqlParameter CustEmail = new SqlParameter("@CustEmail", SqlDbType.NVarChar);
                CustEmail.Value = txtBoxCustEmail.Text.ToString();
                commandUsers.Parameters.Add(CustEmail);

                SqlParameter CustAddress = new SqlParameter("@CustAddress", SqlDbType.NVarChar);
                CustAddress.Value = txtBoxCustAddress.Text.ToString();
                commandUsers.Parameters.Add(CustAddress);

                SqlParameter UserId = new SqlParameter("@CustID", SqlDbType.UniqueIdentifier);
                UserId.Value = Guid.Parse(Membership.GetUser().ProviderUserKey.ToString());
                commandUsers.Parameters.Add(UserId);

                try
                {
                    commandUsers.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error!", "alert('" + se.Message.ToString() + "')", true);
                }

                SqlCommand commandDebt = new SqlCommand("set_debt_amount", sqlConn);
                commandUsers.CommandType = CommandType.StoredProcedure;
                commandUsers.CommandText = "set_debt_amount";

                try
                {
                    commandDebt.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error!", "alert('" + se.Message.ToString() + "')", true);
                }
                sqlConn.Close();
            }

            Response.Redirect("OrderSent.aspx");
        }
    }
}