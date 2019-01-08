<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UserRegistration.aspx.vb" Inherits="UserRegistration" EnableEventValidation="false" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Borrow - A Loan Company Website Templates</title>
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
                    <p class="mail-text">Welcome to our Borrow Loan Website Templates</p>
                </div>
                <div class="col-md-8 col-sm-12 text-right col-xs-12">
                    <div class="top-nav"> <span class="top-text hidden-xs"><a href="#">View Locations</a> </span> <span class="top-text"><a href="#">+1800-123-4567</a></span> <span class="top-text"><a href="#">EMI calculator</a></span> </div>
                </div>
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
                        <a href="default.aspx"><img src="images/logoUchEbi1.png" alt="Borrow - Loan Company Website Template"></a>
                    </div>
                </div>
                <!-- logo -->
               
               <%-- <div class="col-md-1 hidden-sm">
                    <!-- search start-->
                    <div class="search-nav"> <a class="search-btn" role="button" data-toggle="collapse" href="#searchbar" aria-expanded="false"><i class="fa fa-search"></i></a> </div>
                </div>--%>
                <!-- /.search start-->
            </div>
        </div>
    </div>
    <div class="page-header">
        <div class="container">
            <div class="row">
                <%--<div class="col-md-12">
                    <div class="page-breadcrumb">
                        <ol class="breadcrumb">
                            <li><a href="index.html">Home</a></li>
                            <li class="active">Contact us</li>
                        </ol>
                    </div>
                </div>--%>
                <div class="col-md-12 col-sm-12 col-xs-12">
                    <div class="bg-white pinside30">
                        <div class="row">
                            <div class="col-md-4 col-sm-5">
                                <h1 class="page-title">Register An Acount</h1>
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
                                        <h1>Registration</h1>
                                        <p>Please Provide Accurate Details</p>
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
                                                    <asp:TextBox ID="txtUsername" runat="server" placeholder="UserName" class="form-control input-md"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="***" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label class="sr-only control-label" for="email">Email<span class=" "> </span></label>
<%--                                                    <input id="email" name="email" type="email" placeholder="Email" class="form-control input-md" required>--%>
                                                    <asp:TextBox ID="txtPassword" runat="server" placeholder="password" class="form-control input-md" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="***" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <!-- Text input-->
                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">
                                                    <label class="sr-only control-label" for="phone">Phone<span class=" "> </span></label>
<%--                                                    <input id="phone" name="phone" type="text" placeholder="Phone" class="form-control input-md" required>--%>
                                                    <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="confirm password" class="form-control input-md" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvCOnfirmPassword" runat="server" ErrorMessage="***" ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>
                                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password mismatch" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:CompareValidator>
                                                </div>
                                            </div>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
                                                   <%-- <asp:TextBox ID="txtFirstname" runat="server" placeholder="First Name" class="form-control input-md"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="***" ControlToValidate="txtFirstname" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>--%>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
                                                  <%--  <asp:TextBox ID="txtLastname" runat="server" placeholder="UserName" class="form-control input-md"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="***" ControlToValidate="txtLastname" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>--%>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
                                             <%--       <asp:TextBox ID="txtEmail" runat="server" placeholder="email" class="form-control input-md" TextMode="Email"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="***" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>--%>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
                                                <%--    <asp:TextBox ID="txtPhone" runat="server" placeholder="phone number" class="form-control input-md" TextMode="Number"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvTel" runat="server" ErrorMessage="***" ControlToValidate="txtPhone" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>--%>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
                                               <%--     <asp:TextBox ID="txtDOB" runat="server" placeholder="date of birth" class="form-control input-md"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ErrorMessage="***" ControlToValidate="txtDOB" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>--%>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
<%--                                                    <asp:DropDownList ID="drpSex" runat="server" class="form-control input-md">
                                                        <asp:ListItem Value="0">-- Select --</asp:ListItem>
                                                        <asp:ListItem Value="1">Female</asp:ListItem>
                                                        <asp:ListItem Value="2">Male</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator ID="rfvSex" runat="server" ErrorMessage="***" ControlToValidate="drpSex" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                                </div>--%>
                                           <%-- </div>--%>
<%--                                            <div class="col-md-4 col-sm-12 col-xs-12">
                                                <div class="form-group">

                                                    <label class="sr-only control-label" for="name">name<span class=" "> </span></label>--%>
<%--                                                    <input id="name" name="name" type="text" placeholder="Name" class="form-control input-md" required>--%>
<%--                                                    <asp:TextBox ID="txtAddress" runat="server" placeholder="address" class="form-control input-md" TextMode="MultiLine"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvAddy" runat="server" ErrorMessage="***" ControlToValidate="txtAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>--%>
                                            
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
    <!-- /.content end -->
    
    <!-- /.footer -->
     <div class="tiny-footer">
        <!-- tiny footer -->
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-6 col-xs-6">
                    <p>© Copyright 2016 | Borrow Loan Company</p>
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
