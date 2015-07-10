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
using Microsoft.AspNet.Identity;

namespace SalesWeb
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (!val1)
            {
                Session.Abandon();
                FormsAuthentication.SignOut();
                Response.Redirect("index.aspx");
            }

            Label ProdAvailLable = (Label)FormView1.FindControl("ProdAvailLable");
            TextBox txtBoxqty = (TextBox)FormView1.FindControl("txtBoxqty");
            Button btnOrder = (Button)FormView1.FindControl("btnOrder");
            if (ProdAvailLable.Text == "0")
            {
                txtBoxqty.ReadOnly = true;
                btnOrder.Enabled = false;
            }

        }

        public string ProdID
        {
            get
            {
                return ((Label)FormView1.FindControl("ProdIDLabel")).Text;
            }
        }

        public string ProdType
        {
            get
            {
                return ((Label)FormView1.FindControl("ProdTypeLabel")).Text;
            }
        }

        public string ProdName
        {
            get
            {
                return ((Label)FormView1.FindControl("ProdNameLabel")).Text;
            }
        }

        public string ProdPrice
        {
            get
            {
                return ((Label)FormView1.FindControl("ProdPriceLabel")).Text;
            }
        }

        public string Quantity
        {
            get
            {
                return ((TextBox)FormView1.FindControl("txtBoxqty")).Text;
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString();
            SqlConnection sqlConn = new SqlConnection(connStr);
            Label ProdIDLabel = (Label)FormView1.FindControl("ProdIDLabel");
            Label ProdNameLabel = (Label)FormView1.FindControl("ProdNameLabel");
            Label ProdPriceLabel = (Label)FormView1.FindControl("ProdPriceLabel");
            TextBox txtBoxqty = (TextBox)FormView1.FindControl("txtBoxqty");

            using (sqlConn)
            {
                // stored procedure insert_shopcart

                SqlCommand command = new SqlCommand("insert_shopcart", sqlConn);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "insert_shopcart";

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
                qty.Value = txtBoxqty.Text.ToString();
                command.Parameters.Add(qty);

                SqlParameter orderDate = new SqlParameter("@OrderDate", SqlDbType.Date);
                orderDate.Value = DateTime.Today.ToString();
                command.Parameters.Add(orderDate);

                SqlParameter userName = new SqlParameter("@UserName", SqlDbType.NVarChar);
                userName.Value = Membership.GetUser().ToString();
                command.Parameters.Add(userName);

                try
                {
                    sqlConn.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error!", "alert('" + se.Message.ToString() +"')", true);
                }
                Server.Transfer("Order.aspx");
            }
        }        
    }
}