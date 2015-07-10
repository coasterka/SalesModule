using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (val1)
            {
                lblWelcome.Visible = true;
                string userName = Membership.GetUser().ToString();
                string currentTime = DateTime.Now.ToString("dd.MM.yyyy г., HH:mm:ss ч.");
                string browserName = Request.Browser.Browser.ToString();
                string browserVersion = Request.Browser.Version.ToString();
                lblWelcome.Text = "Hello, ";
                lblWelcome.Text += userName + "! Welcome to Sales Module!<br />";
                lblWelcome.Text += "Current date and  time: " + currentTime + "<br />";
                lblWelcome.Text += "Your browser is " + browserName + ", v. " + browserVersion + "<br />";
            }
        }

        protected void linkBtnForgotPass_Click(object sender, EventArgs e)
        {
            PasswordRecovery passRec = (PasswordRecovery)loginViewIndex.FindControl("PasswordRecovery1");
            passRec.Visible = true;
        }

        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {
            PasswordRecovery passRec = (PasswordRecovery)loginViewIndex.FindControl("PasswordRecovery1");
            passRec.Visible = false;
        }

        protected void linkBtnChPass_Click(object sender, EventArgs e)
        {
            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword1");
            chPass.Visible = true;
        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {
            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword1");
            chPass.Visible = false;
        }

        protected void ChangePassword1_CancelButtonClick(object sender, EventArgs e)
        {
            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword1");
            chPass.Visible = false;
        }

        protected void linkBtnChPass_Click1(object sender, EventArgs e)
        {
            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword2");
            chPass.Visible = true;

            CreateUserWizard createUserW = (CreateUserWizard)loginViewIndex.FindControl("CreateUserWizard1");
            createUserW.Visible = false;
        }

        protected void linkBtnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserWizard createUserW = (CreateUserWizard)loginViewIndex.FindControl("CreateUserWizard1");
            createUserW.Visible = true;

            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword2");
            chPass.Visible = false;
        }

        protected void ChangePassword2_ChangedPassword(object sender, EventArgs e)
        {
            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword2");
            chPass.Visible = false;
        }

        protected void ChangePassword2_CancelButtonClick(object sender, EventArgs e)
        {
            ChangePassword chPass = (ChangePassword)loginViewIndex.FindControl("ChangePassword2");
            chPass.Visible = false;
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            CreateUserWizard cuw = (CreateUserWizard)loginViewIndex.FindControl("CreateUserWizard1");
            Roles.AddUserToRole(cuw.UserName, "User");

            CreateUserWizard createUserW = (CreateUserWizard)loginViewIndex.FindControl("CreateUserWizard1");
            createUserW.Visible = false;
        }
    }
}