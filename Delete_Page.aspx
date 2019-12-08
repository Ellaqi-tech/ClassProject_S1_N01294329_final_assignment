<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete_Page.aspx.cs" Inherits="final_assign.Delete_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Are you sure you want to remove <span runat="server" id="ptitle"></span> ?</h3>

    <div class="view">
        <a class="left" href="Show_Page.aspx?pageid=<%= Request.QueryString["pageid"] %>">No</a>
        <asp:Button OnClick="Delete_page" CssClass="right" Text="Yes" runat="server"/>  
    </div>

    

</asp:Content>
