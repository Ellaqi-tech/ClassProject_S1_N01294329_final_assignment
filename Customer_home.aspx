﻿<%@ Page Title="Firework Website Editor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer_Home.aspx.cs" Inherits="final_assign.Customer_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="main">
        <div runat="server" id="manage" class="flex_container">
            <div id="h2" class="left"><h2>Manage Pages </h2></div>
            <div id="add_new" class="right"><a href="Add_Page.aspx"><img id="plusicon" src="img/plus.png" alt="plus icon" /> Add new page </a></div>
        </div>

        <%//<div id="sql_debugger" runat="server"></div> %>

        <div runat="server" class="flex_container">

            <div id="title" class="left">Title</div>
            <div id="action" class="right">Action</div>
        </div>

        <div id="page_result" runat="server">

        </div>

        <div class="icon">Icons made by <a href="https://www.flaticon.com/authors/smashicons" title="Smashicons">Smashicons</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>

    </div>
</asp:Content>
