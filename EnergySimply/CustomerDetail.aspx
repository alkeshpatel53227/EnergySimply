﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" 
    EnableEventValidation="false" CodeBehind="CustomerDetail.aspx.cs" Inherits="EnergySimply.CustomerDetail" %>

<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">

</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-md-12">

            </div>

         </div>
    <div class="row">
        <div class="col-md-12">
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                    <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                    <asp:TemplateField HeaderText="Customer Email" SortExpression="Email">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlEmail" runat="server" Text='<%# Eval("Email") %>' datanavigateurlfields="CustomerID" datanavigateurlformatstring="CustomerDetails.aspx?customerId={0}"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                </Columns>

            </asp:GridView>
        </div>
    </div>
   
</asp:Content>
