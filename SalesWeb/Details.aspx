<%@ Page Title="Details" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="SalesWeb.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/details.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="ProdID" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <div id="prodImg">
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "./images/furnitureImages/" + Session["Category"] + "/" + Eval("ProdName") + ".jpg" %>' />
            </div>
            <div id="productInfo">
                <asp:Label ID="ProdIDLabel" runat="server" Text='<%# Eval("ProdID") %>' Visible="False" />
                <br />
                <label class="label">Type: </label> <asp:Label ID="ProdTypeLabel" runat="server" Text='<%# Bind("ProdType") %>' />
                <br />
                <label class="label">Name: </label>
                <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Bind("ProdName") %>' />
                <br />
                <label class="label">Brand: </label>
                <asp:Label ID="ProdBrandLabel" runat="server" Text='<%# Bind("ProdBrand") %>' />
                <br />
                <label class="label">Description: </label>
                <asp:Label ID="ProdDescriptionLabel" runat="server" Text='<%# Bind("ProdDescription") %>' />
                <br />
                <label class="label">Price: </label>
                $<asp:Label ID="ProdPriceLabel" runat="server" Text='<%# Bind("ProdPrice", "{0:N2}") %>' />
                <br />
                <label class="label">Available: </label>
                <asp:Label ID="ProdAvailLable" runat="server" Text='<%# Bind("ProdQty") %>'></asp:Label>
                <br />
                <label class="label">Quantity: </label>
                <asp:TextBox ID="txtBoxqty" type="number" min="1" max="10" runat="server"></asp:TextBox>
                <asp:Button ID="btnOrder" runat="server" Text="Add to cart" OnClick="btnOrder_Click" />
            </div>
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ProdID], [ProdType], [ProdName], [ProdBrand], [ProdDescription], [ProdPrice], [ProdQty] FROM [Products] WHERE ([ProdName] = @ProdName)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProdName" QueryStringField="ProdName" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
