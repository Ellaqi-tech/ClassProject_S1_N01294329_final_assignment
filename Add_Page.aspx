<%@ Page Title="Add Webpage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_Page.aspx.cs" Inherits="final_assign.Add_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/AddStyle.css" type="text/css" media="screen" /> 
    
    <div>
        <asp:TextBox runat="server" ID="title"> Page Title </asp:TextBox>
    </div>
  
    <div id="main">
        <asp:TextBox runat="server" ID="body"> Page Content </asp:TextBox>
    </div>

    <asp:Button OnClick="Add_page" Text="Add a new page" runat="server" CssClass="btn" />

</asp:Content>
