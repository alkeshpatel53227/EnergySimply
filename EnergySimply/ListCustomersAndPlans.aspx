<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" 
    EnableEventValidation="false"
     CodeBehind="ListCustomersAndPlans.aspx.cs" Inherits="EnergySimply.ListCustomersAndPlans" %>
<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">

</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="row">
        <div class="col-md-12">
            <asp:GridView ID="gvCustomerEngeryPlan" runat="server" AutoGenerateColumns="false" CssClass="Grid">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:TemplateField HeaderText="Customer Email" SortExpression="Email">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlEmail" runat="server" Text='<%# Eval("Email") %>' datanavigateurlfields="CustomerID" datanavigateurlformatstring="CustomerDetails.aspx?customerId={0}"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="EnergyPlanName" HeaderText="Plan Name" />
                     <asp:BoundField DataField="FixedCost" HeaderText="Fixed Cost" />
                     <asp:BoundField DataField="varCost" HeaderText="Var Cost" />
                </Columns>

            </asp:GridView>
        </div>
    </div>
     <div class="row">
        <div class="col-md-12">
            <div class="col-md-2"><h5><a href="AddPlan.aspx">Add Plan</a></h5></div>
            <div class="col-md-2"><h5><a href="AddCustomer.aspx">Add Customer</a></h5></div>
         </div>
    </div>
    
</asp:Content>