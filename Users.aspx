<%@ Page Title="Harvesters Control Center - Users Page " Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Users.aspx.vb" Inherits="Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                        <asp:Label ID="Label2" runat="server" Text="USERS" Font-Bold="True" ForeColor=""></asp:Label></h3>
                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="View Application Users" ForeColor=""></asp:Label></h1>
                                </td>
                                <td></td>
                                <td align="right">
                                    <asp:Image ID="Image1" ImageAlign="right" runat="server" ImageUrl="~/images/dangote.png" />
                                </td>
                            </tr>
                          <%--  <tr>
                                <td align="left">
                                    <p>Please Provide Accurate Details!</p>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>--%>
                        </table>



                        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="panel-body">
                      
                       <asp:Panel ID="Panel1" runat="server" Visible="true">
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AllowPaging="True" OnPageIndexChanging="OnPageIndexChangingInmate" PageSize="10" AutoGenerateColumns="False" DataKeyNames="username" Visible="true" Caption="APPLICATION USERS" BorderColor="Black">
                                        <Columns>
                                            <asp:TemplateField HeaderText="S/N">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex + 1 %>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="USERNAME">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTranCode" runat="server" Text='<%#Eval("username")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="FULLNAMES">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("fullname")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="ROLE">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblRole" runat="server" Text='<%#Eval("roleDesc")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="GENDER">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSex" runat="server" Text='<%#Eval("Sex")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TELEPHONE">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbltel" runat="server" Text='<%#Eval("Telephone")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="DATE CREATED">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDateC" runat="server" Text='<%#Eval("datecreated")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="CREATED BY">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCreatedBy" runat="server" Text='<%#Eval("createdby")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                           
                                            
                                          


                                            <asp:HyperLinkField DataNavigateUrlFields="username" DataNavigateUrlFormatString="ModifyUser.aspx?username={0}" DataTextField="username" DataTextFormatString="Edit Details for {0}" HeaderText="EDIT DETAILS" />

                                        </Columns>
                                                <HeaderStyle BackColor="#0033CC" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                        </div>
                                        
                                    </div>



                                </div>
                            </div>
                         
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
