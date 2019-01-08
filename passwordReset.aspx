<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="passwordReset.aspx.vb" Inherits="passwordReset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="PASSWORD RESET" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="Change Users Password"></asp:Label></h1>
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
                    <div class="panel-bodyUche">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Enter Username</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtFrom" runat="server" class="form-control input-md"></asp:TextBox>




                                        </div>

                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="***" ControlToValidate="txtFrom"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />



                            </div>
                            <asp:Button ID="btnSubmit" runat="server" Text="RESET USER PASSWORD" class="btn btn-danger btn-lg pull-left" />
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

