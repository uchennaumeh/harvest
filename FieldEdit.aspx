<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="FieldEdit.aspx.vb" Inherits="FieldEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="EDIT FIELD" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="Modify Field Details" ForeColor="#CC0000"></asp:Label></h1>
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
                                    <label class="col-md-3 control-label">Field Name*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtFieldName" runat="server" class="form-control input-md"></asp:TextBox>
                                        </div>
                                                                                <asp:RequiredFieldValidator ID="rfvFieldName" runat="server" ErrorMessage="***" ControlToValidate="txtFieldName" ForeColor="Red"></asp:RequiredFieldValidator>



                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Field Area*</label>
                                    <div class="col-md-9">

                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtArea" runat="server" TextMode="Number" class="form-control input-md"></asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="rrfArea" runat="server" ErrorMessage="***" ControlToValidate="txtArea" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Field Area*</label>
                                    <div class="col-md-9">

                                        <div class="input-group">
                                            
                                            
                                            <asp:DropDownList ID="drpEstate" runat="server" class="form-control input-md" Width="300px"></asp:DropDownList>
                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvEstate" runat="server" ErrorMessage="***" InitialValue="0" ControlToValidate="drpEstate" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="form-group">
                                   
                                    <div class="col-md-9">

                                        <div class="input-group">
                                             
                                            <asp:Button ID="btnUpdate" runat="server" Text="Update Field" class="btn btn-primary btn-lg pull-left"></asp:Button>

                                        </div>

                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                            </div>
                        </div>
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
                <asp:TextBox ID="txtSeq" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>

