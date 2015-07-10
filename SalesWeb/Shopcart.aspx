<%@ Page Title="Shopcart" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Shopcart.aspx.cs" Inherits="SalesWeb.Shopcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/shopcart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="CustID" DataSourceID="SqlDataSource1" BackColor="#E8E8E8" BorderColor="#990000" BorderWidth="2px" CellPadding="10" CellSpacing="10" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" RepeatDirection="Horizontal" ShowFooter="False" ShowHeader="False">
        <ItemStyle BackColor="White" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
        <ItemTemplate>
            <asp:Label ID="CustIDLabel" runat="server" Text='<%# Eval("CustID") %>' Visible="False" />
            <asp:Label ID="ProdIDLabel" runat="server" Text='<%# Eval("ProdID") %>' Visible="False" />
            Product name: 
            <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' />
            <br />
            Product price: 
            $<asp:Label ID="ProdPriceLabel" runat="server" Text='<%# Eval("ProdPrice", "{0:N2}") %>' />
            <br />
            Quantity:
            <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
            <br />
            <asp:Label ID="OrderDateLabel" runat="server" Text='<%# Eval("OrderDate") %>' Visible="False" />
            <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' Visible="False" />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Delete this item" Font-Italic="True" />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ShopCart] WHERE ([UserName] = @UserName)" DeleteCommand="DELETE FROM ShopCart WHERE [ProdID] = @ProdID AND [CustID] = @CustID">
        <DeleteParameters>
            <asp:Parameter Name="ProdID" />
            <asp:Parameter Name="CustID" />
        </DeleteParameters>
        <SelectParameters>
            <asp:SessionParameter Name="UserName" SessionField="UserName" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:Label ID="lblTotalOrderAmount" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="lblInfo" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:Button ID="btnDeleteSelected" runat="server" Text="Delete selected items" OnClick="btnDeleteSelected_Click" />
    <asp:Button ID="btnSendOrder" runat="server" Text="Send order" OnClick="btnSendOrder_Click" />
</asp:Content>
