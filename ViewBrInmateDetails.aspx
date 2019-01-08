<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ViewBrInmateDetails.aspx.vb" Inherits="ViewBrInmateDetails" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
    <div class="page-header">
        <div class="container">
            <div class="row">

                <div class="col-md-12 col-sm-12 col-xs-12">
                    <div class="bg-white pinside30">
                        <div class="row">
                            <div class="col-md-5 col-sm-4 col-xs-4">
                                <h1 class="page-title">VIEW Inmate Details</h1>
                            </div>
                            <div class="col-md-7 col-sm-8">
                                <div class="row">
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <div class=" ">
        <!-- content start -->
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="wrapper-content bg-white pinside40">
                        <div class="contact-form mb60">
                            <div class=" ">
                                <div class="col-md-offset-2 col-md-8 col-sm-12 col-xs-12">
                                    <div class="mb60  section-title text-center  ">
                                        <!-- section title start-->
                                        <h1>VIEW Inmate Details</h1>
                                        <p>Search For Inmate Using Any of The Fields Below FOR VIEW ONLY</p>
                                        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <form class="contact-us" method="post" action="contact-us.php">
                                        <div class=" ">
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>
                                                    <%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
                                                    <asp:TextBox ID="txtInmateName" runat="server" placeholder="inmate name" class="form-control input-md"></asp:TextBox>
                                                    <%--                                                    <asp:RequiredFieldValidator ID="rfvfirstname" runat="server" ErrorMessage="***" ControlToValidate="txtFirstname" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                                                </div>
                                            </div>
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label class="sr-only control-label" for="email">Email<span class=" "> </span></label>
                                                    <%--                                                    <input id="email" name="email" type="email" placeholder="Email" class="form-control input-md" required>--%>
                                                    <asp:TextBox ID="txtInmateNo" runat="server" placeholder="Inmate's Unique Number" class="form-control input-md"></asp:TextBox>
                                                    <%--                                                    <asp:RequiredFieldValidator ID="rfvlastname" runat="server" ErrorMessage="***" ControlToValidate="txtLastname"></asp:RequiredFieldValidator>--%>
                                                </div>
                                            </div>
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label class="sr-only control-label" for="phone">Phone<span class=" "> </span></label>
                                                    <%--                                                    <input id="phone" name="phone" type="text" placeholder="Phone" class="form-control input-md" required>--%>
                                                    <asp:DropDownList ID="drpBranch" runat="server" class="form-control input-md"></asp:DropDownList><br />
                                                    <%--                                                    <asp:RequiredFieldValidator ID="rfvOtherNames" runat="server" ErrorMessage="***" ControlToValidate="txtOthernames"></asp:RequiredFieldValidator>--%>
                                                    <%--                                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password mismatch" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:CompareValidator>--%>
                                                </div>
                                            </div>



                                            <!-- Select Basic -->

                                            <!-- Button -->
                                            <div class="col-md-12 col-xs-12">
                                                <asp:Button ID="btnSearch" runat="server" Text="SEARCH" class="btn btn-default" />
                                                <%--<button type="submit" class="btn btn-default">Submit</button>--%>
                                            </div>
                                            <br />
                                            <br />
                                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="PrisonerID" Visible="False" Caption="INMATES DETAILS" CaptionAlign="Top" AllowPaging="True" OnPageIndexChanging="OnPageIndexChangingInmate">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="S/N">
                                                        <ItemTemplate>
                                                            <%# Container.DataItemIndex + 1 %>
                                                        </ItemTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                        <ItemStyle HorizontalAlign="Center" />
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="INMATE ID">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblInmateNo" runat="server" Text='<%#Eval("PrisonerID")%>' />
                                                        </ItemTemplate>


                                                    </asp:TemplateField>
                                                     <asp:TemplateField HeaderText="FULLNAMES">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblName" runat="server" Text='<%#Eval("InmateName")%>' />
                                                        </ItemTemplate>


                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="GENDER">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender")%>' />
                                                        </ItemTemplate>


                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="STATE OF ORIGIN">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblState" runat="server" Text='<%#Eval("stateOforigin")%>' />
                                                        </ItemTemplate>


                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="PRISON BRANCH">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblBranch" runat="server" Text='<%#Eval("Branch")%>' />
                                                        </ItemTemplate>


                                                    </asp:TemplateField>

                    

                                                    <asp:HyperLinkField DataNavigateUrlFields="PrisonerID" DataNavigateUrlFormatString="ViewInmates.aspx?PrisonerID={0}" DataTextField="PrisonerID" DataTextFormatString="View Details for {0}" HeaderText="VIEW DETAILS" />

                                                </Columns>
                                            </asp:GridView>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <!-- /.section title start-->
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
                <asp:TextBox ID="TextBox8" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>

