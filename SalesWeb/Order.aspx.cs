using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesWeb
{
    public partial class Order : System.Web.UI.Page
    {
        public Details detailsPage;

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
                // create a Details object in order to use the created properties
                Details detailsPage = (Details) Context.Handler;

                // get the stored values of each product specification

                lblProdID.Text = detailsPage.ProdID;
                lblProdName.Text = detailsPage.ProdName;
                lblProdType.Text = detailsPage.ProdType;
                lblProdPrice.Text = detailsPage.ProdPrice;
                lblQuantity.Text = detailsPage.Quantity;

                double prodPriceInt = Convert.ToDouble(lblProdPrice.Text);
                int quantityInt = Convert.ToInt32(lblQuantity.Text);
                double orderSum = prodPriceInt * quantityInt;

                lblOrderSum.Text = "$" + orderSum.ToString("0.00");
            }
        }

        protected void btnSendOrder_Click(object sender, EventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Готово!", "alert('Вашата поръчка бе изпратена успешно за одобрение от администратор!')", true);
            Response.Redirect("OrderSent.aspx");
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnGoToCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Shopcart.aspx");
        }
    }
}