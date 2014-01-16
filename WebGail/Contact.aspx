<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebGail.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Your.</h1>
        <h2>results</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </h3>
        </header>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Lifetime risk:</h3>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </p>
        </header>
    </section>

    <section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            One Microsoft Way<br />
            Redmond, WA 98052-6399
        </p>
    </section>
</asp:Content>