<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"
    EnableEventValidation="false" CodeBehind="AddCustomer.aspx.cs" Inherits="EnergySimply.AddCustomer" %>

<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding-top: 40px; width: 100%">
        <div class="row" runat="server" id="divError">
            <div class="alert alert-danger" role="alert">
                <h3>Please enter all the fields!</h3>
            </div>
        </div>
        <div class="row" runat="server" id="divSuccess">
            <div class="alert alert-success" role="alert">
                <h3>Customer has been added.</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-md-3">
                    <label>Customer Name</label>
                    <div style="padding-top: 5px;">
                        <asp:DropDownList ID="ddlEnergyPlans" CssClass="form-control"
                        runat="server" DataTextField="EnergyPlanName" DataValueField="EnergyPlanId" />
                    </div>
                    
                </div>
                <div class="col-md-3">
                    <label>Customer Name</label>
                    <asp:TextBox ID="txtCustomerName" runat="server" MaxLength="50" CssClass="form-control"/>
                </div>
                <div class="col-md-3">
                    <label>Customer Email</label>
                    <asp:TextBox ID="txtCustomerEmail" runat="server" MaxLength="100" TextMode="Email" CssClass="form-control"/>
                </div>
                <div class="col-md-3">
                    <div style="padding-top: 25px;">
                        <asp:Button ID="btnAddCustomer" runat="server" OnClick="btnAddCustomer_Click" Text="Add Customer" CssClass="btn btn-primary"/>
                    </div>

                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" CssClass="Grid">
                    <Columns>
                        <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                        <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                        <asp:TemplateField HeaderText="Customer Email" SortExpression="Email">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlEmail" runat="server" Text='<%# Eval("Email") %>' datanavigateurlfields="CustomerID" datanavigateurlformatstring="CustomerDetails.aspx?customerId={0}" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="CustomerPlanId" HeaderText="Plan ID" />
                    </Columns>

                </asp:GridView>
            </div>
        </div>
         <div class="row">
        <div class="col-md-12">
            <div class="col-md-2"><h5><a href="AddPlan.aspx">Add Plan</a></h5></div>
         </div>
    </div>
    </div>

</asp:Content>
