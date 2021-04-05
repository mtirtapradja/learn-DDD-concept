<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="pertemuan_4.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Register Page</h2>
    <div>
        <asp:Label ID="lblUsername" Text="Username" runat="server" />
        <asp:TextBox ID="txtUsername" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblPassword" Text="Password" runat="server" />
        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblConfirm" Text="Confirm Password" runat="server" />
        <asp:TextBox ID="txtConfirm" TextMode="Password" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblDOB" Text="DOB" runat="server" />
        <asp:ScriptManager ID="scriptManager1" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Calendar ID="calendarDOB" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <div>
        <asp:Label ID="lblError" Text="" ForeColor="Red" runat="server" />
        <br />
        <asp:Button ID="btnRegister" Text="Register" OnClick="btnRegister_Click" runat="server" />
        <br />
        <asp:LinkButton ID="linkLogin" Text="Already has an account? Click here to login" OnClick="linkLogin_Click" runat="server" />
    </div>
</asp:Content>
