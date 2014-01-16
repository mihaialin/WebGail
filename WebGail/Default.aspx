<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebGail._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
           
            <hgroup class="title">
                <h1>Breast Cancer Risk:</h1>
                <h2>Find out now what's your risk to develop breast cancer.</h2>
                
            </hgroup>
            <p>
               
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3 style ="color:#fff;">Before you get started:</h3>
    <ol class="round">
        <li class="one">
           The Breast Cancer Risk Assessment Tool was designed for use by health professionals. If you are not a health professional, you are encouraged to discuss the results and your personal risk of breast cancer with your doctor. 
        </li>
        <li class="two">
            Although the tool may accurately estimate a woman's risk of developing breast cancer, these risk estimates do not allow one to say precisely which woman will develop breast cancer. In fact, the distribution of risk estimates for women who develop breast cancer overlaps the estimates of risk for women who do not. 
        </li>
        <li class="three">
            The tool should not be used to calculate breast cancer risk for women who have already had a diagnosis of breast cancer, lobular carcinoma in situ (LCIS), or ductal carcinoma in situ (DCIS). 
        </li>
       
        
       <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/Images/gestarted.jpg" PostBackUrl="~/About.aspx" Width="150px" Border="0" BorderStyle="None"/>
    </ol>
    <p>2014 DopeOnARope</p>
</asp:Content>
