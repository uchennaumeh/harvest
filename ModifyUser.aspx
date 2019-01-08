<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ModifyUser.aspx.vb" Inherits="ModifyUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="MODIFY USER DETAILS" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="Modify User Details" ForeColor=""></asp:Label></h1>
                                </td>
                                <td></td>
                                <td align="right">
                                    <asp:Image ID="Image1" ImageAlign="right" runat="server" ImageUrl="~/images/dangote.png" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <p>Please Provide Accurate Details</p>
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
                                    <label class="col-md-3 control-label">First Name</label>
                                    <div class="col-md-9">

                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>

                                            <asp:TextBox ID="txtFirstname" runat="server" placeholder="firstname" class="form-control" readonly="true"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvfirstname" runat="server" ErrorMessage="***" ControlToValidate="txtFirstname" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Lastname</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>

                                            <asp:TextBox ID="txtLastname" runat="server" placeholder="lastname" class="form-control" ReadOnly="true"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvlastname" runat="server" ErrorMessage="***" ControlToValidate="txtLastname"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Other Names</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtOthernames" runat="server" placeholder="othernames" class="form-control"></asp:TextBox><br />
                                        </div>

                                        <asp:RequiredFieldValidator ID="rfvOtherNames" runat="server" ErrorMessage="***" ControlToValidate="txtOthernames"></asp:RequiredFieldValidator>

                                    </div>

                                </div>
                            </div>

                            <div class="col-md-4">

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Phone Number</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtPhone" runat="server" placeholder="phone number" class="form-control input-md" TextMode="Number"></asp:TextBox>
                                        </div>


                                        <asp:RequiredFieldValidator ID="rfvTel" runat="server" ErrorMessage="***" ControlToValidate="txtPhone" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="form-group">
                                    <label class="col-md-3 control-label">Email</label>
                                    <div class="col-md-9">

                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>

                                            <asp:TextBox ID="txtEmail" runat="server" placeholder="email" class="form-control" TextMode="email"></asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="***" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Staff-ID</label>
                                    <div class="col-md-9 col-xs-12">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>

                                            <asp:TextBox ID="txtStafsID" runat="server" placeholder="Staff ID" class="form-control input-md"></asp:TextBox>

                                        </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="***" ControlToValidate="txtStafsID" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>


                                </div>
                                <br />
                                <br />
                                <br />






                            </div>
                            <div class="col-md-4">
                                <table>
                                    <tr>
                                        <td>
                                            <strong>&nbsp;&nbsp;&nbsp;Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                        </td>
                                        <td align="right">
                                            <asp:DropDownList ID="drpSex" runat="server" class="form-control" Width="300px">
                                                <asp:ListItem Value="0">-- Select Gender --</asp:ListItem>
                                                <asp:ListItem Value="1">Female</asp:ListItem>
                                                <asp:ListItem Value="2">Male</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="***" ControlToValidate="drpSex" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>

                                <br />
                                <table>
                                    <tr>
                                        <td>
                                            <strong>&nbsp;&nbsp;&nbsp;Role&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="drpRole" runat="server" class="form-control" Width="300px">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="***" ControlToValidate="drpRole" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>




                                <br />
                                <br />


                                <div class="form-group">
                                    <label class="col-md-3 control-label">Address</label>
                                    <div class="col-md-9 col-xs-12">



                                        <asp:TextBox ID="txtAddress" runat="server" placeholder="address" class="form-control" Rows="5" TextMode="MultiLine"></asp:TextBox>


                                        <asp:RequiredFieldValidator ID="rfvAddy" runat="server" ErrorMessage="***" ControlToValidate="txtAddress" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>


                            </div>


                        </div>

                    </div>
                    <div class="panel-footer">
                        <asp:Button ID="btnLogin" runat="server" Text="UPDATE USER DETAILS" class="btn btn-primary btn-lg pull-right" />

                    </div>
                </div>

            </div>
        </div>
    </div>


    <div class="collapse searchbar" id="searchbar">
        <div class="search-area">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">Go!</button>
                            </span>
                        </div>
                        <!-- /input-group -->
                    </div>
                    <!-- /.col-lg-6 -->
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
                <asp:TextBox ID="txtChUser" Visible="false" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox8" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>

