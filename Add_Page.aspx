<%@ Page Title="Add Webpage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_Page.aspx.cs" Inherits="final_assign.Add_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/AddStyle.css" type="text/css" media="screen" />  
    <div id="h1">
        <asp:TextBox runat="server" ID="title">Name of Site</asp:TextBox>
    </div>
    <div id="nav">
        <div>
            <asp:TextBox runat="server" ID="body">Edit Title Here</asp:TextBox>
        </div>
        <div><asp:TextBox runat="server" ID="nav_text">Input some text here to describe your website.Input some text here to describe your website.Input some text here to describe your website.Input some text here to describe your website.Input some text here to describe your website.</asp:TextBox></div>
    </div>
    <div id="main">
        <div id="subtitle"><h3>Subtitle</h3></div>
        <p class="paragraph">
            This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.This is the place to put some paragraphs.
        </p>
    </div>
    <asp:Button OnClick="Add_page" Text="Add a new page" runat="server" />
</asp:Content>
