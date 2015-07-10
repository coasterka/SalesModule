<%@ Page Title="Order" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="SalesWeb.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/order.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label6" runat="server" Text="The product has been successfully added!"></asp:Label>
    <fieldset id="orderInfo">
        <legend>Order details</legend>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Product name:" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblProdName" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Product type:" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblProdType" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Single price:" CssClass="label"></asp:Label>
                </td>
                <td>
                    $<asp:Label ID="lblProdPrice" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Quantity:" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblQuantity" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Order amount:" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblOrderSum" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblProdID" runat="server" Text="Label" Visible="false"></asp:Label>
    </fieldset>
    <asp:Button ID="btnGoToCheckout" runat="server" Text="Go to checkout" OnClick="btnGoToCheckout_Click" />
    <asp:Button ID="btnContinueShopping" runat="server" Text="Continue shopping?" OnClick="btnContinueShopping_Click" />
</asp:Content>
