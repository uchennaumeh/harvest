<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="CreateTruck.aspx.vb" Inherits="CreateTruck" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="CREATE TRUCK" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="ADD NEW TRUCK" ForeColor=""></asp:Label></h1>
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
                                    <label class="col-md-3 control-label">Truck Name*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtTruckName" runat="server" Width="300px" class="form-control input-md"></asp:TextBox>

                                        </div>
                                         
                                     <asp:RequiredFieldValidator ID="rfvTruckName" runat="server" ErrorMessage="***" ControlToValidate="txtTruckName" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                               
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Truck Weight</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtTruckWeight" runat="server" TextMode="Number" Width="300px" class="form-control input-md"></asp:TextBox>

                                        </div>
                                         
                                     <asp:RequiredFieldValidator ID="rfvTruckWeight" runat="server" ErrorMessage="***" ControlToValidate="txtTruckWeight" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>

                            </div>
                            
                        </div>

                            <asp:Button ID="btnSubmit" runat="server" Text="CREATE TRUCK" Visible="true" class="btn btn-primary btn-lg pull-left" />
                        </asp:Panel>
                        <br /><br />
                        <asp:Panel ID="Panel11" runat="server">
                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="seqno" Visible="true" Caption="TRUCK DETAILS" BorderColor="Black">
                                        <Columns>
                                            <asp:TemplateField HeaderText="S/N">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex + 1 %>
                                                </ItemTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TRUCK">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTruck" runat="server" Text='<%#Eval("truck")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="WEIGHT">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblWeight" runat="server" Text='<%#Eval("weight")%>' />
                                                </ItemTemplate>


                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="DATE CREATED">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTruckNum" runat="server" Text='<%#Eval("dateCreated")%>' />
                                                </ItemTemplate>
                                                </asp:TemplateField>


                                            



                                            <asp:HyperLinkField DataNavigateUrlFields="truck" DataNavigateUrlFormatString="TruckEdit.aspx?truck={0}" DataTextField="truck" DataTextFormatString="Edit Details for {0}" HeaderText="EDIT TRUCK" />

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

