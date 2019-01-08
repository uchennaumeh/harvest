<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<!DOCTYPE html>

    <html lang="en" class="body-full-height">
        <head>        
            <!-- META SECTION -->
            <title>::Harvester Control Center::</title>            
            <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
            <meta http-equiv="X-UA-Compatible" content="IE=edge" />
            <meta name="viewport" content="width=device-width, initial-scale=1" />
        
            <!-- END META SECTION -->
        
            <!-- CSS INCLUDE -->        
            <link rel="stylesheet" type="text/css" id="theme" href="css/theme-default.css"/>
            <!-- EOF CSS INCLUDE -->                                    
        </head>
        <body>
         <div class="login-container">
             <br /><br />
        <div align="center"><asp:Image ID="Image1" runat="server" ImageUrl="~/images/DangoteWhyt.png" Height="125px" Width="235px" /></div>
            <div class="login-box animated fadeInDown">
               <%-- <div class="login-logo"></div>--%>
                
                <div class="login-body">
                    <div class="login-title"><strong>Welcome</strong>, Please login
                        <asp:Label ID="lblError" class="btn btn-link btn-block" runat="server"></asp:Label>

                    </div>
                    <form id="form1" class="form-horizontal" runat="server">
                    <div class="form-group">
                        <div class="col-md-12">
                            <asp:TextBox ID="txtUsername" runat="server" class="form-control" placeholder="username" AutoCompleteType="DisplayName"></asp:TextBox>
                        </div>
                        
                    </div>
                    <div class="form-group">
                        <div class="col-md-12">
                            <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-6">
                            <%--<asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White">Forgot your password?</asp:HyperLink>--%>
                            <%--<asp:LinkButton ID ="lnlbtnForget" runat="server" class="btn btn-link btn-block">Forgot your password? </asp:LinkButton>--%> 
                        </div>
                        <div class="col-md-6">
                           <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-info btn-block" />
                        </div>
                    </div>
                    </form>
                </div>
                <div class="login-footer">
                    <div class="pull-left">
                        &copy; 2018 HCC Pro By Applications Team
                    </div>
                    <div class="pull-right">
                      
                        <%--<a href="#">Contact Us</a>--%>
                    </div>
                </div>
            </div>
            
        </div>
        
    </body>
</html>
