<%@ Page Language="VB" AutoEventWireup="false" CodeFile="changePassword.aspx.vb" Inherits="changePassword" EnableEventValidation="false" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>HCC - Password Change</title>
    <!-- Bootstrap -->
    <link href="csss/bootstrap.min.css" rel="stylesheet">
    <link href="csss/style.css" rel="stylesheet">
    <link href="csss/font-awesome.min.css" rel="stylesheet">
    <link href="csss/fontello.css" rel="stylesheet">
    <link rel="stylesheet" type="text/csss" href="csss/animsition.min.css">
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700|Merriweather:300,300i,400,400i,700,700i" rel="stylesheet">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body class="animsition">

  
      
    <form id="form1" runat="server">
<%--    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
          <ajaxToolkit:CalendarExtender ID="CalendarDOB" runat="server" 
            TargetControlID="txtDOB" format="dd/MM/yyyy">
        </ajaxToolkit:CalendarExtender>--%>
    <div class="collapse searchbar" id="searchbar">
        <div class="search-area">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
            <button class="btn btn-default" type="button">Go!</button>
            </span> </div>
                        <!-- /input-group -->
                    </div>
                    <!-- /.col-lg-6 -->
                </div>
            </div>
        </div>
    </div>
    <div class="top-bar">
        <!-- top-bar -->
        <div class="container">
            <div class="row">
                <div class="col-md-4 hidden-xs hidden-sm">
                    <p class="mail-text">SAVANNAH</p>
                </div>
                <%--<div class="col-md-8 col-sm-12 text-right col-xs-12">
                    <div class="top-nav"> <span class="top-text hidden-xs"><a href="#">View Locations</a> </span> <span class="top-text"><a href="#">+1800-123-4567</a></span> <span class="top-text"><a href="#">EMI calculator</a></span> </div>
                </div>--%>
            </div>
        </div>
    </div>
    <!-- /.top-bar -->
    <div class="header">
        <div class="container">
            <div class="row">
                <div class="col-md-2 col-sm-12 col-xs-6">
                    <!-- logo -->
                    <div class="logo">
                        <a href="default.aspx"><img src="images/dangote.png" alt="cane Weigh"></a>
                    </div>
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
                            <div class="col-md-4 col-sm-5">
                                <h1 class="page-title">Change Password!</h1><br />
                                <asp:Label ID="Label1" runat="server" Text="New password must contain at least one number and one special character" Font-Bold="True" ForeColor="#FF0066"></asp:Label>
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
                                        <%--<h1>Registration</h1>
                                        <p>Please Provide Accurate Details</p>--%>
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
                                                    <asp:TextBox ID="txtOldPassword" runat="server" placeholder="old password" class="form-control input-md" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvOldPassword" runat="server" ErrorMessage="***" ControlToValidate="txtOldPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label class="sr-only control-label" for="email">Email<span class=" "> </span></label>
<%--                                                    <input id="email" name="email" type="email" placeholder="Email" class="form-control input-md" required>--%>
                                                    <asp:TextBox ID="txtNewPassword" runat="server" placeholder="New password" class="form-control input-md" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvNewPassword" runat="server" ErrorMessage="***" ControlToValidate="txtNewPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="rfvPassword" runat="server" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$" ControlToValidate="txtNewPassword" ErrorMessage="Minimum 8 characters, at least 1 Alphabet, 1 Number and 1 Special Character" ForeColor="Red"></asp:RegularExpressionValidator>
                                                </div>
                                            </div>
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label class="sr-only control-label" for="phone">Phone<span class=" "> </span></label>
<%--                                                    <input id="phone" name="phone" type="text" placeholder="Phone" class="form-control input-md" required>--%>
                                                    <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="confirm new password" class="form-control input-md" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvCOnfirmPassword" runat="server" ErrorMessage="***" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password mismatch" ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:CompareValidator>
                                                </div>
                                            </div>

                                            
                                            <!-- Select Basic -->
                                            
                                            <!-- Button -->
                                            <div class="col-md-12 col-xs-12">
                                                <asp:Button ID="btnLogin" runat="server" Text="SUbmit" class="btn btn-default"/>
                                                <%--<button type="submit" class="btn btn-default">Submit</button>--%>
                                            </div>
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
            <td><asp:TextBox ID="txtUsername" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtRole" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtBranch" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtDepartment" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="txtStaffID" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtCount" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="TextBox7" Visible="false" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="TextBox8" Visible="false" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <!-- /.content end -->
    
    <!-- /.footer -->
     <div class="tiny-footer">
        <!-- tiny footer -->
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-6 col-xs-6">
                    <p>© Copyright 2018 | DANCOM</p>
                </div>
                <div class="col-md-6 col-sm-6 text-right col-xs-6">
                    <p>Terms of use | Privacy Policy</p>
                </div>
            </div>
        </div>
    </div>
    <!-- /.tiny footer -->
    <!-- /.tiny footer -->
    <!-- back to top icon -->
    <a href="#0" class="cd-top" title="Go to top">Top</a>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="jss/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="jss/bootstrap.min.js"></script>
    <script type="text/javascript" src="jss/menumaker.js"></script>
    <!-- animsition -->
    <script type="text/javascript" src="jss/animsition.js"></script>
    <script type="text/javascript" src="jss/animsition-script.js"></script>
    <!-- sticky header -->
    <script type="text/javascript" src="jss/jquery.sticky.js"></script>
    <script type="text/javascript" src="jss/sticky-header.js"></script>
    <!-- Back to top script -->
    <script src="jss/back-to-top.js" type="text/javascript"></script>
    <script>
        function initMap() {
            var myLatLng = {
                lat: 23.0225,
                lng: 72.5714
            };

            var map = new google.maps.Map(document.getElementById('googleMap'), {
                zoom: 8,
                center: myLatLng,
                scrollwheel: false,

            });
            var image = 'images/map-pin.png';
            var marker = new google.maps.Marker({
                position: myLatLng,
                map: map,
                icon: image,
                title: 'Hello World!'

            });
        }
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?&callback=initMap" async defer></script>
        </form>
</body>

</html>

