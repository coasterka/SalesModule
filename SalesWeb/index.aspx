<%@ Page Title="" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SalesWeb.Index" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link type="text/css" href="styles/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblWelcome" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:LoginView ID="loginViewIndex" runat="server">
        <AnonymousTemplate>
            <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" Visible="False" OnSendingMail="PasswordRecovery1_SendingMail">
            </asp:PasswordRecovery>
            <asp:Login ID="Login1" runat="server">
            </asp:Login>
            <asp:LinkButton ID="linkBtnForgotPass" runat="server" OnClick="linkBtnForgotPass_Click">Forgot your password?</asp:LinkButton>
        </AnonymousTemplate>
        <RoleGroups>
            <asp:RoleGroup Roles="Admin">
                <ContentTemplate>
                    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnCreatedUser="CreateUserWizard1_CreatedUser" Visible="False">
                        <WizardSteps>
                            <asp:CreateUserWizardStep runat="server" Title="Create a new user" />
                            <asp:CompleteWizardStep runat="server" />
                        </WizardSteps>
                    </asp:CreateUserWizard>
                    <asp:ChangePassword ID="ChangePassword2" runat="server" OnCancelButtonClick="ChangePassword2_CancelButtonClick" OnChangedPassword="ChangePassword2_ChangedPassword" Visible="False">
                    </asp:ChangePassword>
                    <div id="footer">
                        <span>Admin: <asp:LoginName ID="LoginName2" runat="server" /></span>
                        <asp:LinkButton ID="linkBtnChPass" runat="server" OnClick="linkBtnChPass_Click1">Change password</asp:LinkButton>
                        <asp:LinkButton ID="linkBtnCreateUser" runat="server" OnClick="linkBtnCreateUser_Click">Create user</asp:LinkButton>
                        <asp:LoginStatus ID="LoginStatus2" runat="server" />
                    </div>
                    </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="User">
                <ContentTemplate>
                    <asp:ChangePassword ID="ChangePassword1" runat="server" Visible="False" OnCancelButtonClick="ChangePassword1_CancelButtonClick" OnChangedPassword="ChangePassword1_ChangedPassword">
                    </asp:ChangePassword>
                    <div id="footer">
                        <span>User: <asp:LoginName ID="LoginName1" runat="server" /></span>
                        <asp:LinkButton ID="linkBtnChPass" runat="server" OnClick="linkBtnChPass_Click">Change password</asp:LinkButton>
                        <asp:LoginStatus ID="LoginStatus1" runat="server" />
                    </div>
                </ContentTemplate>
            </asp:RoleGroup>
        </RoleGroups>
    </asp:LoginView>
</asp:Content>
