<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WeighOut.aspx.vb" Inherits="WeighOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="WEIGH OUT" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="Truck/Tractor Weigh Out" ForeColor="#CC0000"></asp:Label></h1>
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
                                    <label class="col-md-3 control-label">Weigh-In Code</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                            <asp:TextBox ID="txtWeighInCode" runat="server" class="form-control"></asp:TextBox>

                                        </div>

                                        <asp:RequiredFieldValidator ID="rfvlWINCOde" runat="server" ErrorMessage="***" ControlToValidate="txtWeighInCode" ForeColor="Red"></asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                            </div>
                            <asp:Button ID="btnCode" runat="server" Text="CHECK CODE" class="btn btn-danger btn-lg pull-left" />
                        </div>

                        <asp:Panel ID="Panel1" runat="server" Visible="false">
                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Field</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtField" ReadOnly="true" runat="server" class="form-control input-md" BackColor="#CCFFFF"></asp:TextBox>
                                                </div>



                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Shift</label>
                                            <div class="col-md-9">

                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtShift" BackColor="#CCFFFF" ReadOnly="true" runat="server" class="form-control input-md">
                                                        
                                                    </asp:TextBox>

                                                </div>

                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />

                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Time In</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTimeIn" BackColor="#CCFFFF" runat="server" ReadOnly="true" class="form-control input-md"></asp:TextBox>
                                                </div>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />


                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Driver</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtDriver" BackColor="#CCFFFF" ReadOnly="true" runat="server" class="form-control input-md">
                                                        
                                                    </asp:TextBox>


                                                </div>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Tractor/Truck Number</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTruckNo" BackColor="#CCFFFF" ReadOnly="true" runat="server" class="form-control input-md"></asp:TextBox>


                                                </div>


                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">BIN Number</label>
                                            <div class="col-md-9">

                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtBIN" BackColor="#CCFFFF" runat="server" ReadOnly="true" class="form-control input-md"></asp:TextBox>

                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />



                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Gross Weight</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtGrossW" BackColor="#CCFFFF" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>
                                                </div>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Tare Weight</label>
                                            <div class="col-md-9 col-xs-12">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtTare" runat="server" class="form-control input-md" TextMode="Number" ViewStateMode="Enabled"></asp:TextBox>


                                                </div>
                                                <asp:RequiredFieldValidator ID="rfvlTare" runat="server" ErrorMessage="***" ControlToValidate="txtTare"></asp:RequiredFieldValidator>
                                            </div>


                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <div class="form-group">
                                            <label class="col-md-3 control-label">Net Weight</label>
                                            <div class="col-md-9">
                                                <div class="input-group">
                                                    <span class="input-group-addon"><span class="fa fa-pencil"></span></span>
                                                    <asp:TextBox ID="txtNet" runat="server" ReadOnly="true" class="form-control input-md" TextMode="Number"></asp:TextBox>


                                                </div>


                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />




                                        <br />

                                    </div>



                                </div>
                            </div>
                            <div class="panel-footer">
                                <asp:Button ID="btnNet" runat="server" class="btn btn-danger btn-lg pull-left" Text="NET WEIGHT" /><br />
                                <asp:Button ID="btnUpdate" runat="server" Visible="false" class="btn btn-danger btn-lg pull-left" Text="SUBMIT" />

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

