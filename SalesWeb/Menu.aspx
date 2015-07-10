<%@ Page Title="Products" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SalesWeb.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/menu.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="leftColumn">
        <asp:Label ID="Label1" runat="server" Text="Categories"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" ShowHeader="False">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("ProdType") %>' OnClick="LinkButton1_Click1"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT DISTINCT [ProdType] FROM [Products]">
        </asp:SqlDataSource>
    </div>
    <div id="rightColumn">
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource3" RepeatColumns="3" RepeatDirection="Horizontal" ShowFooter="False" ShowHeader="False" BorderColor="Maroon" BorderWidth="0px" CellPadding="10" CellSpacing="10">
            <ItemStyle BackColor="#E3E1E3" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "./images/furnitureImages/" + Session["Category"] + "/" + Eval("ProdName") + ".jpg" %>' />
                <br />
                <div id="prodDetails">
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Name: "></asp:Label>
                    <asp:Label ID="ProdNameLabel" runat="server" Text='<%# Eval("ProdName") %>' />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Brand: "></asp:Label>
                    <asp:Label ID="ProdBrandLabel" runat="server" Text='<%# Eval("ProdBrand") %>' />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Price: "></asp:Label>
                    $<asp:Label ID="ProdPriceLabel" runat="server" Text='<%# Eval("ProdPrice", "{0:N2}") %>' />
                    <br />
                    Available:
                    <asp:Label ID="ProdAvailableLabel" runat="server" Text='<%# Eval("ProdQty") %>'></asp:Label>
                    <br />
                    <asp:LinkButton ID="linkBtnDetails" Text='<%# Eval("ProdName") %>' runat="server" OnClick="linkBtnDetails_Click"></asp:LinkButton>
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Server=.\SQLEXPRESS;Database=ASPNETDB.MDF;User=sa;Password=1234;" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ProdID], [ProdType], [ProdName], [ProdBrand], [ProdPrice], [ProdQty] FROM [Products] WHERE ([ProdType] = @ProdType)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="" Name="ProdType" QueryStringField="Category" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>
