<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="pertemuan_4.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home Page</h2>
    <div>
        <asp:Label ID="lblWelcome" Text="" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" Text="" ForeColor="Red" runat="server" />
        <br />
        <asp:Button ID="btnLogout" Text="Logout" OnClick="btnLogout_Click" runat="server" />
        <asp:Button ID="btnManageProduct" Text="Manage Product" OnClick="btnManageProduct_Click" runat="server" />
        <asp:Button ID="btnOrderProduct" Text="Order Product" OnClick="btnOrderProduct_Click" runat="server" />
    </div>
</asp:Content>
