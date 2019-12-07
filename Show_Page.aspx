<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Show_Page.aspx.cs" Inherits="final_assign.Show_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/ViewStyle.css" type="text/css" media="screen" />
    <div>
        <asp:TextBox ID="title" runat="server">

        </asp:TextBox>
    </div>
    <div>
        <asp:TextBox ID="body" runat="server">

        </asp:TextBox>
    </div>
    <div id="showerror" runat="server">
    </div>
</asp:Content>
