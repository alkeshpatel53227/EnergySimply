<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"
    EnableEventValidation="false" CodeBehind="StopBatch.aspx.cs" Inherits="EnergySimply.StopBatch" %>


<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Button Text="Stop Batch" runat="server" ID="btnStopBatch" OnClick="btnStopBatch_Click"/>
    </div>
     <div class="row">
        <asp:Button Text="Start Batch" runat="server" ID="btnStartBatch" OnClick="btnStartBatch_Click"/>
    </div>
    <div class="row">
        <asp:TextBox ID="txtSeconds" runat="server" />
        <asp:Button Text="Update Seconds" runat="server" ID="btnSeconds" OnClick="btnSeconds_Click"/>
    </div>

</asp:Content>