<%@ Page Title="Order sent" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="OrderSent.aspx.cs" Inherits="SalesWeb.OrderSent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/order.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Your order has successfully been sent for administrator confirmation!"></asp:Label><br />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Continue shopping?</asp:LinkButton><br />
    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Return to main page?</asp:LinkButton>
</asp:Content>
