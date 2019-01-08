<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="Loan Officer Website Template">
    <meta name="keywords" content="Team single page, Loan Specialist, Small Business Owner Loan">
    <title>Uch-Ebi - A Loan Company</title>
    <!-- Bootstrap -->
    <link href="csss/bootstrap.min.css" rel="stylesheet">
    <link href="csss/style.css" rel="stylesheet">
    <link href="csss/font-awesome.min.css" rel="stylesheet">
    <link href="csss/fontello.css" rel="stylesheet">
    <link rel="stylesheet" type="text/csss" href="csss/animsition.min.css">
    <link rel="stylesheet" type="text/csss" href="csss/simple-slider.css">
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700|Merriweather:300,300i,400,400i,700,700i" rel="stylesheet">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script src="jss/simple-slider.js"></script>
<link href="csss/simple-slider.css" rel="stylesheet" type="text/css" />
</head>

<body class="animsition">
    <form id="form1" runat="server">

    
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
                        <a href="index.html"><img src="images/logoUchEbi1.png" alt="Borrow - Online Loan System"></a>
                    </div>
                </div>
                <!-- logo -->
                <div class="col-md-9 col-sm-12 col-xs-12">
                    <div id="navigation">
                        <!-- navigation start-->
                       <ul>
                            <li class="active"><a href="Default.aspx" class="animsition-link">Home</a>
                                
                            </li>
                            
                            
                            <li><a href="contact-us.html" title="Contact us" class="animsition-link">Contact us</a></li>
                        </ul>
                    </div>
                    <!-- /.navigation start-->
                </div>
                <div class="col-md-1 hidden-sm">
                    <!-- search start-->
                    <div class="search-nav"> <a class="search-btn" role="button" data-toggle="collapse" href="#searchbar" aria-expanded="false"><i class="fa fa-search"></i></a> </div>
                </div>
                <!-- /.search start-->
            </div>
        </div>
    </div>
    <div class="page-header">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="page-breadcrumb">
                        <ol class="breadcrumb">
                            <li><a href="Default.aspx">Home</a></li>
                            <li class="active">LOGIN</li>
                        </ol>
                    </div>
                </div>
                <div class="col-md-12 col-sm-12 col-xs-12">
                    <div class="bg-white pinside30">
                        <div class="row">
                            <div class="col-md-4 col-sm-5">
                                <h1 class="page-title">Login Page</h1><br />
                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                            </div>
                            
                        </div>
                    </div>
                   
                </div>
            </div>
        </div>
    </div>
    <!-- content start -->
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="wrapper-content bg-white pinside40">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="bg-light pinside40 outline">
                                        User ID <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="bg-light pinside40 outline">
                                        Password <asp:TextBox ID="txtPassword" runat="server" class="form-control"></asp:TextBox>
                                        <br />
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UserRegistration.aspx">Register</asp:HyperLink><asp:Label ID="Label1" runat="server" Text="  if you dont have an account"></asp:Label>
                                    </div>                                
                                </div>
                                
                                <div class="col-md-12">
                                    <asp:Button ID="btnLogin" runat="server" Text="LOGIN" class="btn btn-default"/>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /.content end -->
    </div>
    </div>
    <%--<div class="footer section-space100">
        <!-- footer -->
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="footer-logo">
                        <!-- Footer Logo -->
                        <img src="images/ft-logo.png" alt="Borrow - Loan Company Website Templates"> </div>
                    <!-- /.Footer Logo -->
                </div>
                <div class="col-md-8 col-sm-8 col-xs-12">
                    <div class="col-md-5">
                        <h3 class="newsletter-title">Signup Our Newsletter</h3>
                    </div>
                    <div class="col-md-7">
                        <div class="newsletter-form">
                            <!-- Newsletter Form -->
                            <form action="newsletter.php" method="post">
                                <div class="input-group">
                                    <input type="email" class="form-control" id="newsletter" name="newsletter" placeholder="Write E-Mail Address">
                                    <span class="input-group-btn">
                <button class="btn btn-default" type="button">Go!</button>
                </span> </div>
                                <!-- /input-group -->
                            </form>
                        </div>
                        <!-- /.Newsletter Form -->
                    </div>
                    <!-- /.col-lg-6 -->
                </div>
            </div>
            <hr class="dark-line">
            <div class="row">
                <div class="col-md-6 col-sm-12 col-xs-12">
                    <div class="widget-text mt40">
                        <!-- widget text -->
                        <p>Our goal at Borrow Loan Company is to provide access to personal loans and education loan, car loan, home loan at insight competitive interest rates lorem ipsums. We are the loan provider, you can use our loan product.</p>
                        <div class="row">
                            <div class="col-md-6 col-xs-6">
                                <p class="address-text"><span><i class="icon-placeholder-3 icon-1x"></i> </span>3895 Sycamore Road Arlington, 97812 </p>
                            </div>
                            <div class="col-md-6 col-xs-6">
                                <p class="call-text"><span><i class="icon-phone-call icon-1x"></i></span>800-123-456</p>
                            </div>
                        </div>
                    </div>
                    <!-- /.widget text -->
                </div>
                <div class="col-md-2 col-sm-4 col-xs-6">
                    <div class="widget-footer mt40">
                        <!-- widget footer -->
                        <ul class="listnone">
                            <li><a href="#">Home</a></li>
                            <li><a href="#">Services</a></li>
                            <li><a href="#">About Us</a></li>
                            <li><a href="#">News</a></li>
                            <li><a href="#">Faq</a></li>
                            <li><a href="#">Contact Us</a></li>
                        </ul>
                    </div>
                    <!-- /.widget footer -->
                </div>
                <div class="col-md-2 col-sm-4 col-xs-6">
                    <div class="widget-footer mt40">
                        <!-- widget footer -->
                        <ul class="listnone">
                            <li><a href="#">Car Loan</a></li>
                            <li><a href="#">Personal Loan</a></li>
                            <li><a href="#">Education Loan</a></li>
                            <li><a href="#">Business Loan</a></li>
                            <li><a href="#">Home Loan</a></li>
                            <li><a href="#">Debt Consolidation</a></li>
                        </ul>
                    </div>
                    <!-- /.widget footer -->
                </div>
                <div class="col-md-2 col-sm-4 col-xs-12">
                    <div class="widget-social mt40">
                        <!-- widget footer -->
                        <ul class="listnone">
                            <li><a href="#"><i class="fa fa-facebook"></i>Facebook</a></li>
                            <li><a href="#"><i class="fa fa-google-plus"></i>Google Plus</a></li>
                            <li><a href="#"><i class="fa fa-twitter"></i>Twitter</a></li>
                            <li><a href="#"><i class="fa fa-linkedin"></i>Linked In</a></li>
                        </ul>
                    </div>
                    <!-- /.widget footer -->
                </div>
            </div>
        </div>
    </div>--%>
    <!-- /.footer -->
    <div class="tiny-footer">
        <!-- tiny footer -->
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-6 col-xs-6">
                    <p>© Copyright 2016 | Uch-Ebi</p>
                </div>
                <div class="col-md-6 col-sm-6 text-right col-xs-6">
                    <p>Terms of use | Privacy Policy</p>
                </div>
            </div>
        </div>
    </div>
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
    <script type="text/javascript" src="jss/simple-slider.js"></script>
    <script type="text/javascript" src="jss/calculator.js"></script>

        </form>
</body>

</html>