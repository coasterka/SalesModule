<%@ Page Title="" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="SalesWeb.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/userdetails.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblProdID" runat="server" Text="Label" Visible="false"></asp:Label>
    <fieldset id="userInfo">
        <legend>Fill in your details</legend>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="First name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxCustFName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBoxCustFName" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">First name is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Last name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxCustLName" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBoxCustLName" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">Last name is required!</asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Phone:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxCustPhone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtBoxCustPhone" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">Phone is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="City:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxCustCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBoxCustCity" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">City is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxCustEmail" runat="server" type="email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtBoxCustEmail" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">Email is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Address:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxCustAddress" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtBoxCustAddress" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">Address is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </fieldset>
    <fieldset id="orderInfo">
        <legend>Delivery details</legend>
        <table>
            <!--TODO: Databind the table 
                If the checkbox is checked - a new textbox appears
                Else the textbox is hidden -->
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Payment type:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dropDownPaymentType" runat="server" DataSourceID="SqlDataSource1" DataTextField="PaymentTypeName" DataValueField="PaymentTypeID"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [PaymentTypes]"></asp:SqlDataSource>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="dropDownPaymentType" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">Payment type is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Shipper:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dropDownShipper" runat="server" DataSourceID="SqlDataSource2" DataTextField="ShipperName" DataValueField="ShipperID"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Shippers]"></asp:SqlDataSource>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="dropDownShipper" ErrorMessage="RequiredFieldValidator" ValidationGroup="required">Shipper is required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Delivery notes:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoxDeliveryNotes" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
                </td>
            </tr>
        </table>
    </fieldset>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" DeleteCommand="DELETE FROM ShopCart WHERE [CustID] = @CustID" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ShopCart]">
        <DeleteParameters>
            <asp:Parameter Name="CustID" />
        </DeleteParameters>
    </asp:SqlDataSource>
    <asp:Button ID="btnConfirmOrder" runat="server" Text="Send for confirmation" OnClick="btnConfirmOrder_Click" ValidationGroup="required" />
</asp:Content>
