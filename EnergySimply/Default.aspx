<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EnergySimply._Default" EnableEventValidation="false"
    %>
<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">

</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">
           <h3><a href="ListCustomersAndPlans.aspx">View Solution to Challenge A</a></h3>
        </div>
         <div class="col-md-12">
           <h3><a href="ViewFiles.aspx">View Solution to Challenge B</a></h3>
        </div>
         <div class="col-md-12">
           <h3><a href="SendEmailToCustomer.aspx">View Solution to Challenge C</a></h3>
        </div>
    </div>
</asp:Content>
