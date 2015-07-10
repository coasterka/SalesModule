using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesWeb
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            LinkButton linkBtn = (LinkButton)sender;
            Session["Category"] = linkBtn.Text;
            Response.Redirect("Menu.aspx?Category=" + Session["Category"]);

            //foreach (DataListItem dli in DataList1.Items)
            //{
            //    Label prodQtyLabel = (Label)dli.FindControl("ProdAvailableLabel");
            //    Label notAvailLabel = (Label)dli.FindControl("Label2");
            //    if (prodQtyLabel.Text == "0")
            //    {
            //        notAvailLabel.Text = "Item not available";
            //        notAvailLabel.Visible = true;
            //    }
            //}

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("Details.aspx");
        }

        protected void linkBtnDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("Details.aspx?ProdName=" + ((LinkButton)sender).Text);
        }
    }
 }