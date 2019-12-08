<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update_Page.aspx.cs" Inherits="final_assign.Update_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/AddStyle.css" type="text/css" media="screen" />
    <div>
        <asp:TextBox runat="server" ID="title">

        </asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="title" EnableClientScript="true" ErrorMessage="Please enter a page title."></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:TextBox runat="server" ID="body">

        </asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="body" EnableClientScript="true" ErrorMessage="Please enter article content."></asp:RequiredFieldValidator>
    </div>
    <div id="showerror" runat="server">
    </div>

    <asp:Button OnClick="Update_page" Text="Update" runat="server" CssClass="btn" />

</asp:Content>
