<%@ Page Language="C#" AutoEventWireup="true"
    MasterPageFile="~/Site.Master"
    EnableEventValidation="false" CodeBehind="SendEmailToCustomer.aspx.cs" Inherits="EnergySimply.SendEmailToCustomer" %>


<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">
   
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row" runat="server" id="divError">
            <div class="alert alert-danger" role="alert" id="divErrorMsg" runat="server">
                
            </div>
        </div>
        <div class="row" runat="server" id="divSuccess">
            <div class="alert alert-success" role="alert">
                <h3>Email sent successfully.</h3>
            </div>
        </div>
    <div style="width:100%" id="divEmail" runat="server">
        <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label>Select A Customer To Email</label>
                    <asp:DropDownList ID="ddlCustomer"  CssClass="form-control"
                        runat="server" DataTextField="CustomerName" DataValueField="CustomerId" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="form-group">
                    <label>Enter subject</label>
                    <asp:TextBox ID="txtSubject" CssClass="form-control"
                        runat="server" Width="100%"/>
                </div>
            </div>
        </div>
        <div class="row">
           
             <div class="col-md-12">
                <div class="form-group">
                    <label>Enter message</label>

                    <asp:TextBox ID="txtMessage" CssClass="form-control"
                        runat="server" TextMode="MultiLine" Rows="3" />
                </div>

            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Button ID="btnPreview" CssClass="btn btn-primary"
                        runat="server" Text="Preview" OnClick="btnPreview_Click"/>
                </div>
            </div>
        </div>
      </div>

    <div style="width:100%" id="divPreview" runat="server">
         <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>To:</label>
                    <asp:Label ID="lblPreviewTo" runat="server" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Subject:</label>
                      <asp:Label ID="lblSubject" runat="server" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label>Message:</label>
                     <asp:Label ID="lblMsg" runat="server" />
                </div>

            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Button ID="btnBack"
                        runat="server" Text="Back" OnClick="btnBack_Click" CssClass="btn btn-warning"/>
                    <asp:Button ID="btnSend"
                        runat="server" Text="Send Email" OnClick="btnSend_Click" CssClass="btn btn-success"/>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>
