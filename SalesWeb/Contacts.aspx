<%@ Page Title="Contacts" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="SalesWeb.Contacts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/contacts.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Developer:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Hristina Tsvetanova"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Degree:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Business Informatics 2015, UNWE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Fac. №:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="118006"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Group:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="1708"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Stream"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="177"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Date:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Wanna contact me?"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="tsvetanovah@gmail.com"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
