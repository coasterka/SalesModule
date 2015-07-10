<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControlDetails.ascx.cs" Inherits="SalesWeb.WebUserControlDetails" %>
<div>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Тип: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblProdType" runat="server" Text="[lblProdType]" meta:resourcekey="lblBookIDResource1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Име: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblProdName" runat="server" Text="[lblProdName]" meta:resourcekey="lblBookIDResource1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Марка: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblProdBrand" runat="server" Text="[lblProdBrand]" meta:resourcekey="lblBookIDResource1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Цена: "></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblProdPrice" runat="server" Text="[lblProdPrice]" meta:resourcekey="lblBookIDResource1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:LinkButton ID="linkBtnDetails" runat="server">Виж детайли</asp:LinkButton>
            </td>
        </tr>
    </table>
</div>