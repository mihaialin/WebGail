<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminArea.aspx.cs" Inherits="WebGail._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Admin.</h1>
        <h2>login</h2>
    </hgroup>

    <section class="contact">
        <header>
            
        </header>
       
        <table borderstyle="None">
            <tr><td>Username:</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
            <tr><td>Password:</td><td><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td></tr>
            <tr><td></td><td>
                 <asp:ImageButton ID="login_button" runat="server" Height="45px" ImageUrl="~/Images/login.jpg" Width="300px" BackColor="#3F3F3F" BorderStyle="None" PostBackUrl="~/UserList.aspx" />
                 </td></tr>
            
        </table>
        <div style ="height:400px;width:200px;"></div>
           
        
            
       
    </section>
</asp:Content>