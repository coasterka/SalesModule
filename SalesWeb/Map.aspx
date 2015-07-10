<%@ Page Title="Sitemap" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="SalesWeb.Map" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/sitemap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1"></asp:Menu>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="False" />
</asp:Content>
