<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"
    EnableEventValidation="false" CodeBehind="AddPlan.aspx.cs" Inherits="EnergySimply.AddPlan" %>

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
                <h3>Plan has been added.</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="col-md-3">
                    <label>Plan Name</label>
                    <asp:TextBox ID="txtEnergyPlanName" runat="server" MaxLength="100" CssClass="form-control"/>
                </div>
                <div class="col-md-3">
                    <label>Fixed Cost</label>
                    <asp:TextBox ID="txtFixedCost" runat="server" MaxLength="5" CssClass="form-control"/>
                    <asp:RegularExpressionValidator ID="regFixedCost" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$"
                        ErrorMessage="Please enter valid integer or decimal number with 2 decimal places."
                        ControlToValidate="txtFixedCost" />
                </div>
                <div class="col-md-3">
                    <label>Var Cost</label>
                    <asp:TextBox ID="txtVarCost" runat="server" MaxLength="5" CssClass="form-control"/>
                    <asp:RegularExpressionValidator ID="regVarCost" runat="server" ValidationExpression="((\d+)((\.\d{1,2})?))$"
                        ErrorMessage="Please enter valid integer or decimal number with 2 decimal places."
                        ControlToValidate="txtVarCost" />
                </div>
                <div class="col-md-3">
                    <div style="padding-top: 1px;">
                        <asp:Button ID="btnAddPlan" runat="server" OnClick="btnAddPlan_Click" Text="Add Plan" CssClass="btn btn-primary"/>
                    </div>

                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvPlan" runat="server" AutoGenerateColumns="false" CssClass="Grid">
                    <Columns>
                        <asp:BoundField DataField="EnergyPlanId" HeaderText="Plan ID" />
                        <asp:BoundField DataField="EnergyPlanName" HeaderText="Plan Name" />
                        <asp:BoundField DataField="FixedCost" HeaderText="Fixed Cost" />
                        <asp:BoundField DataField="varCost" HeaderText="Var Cost" />
                    </Columns>

                </asp:GridView>
            </div>
        </div>
         <div class="row">
        <div class="col-md-12">
            <div class="col-md-2"><h5><a href="AddCustomer.aspx">Add Customer</a></h5></div>
         </div>
    </div>
    </div>
</asp:Content>
