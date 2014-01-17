<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebGail.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Evaluate.</h1>
        <h2>right now</h2>
    </hgroup>

    <article>
        <table style ="color:#fff;">
           
<tr><td>   First name</td><td><asp:TextBox ID="firstName" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     Last name</td><td><asp:TextBox ID="lastName" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     Birth date</td><td><asp:TextBox ID="birthDate" runat="server"></asp:TextBox></td></tr>
        
                
       <tr><td>      Email</td><td><asp:TextBox ID="email" runat="server"></asp:TextBox></td></tr>
        
                
      <tr><td>       Race</td><td><asp:DropDownList ID="raceInput" runat="server" Width="314px">
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
        
                
       <tr><td>      Projection period</td><td><asp:TextBox ID="projection" runat="server"></asp:TextBox></td></tr>
        
                
       <tr><td>      Menarch</td><td><asp:TextBox ID="menarch" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     First childbirth age</td><td><asp:TextBox ID="firstChild" runat="server"></asp:TextBox></td></tr>
        
                
        <tr><td>     Biopsy</td><td><asp:DropDownList ID="biopsy" runat="server" Width="314px">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList></td></tr>
        
                
        <tr><td>     Number of breast byopsies</td><td><asp:TextBox ID="numbByopsies" runat="server"></asp:TextBox></td></tr>
        
                
         <tr><td>    First relatrives with cancer</td><td><asp:TextBox ID="firstRelatives" runat="server"></asp:TextBox></td></tr>
        
                
         <tr><td>    Hyperplacia</td><td><asp:DropDownList ID="hyper" runat="server" Width="314px">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList></td></tr>
         <tr><td></td><td>
             <asp:ImageButton ID="evaluate" runat="server" Height="45px" ImageUrl="~/Images/evaluate.jpg" OnClick="evaluate_Click" Width="300px" BackColor="#3F3F3F" BorderStyle="None" /></td></tr>
       </table>
    </article>

    <aside>
        <h3>&nbsp;</h3>
    </aside>
</asp:Content>