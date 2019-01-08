<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CreateEstate.aspx.vb" Inherits="CreateEstate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="CREATE ESTATE" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="ADD NEW ESTATE" ForeColor=""></asp:Label></h1>
                                </td>
                                <td></td>
                                <td align="right">
                                    <asp:Image ID="Image1" ImageAlign="right" runat="server" ImageUrl="~/images/dangote.png" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <p></p>
                                   
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>
                        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><br />
                        <asp:Panel ID="Panel10" runat="server">
                            <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Estate Name*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtEstateName" runat="server" Width="300px" class="form-control input-md"></asp:TextBox>

                                        </div>
                                         
                                     <asp:RequiredFieldValidator ID="rfvEstateName" runat="server" ErrorMessage="***" ControlToValidate="txtEstateName" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>


                            </div>
                            
                        </div>

                            <asp:Button ID="btnSubmit" runat="server" Text="CREATE ESTATE" Visible="true" class="btn btn-primary btn-lg pull-left" />
                        </asp:Panel>
                        <br /><br />
                        <asp:Panel ID="Panel11" runat="server">
                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="ID" Visible="true" Caption="SHIFT DETAILS" BorderColor="Black">
                                        <Columns>
                                            <asp:TemplateField HeaderText="S/N">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex + 1 %>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="ESTATE">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("name")%>' />
                                                </ItemTemplate>




                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="DATE CREATED">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDate" runat="server" Text='<%#Eval("dateCreated")%>' />
                                                </ItemTemplate>
                                                </asp:TemplateField>


                                            



                                            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="EstateEdit.aspx?ID={0}" DataTextField="name" DataTextFormatString="Edit Details for {0}" HeaderText="EDIT ESTATE" />

                                        </Columns>
                                                <HeaderStyle BackColor="#0033CC" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                            </asp:Panel>
                        


                        
                    </div>
                    </div>
                </div>
            </div>
         </div>
     <table align="center" cellpadding="2" style="width: 70%">
        <tr>
            <td>
                <asp:TextBox ID="txtUsername" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtRole" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtBranch" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtDepartment" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtStaffID" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtCount" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtNewCount" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox8" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>

