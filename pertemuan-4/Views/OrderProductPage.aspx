<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="OrderProductPage.aspx.cs" Inherits="pertemuan_4.Views.OrdcerProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Products</h3>
    <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
    <h3>Cart</h3>
    <asp:GridView ID="gvCart" runat="server"></asp:GridView>
    <div>
        <asp:Label ID="lblProductID" Text="Product ID" runat="server" />
        <asp:TextBox ID="txtProductID" TextMode="Number" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblQuantity" Text="Quantity" runat="server" />
        <asp:TextBox ID="txtQuantity" TextMode="Number" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" Text="" ForeColor="Red" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnOrder" Text="Order" OnClick="btnOrder_Click" runat="server" />
    </div>
</asp:Content>
