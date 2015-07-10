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
    public partial class Shopcart : System.Web.UI.Page
    {
        double totalOrderAmount;
        protected void Page_Load(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (!val1)
            {
                Session.Abandon();
                FormsAuthentication.SignOut();
                Response.Redirect("index.aspx");
            }
            if (!IsPostBack)
            {
                Session["UserName"] = Membership.GetUser().ToString();
                foreach (DataListItem dli in DataList1.Items)
                {
                    Label ProdPriceLabel = (Label)dli.FindControl("ProdPriceLabel");
                    Label QuantityLabel = (Label)dli.FindControl("QuantityLabel");
                    int qty = Convert.ToInt32(QuantityLabel.Text);
                    double price = Convert.ToDouble(ProdPriceLabel.Text);
                    double amount = qty * price;
                    totalOrderAmount += amount;
                }
            }
            lblTotalOrderAmount.Text = "Total order amount: $" + totalOrderAmount.ToString("0.00") + "<br />";
            
            if (DataList1.Items.Count == 0)
            {
                btnSendOrder.Visible = false;
                lblInfo.Visible = true;
                lblInfo.Text = "Your shopping cart is empty!<br />";
                btnDeleteSelected.Text = "Check out our products?";
            }
        }

        protected void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (btnDeleteSelected.Text == "Check out our products?")
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                foreach (DataListItem dli in DataList1.Items)
                {
                    CheckBox chkBox = (CheckBox)dli.FindControl("CheckBox1");
                    Label prodIDLabel = (Label)dli.FindControl("ProdIDLabel");
                    if (chkBox.Checked)
                    {
                        SqlDataSource1.DeleteParameters["ProdID"].DefaultValue = prodIDLabel.Text.ToString();
                        SqlDataSource1.DeleteParameters["CustID"].DefaultValue = Membership.GetUser().ProviderUserKey.ToString();
                        SqlDataSource1.Delete();
                    }
                }
                DataList1.DataBind();
                if (DataList1.Items.Count != 0)
                {
                        lblInfo.Visible = true;
                        lblInfo.Text = "The selected items have been successfully deleted!<br />";
                }
                else if (DataList1.Items.Count == 0)
                {
                    lblInfo.Visible = true;
                    lblInfo.Text = "Your shopping cart is empty!<br />";
                    btnDeleteSelected.Text = "Check out our products?";
                    btnSendOrder.Visible = false;
                }
            }
        }

        protected void btnSendOrder_Click(object sender, EventArgs e)
        {
            // stored procedure insert_order_1

            foreach (DataListItem dli in DataList1.Items)
            {
                //string connStr = @"Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;";
                string connStr = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString();
                SqlConnection sqlConn = new SqlConnection(connStr);
                Label CustIDLabel = (Label)dli.FindControl("CustIDLabel");
                Label ProdIDLabel = (Label)dli.FindControl("ProdIDLabel");
                Label ProdNameLabel = (Label)dli.FindControl("ProdNameLabel");
                Label ProdPriceLabel = (Label)dli.FindControl("ProdPriceLabel");
                Label QuantityLabel = (Label)dli.FindControl("QuantityLabel");
                Label OrderDateLabel = (Label)dli.FindControl("OrderDateLabel");
                Label UserNameLabel = (Label)dli.FindControl("UserNameLabel");

                using (sqlConn)
                {
                    SqlCommand command = new SqlCommand("insert_order_1", sqlConn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "insert_order_1";

                    SqlParameter custId = new SqlParameter("@CustID", SqlDbType.UniqueIdentifier);
                    custId.Value = Guid.Parse(Membership.GetUser().ProviderUserKey.ToString());
                    command.Parameters.Add(custId);

                    SqlParameter prodId = new SqlParameter("@ProdID", SqlDbType.UniqueIdentifier);
                    prodId.Value = Guid.Parse(ProdIDLabel.Text.ToString());
                    command.Parameters.Add(prodId);

                    SqlParameter prodName = new SqlParameter("@ProdName", SqlDbType.NVarChar);
                    prodName.Value = ProdNameLabel.Text.ToString();
                    command.Parameters.Add(prodName);

                    SqlParameter prodPrice = new SqlParameter("@ProdPrice", SqlDbType.Money);
                    prodPrice.Value = ProdPriceLabel.Text.ToString();
                    command.Parameters.Add(prodPrice);

                    SqlParameter qty = new SqlParameter("@Quantity", SqlDbType.Int);
                    qty.Value = QuantityLabel.Text.ToString();
                    command.Parameters.Add(qty);

                    SqlParameter orderDate = new SqlParameter("@OrderDate", SqlDbType.Date);
                    orderDate.Value = DateTime.Today.ToString();
                    command.Parameters.Add(orderDate);

                    SqlParameter userName = new SqlParameter("@UserName", SqlDbType.NVarChar);
                    userName.Value = Membership.GetUser().ToString();
                    command.Parameters.Add(userName);

                    SqlParameter orderAmount = new SqlParameter("@OrderAmount", SqlDbType.Money);
                    orderAmount.Value = (Convert.ToDouble(prodPrice.Value)) * (Convert.ToInt32(qty.Value));
                    command.Parameters.Add(orderAmount);

                    try
                    {
                        sqlConn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException se)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error!",
                            "alert('" + se.Message.ToString() + "')", true);
                    }
                }
            }
            Response.Redirect("UserDetails.aspx");
        }
    }
}