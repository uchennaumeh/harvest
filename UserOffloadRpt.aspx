<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="UserOffloadRpt.aspx.vb" Inherits="UserOffloadRpt" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="page-content-wrap">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">
                            <asp:Label ID="Label2" runat="server" Text="REPORT" Font-Bold="True" ForeColor="#000066"></asp:Label></h3>

                    </div>
                    <div class="panel-body">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text="Your Trucks Out Report" ForeColor=""></asp:Label></h1>
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
                                    <label class="col-md-3 control-label">Date From*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-calendar"></span></span>
                                            <asp:TextBox ID="txtFrom" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                                                    
                                                    

                                        </div>

                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="***" ControlToValidate="txtFrom"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class="form-group">
                                    <label class="col-md-3 control-label">Date To*</label>
                                    <div class="col-md-9">
                                        <div class="input-group">
                                            <span class="input-group-addon"><span class="fa fa-calendar"></span></span>
                                            <asp:TextBox ID="txtTo" runat="server" class="form-control input-md" TextMode="Date"></asp:TextBox>
                                                    
                                                    

                                        </div>

                                       <asp:RequiredFieldValidator ID="rfvlEstate" runat="server" ErrorMessage="***" ControlToValidate="txtTo"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                            </div>
                            <asp:Button ID="btnSubmit" runat="server" Text="SPOOL YOUR REPORT" class="btn btn-primary btn-lg pull-left" />
                        </div>
                      
                            
                        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Visible="false" Height="100%" Width="100%" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
                            <LocalReport ReportPath="ReportOffLoad.rdlc">
                                <DataSources>
                                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetReportOffLoad" />
                                </DataSources>
                            </LocalReport>
                        </rsweb:ReportViewer>   
                                   
                                      
                                   
                                        
                                



                             
                         
                    
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="caneWeighDataSetReportOffLoadTableAdapters.caneWeigh_TimeOut_user_range_FetchTableAdapter"></asp:ObjectDataSource>
                                   
                                      
                                   
                                        
                                



                             
                         
                    
                    </div>
                </div>
            </div>
        </div>
    </div>

    <table align="center" cellpadding="2" style="width: 70%">
        <tr>
            <td><asp:TextBox ID="txtUsername" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtRole" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtBranch" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtDepartment" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtStaffID" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtCount" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtNewCount" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="TextBox8" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>

