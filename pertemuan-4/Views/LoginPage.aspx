<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="pertemuan_4.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login Page</h2>
    <div>
        <asp:Label ID="lblUsername" Text="Username" runat="server" />
        <asp:TextBox ID="txtUsername" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblPassword" Text="Password" runat="server" />
        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" Text="" ForeColor="Red" runat="server" />
        <br />
        <asp:Button ID="btnLogin" Text="Login" OnClick="btnLogin_Click" runat="server" />
        <br />
        <asp:LinkButton ID="linkRegister" Text="New here? Click here to Register" OnClick="linkRegister_Click" runat="server" />
    </div>
</asp:Content>
