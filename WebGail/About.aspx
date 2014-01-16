<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebGail.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Risk Calculator</h2>
    </hgroup>

    <article>
        <table style ="color:#fff;">
           
<tr><td>   First name</td><td><asp:TextBox ID="firstName" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     Last name</td><td><asp:TextBox ID="lastName" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     Birtd date</td><td><asp:TextBox ID="birthDate" runat="server"></asp:TextBox></td></tr>
        
                
       <tr><td>      Email</td><td><asp:TextBox ID="email" runat="server"></asp:TextBox></td></tr>
        
                
      <tr><td>       Race</td><td><asp:DropDownList ID="DropDownList1" runat="server" Width="314px">
                <asp:ListItem>White</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Hispanic</asp:ListItem>
                <asp:ListItem>Chinese</asp:ListItem>
                <asp:ListItem>Japanese</asp:ListItem>
                <asp:ListItem>Philipino</asp:ListItem>
                <asp:ListItem>Hawaiian</asp:ListItem>
                <asp:ListItem>Oceanic</asp:ListItem>
                <asp:ListItem>Other/ Asian-American</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList></td></tr>
        
                
       <tr><td>      Projection period</td><td><asp:TextBox ID="email0" runat="server"></asp:TextBox></td></tr>
        
                
       <tr><td>      Menarch</td><td><asp:TextBox ID="email1" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     First childbirth age</td><td><asp:TextBox ID="email2" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     Biopsy</td><td><asp:DropDownList ID="DropDownList2" runat="server" Width="314px">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList></td></tr>
        
                
        <tr><td>     Number of breast byopsies</td><td><asp:TextBox ID="email3" runat="server"></asp:TextBox></td></tr>
        
                
         <tr><td>    First relatrives with cancer</td><td><asp:TextBox ID="email4" runat="server"></asp:TextBox></td></tr>
        
                
         <tr><td>    Hyperplacia</td><td><asp:DropDownList ID="DropDownList3" runat="server" Width="314px">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList></td></tr>
         <tr><td></td><td>
             <asp:ImageButton ID="evaluate" runat="server" Height="45px" ImageUrl="~/Images/evaluate.jpg" OnClick="evaluate_Click" Width="300px" /></td></tr>
       </table>
    </article>

    <aside>
        <h3>Aside Title</h3>
        <p>        
            Use this area to provide additional information.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About.aspx">About</a></li>
            <li><a runat="server" href="~/Contact.aspx">Contact</a></li>
        </ul>
    </aside>
</asp:Content>