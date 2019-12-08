<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Show_Page.aspx.cs" Inherits="final_assign.Show_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/ViewStyle.css" type="text/css" media="screen" />
    <div id="container">

        <a class="action" href="Customer_Home.aspx">< Back To List</a>

        <a class="action edit" href="Update_Page.aspx?pageid=<%= Request.QueryString["pageid"] %>">Edit</a>

        <a class="action delete" href="Delete_Page.aspx?pageid=<%= Request.QueryString["pageid"] %>">Delete</a> 

    </div>

    <div id="ptitle" runat="server">
    </div>

    <div id="pbody" runat="server">
    </div>

    <div id="showerror" runat="server">
    </div>

</asp:Content>
