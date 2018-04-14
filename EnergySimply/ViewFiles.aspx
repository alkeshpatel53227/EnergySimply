<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFiles.aspx.cs" MasterPageFile="~/Site.Master"
    EnableEventValidation="false" Inherits="EnergySimply.ViewFiles" %>
<asp:Content ContentPlaceHolderID="HeadContent" ID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
            <div class="col-md-12">
                <asp:GridView ID="gvFiles" runat="server" AutoGenerateColumns="false" CssClass="Grid">
                    <Columns>
                        <asp:BoundField DataField="FileId" HeaderText="File ID" />
                        <asp:BoundField DataField="FileName" HeaderText="File Name" />
                        <asp:BoundField DataField="CreateDate" HeaderText="Create Date" />
                        <asp:TemplateField HeaderText="" SortExpression="Email">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlDownload" runat="server" Text="Download" datanavigateurlfields="FileId" datanavigateurlformatstring="/Handlers/DownloadFile.ashx?fileId={0}" NavigateUrl='<%# "~/Handlers/DownloadFile.ashx?fileId=" + Eval("FileId")%>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                    </Columns>

                </asp:GridView>
            </div>
        </div>

</asp:Content>
