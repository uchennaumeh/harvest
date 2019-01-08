<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="TransView.aspx.vb" Inherits="TransView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                        <asp:Label ID="Label2" runat="server" Text="MODIFY TRANSACTIONS" Font-Bold="True" ForeColor=""></asp:Label></h3>
                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="View/Edit Weighment Transaction" ForeColor=""></asp:Label></h1>
                                </td>
                                <td></td>
                                <td align="right">
                                    <asp:Image ID="Image1" ImageAlign="right" runat="server" ImageUrl="~/images/dangote.png" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <p>Please Provide Accurate Details!</p>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>



                        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="col-md-3 control-label">TRIP ID</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtWeighInCode" runat="server" class="form-control input-md"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvlWINCOde" runat="server" ErrorMessage="***" ControlToValidate="txtWeighInCode" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                            </div>
                            <asp:Button ID="btnCode" runat="server" Text="CHECK CODE" class="btn btn-primary btn-lg pull-left" />
                        </div>
                       <asp:Panel ID="Panel1" runat="server" Visible="false">
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="code" Visible="true" Caption="TRANSACTION DETAILS" BorderColor="Black">
                                        <Columns>
                                            <asp:TemplateField HeaderText="S/N">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex + 1 %>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="CODE">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTranCode" runat="server" Text='<%#Eval("code")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="FULLNAMES">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("DriverName")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TRUCK NUMBER">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTruckNum" runat="server" Text='<%#Eval("TruckNumber")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="BIN NUMBER">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblState" runat="server" Text='<%#Eval("binNumber")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="GROSS WEIGHT">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblGross" runat="server" Text='<%#Eval("GrossWeight")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TARE WEIGHT">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblGross" runat="server" Text='<%#Eval("TareWeight")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TIME IN">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblGross" runat="server" Text='<%#Eval("TimeIn")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TIME OUT">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblGross" runat="server" Text='<%#Eval("TimeOut")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>



                                            <asp:HyperLinkField DataNavigateUrlFields="Code" DataNavigateUrlFormatString="EditTrans.aspx?Code={0}" DataTextField="Code" DataTextFormatString="Edit Details for {0}" HeaderText="EDIT DETAILS" />

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

