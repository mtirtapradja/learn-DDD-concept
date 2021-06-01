<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="pertemuan_4.Views.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvTransactionHistory" runat="server"></asp:GridView>
    <asp:GridView ID="gvDetail" runat="server"></asp:GridView>
    <asp:LinkButton ID="linkHome" Text="Back to Home" OnClick="linkHome_Click" runat="server" />
</asp:Content>
