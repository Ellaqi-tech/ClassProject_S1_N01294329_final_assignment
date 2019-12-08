<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Show_Page.aspx.cs" Inherits="final_assign.Show_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/ViewStyle.css" type="text/css" media="screen" />

    <div id="ptitle" runat="server">
    </div>

    <div id="pbody" runat="server">
    </div>

    <div id="showerror" runat="server">
    </div>

    <asp:Button OnClientClick="if(!confirm('Are you sure you want to delete this page?')) return false;" OnClick="Delete_page" CssClass="right" Text="Delete" runat="server"/> 

    <a class="right" href="Update_Page.aspx?pageid=<%= Request.QueryString["pageid"] %>">Edit</a>

</asp:Content>
