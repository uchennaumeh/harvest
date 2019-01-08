<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CreateField.aspx.vb" Inherits="CreateField" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="CREATE FIELD" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="ADD NEW FIELD" ForeColor=""></asp:Label></h1>
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
                                    <label class="col-md-3 control-label">Field Name*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtFieldName" runat="server" Width="300px" class="form-control input-md"></asp:TextBox>

                                        </div>
                                         
                                     <asp:RequiredFieldValidator ID="rfvFieldName" runat="server" ErrorMessage="***" ControlToValidate="txtFieldName" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div><br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Field Area*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtArea" runat="server" Width="300px" TextMode="Number" class="form-control input-md"></asp:TextBox>

                                        </div>
                                         
                                     <asp:RequiredFieldValidator ID="rfvArea" runat="server" ErrorMessage="***" ControlToValidate="txtArea" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Estate*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            
                                           
                                            <asp:DropDownList ID="drpEstate" runat="server" Width="300px" class="form-control input-md"></asp:DropDownList>
                                        </div>
                                         
                                     <asp:RequiredFieldValidator ID="rfvEstate" runat="server" ErrorMessage="***" ControlToValidate="drpEstate" InitialValue="0" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>


                            </div>
                            
                        </div>

                            <asp:Button ID="btnSubmit" runat="server" Text="CREATE FIELD" Visible="true" class="btn btn-primary btn-lg pull-left" />
                        </asp:Panel>
                        <br /><br />
                        <asp:Panel ID="Panel11" runat="server">
                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="fieldID" AllowPaging="true" PageSize="20" OnPageIndexChanging="OnPageIndexChangingInmate" Visible="true" Caption="FIELD DETAILS" BorderColor="Black">
                                        <Columns>
                                            <asp:TemplateField HeaderText="S/N">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex + 1 %>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="FIELD">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("fieldName")%>' />
                                                </ItemTemplate>

                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="FIELD AREA">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblArea" runat="server" Text='<%#Eval("fieldArea")%>' />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="ESTATE">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEstate" runat="server" Text='<%#Eval("name")%>' />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="DATE CREATED">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDate" runat="server" Text='<%#Eval("dateCreated")%>' />
                                                </ItemTemplate>
                                                </asp:TemplateField>


                                            



                                            <asp:HyperLinkField DataNavigateUrlFields="fieldID" DataNavigateUrlFormatString="FieldEdit.aspx?ID={0}" DataTextField="FieldName" DataTextFormatString="Edit Details for {0}" HeaderText="EDIT FIELD" />

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

