<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update_Page.aspx.cs" Inherits="final_assign.Update_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/ViewStyle.css" type="text/css" media="screen" />
    <div>
        <asp:TextBox runat="server" ID="title">

        </asp:TextBox></div>
    <div>
        <asp:TextBox runat="server" ID="body">

        </asp:TextBox>
    </div>
    <div id="showerror" runat="server">
    </div>
</asp:Content>
