<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="UserList.aspx.cs" Inherits="WebGail.UserList" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Admin.</h1>
        <h2>user list</h2>
    </hgroup>

    <section class="contact">
        <header>
            
        </header>
       <div style ="min-height:800px;">
        <asp:Table id = "userTable" runat="server"></asp:Table>    
       </div>
            
       
    </section>
</asp:Content>