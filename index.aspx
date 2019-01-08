<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Harvester Control Center </title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Ship Industry Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- font files -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.2/css/font-awesome.min.css" media="all" rel="stylesheet" type="text/css"/>
<link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'/>
<!-- /font files -->
<!-- css files -->
<link href="Assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" media="all" />
<link href="Assets/css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all" />
<link href="Assets/css/typo.css" rel="stylesheet" type="text/css" media="all"/>
<link href="Assets/css/portfolio.css" rel="stylesheet" type="text/css" media="all"/>
<link href="Assets/css/serv.css" rel="stylesheet" type="text/css" media="all"/>
<link href="Assets/css/nav.css" rel="stylesheet" type="text/css" media="all"/>
<link href="Assets/css/style.css" rel="stylesheet" type="text/css" media="all"/>
<!-- /css files -->
<!-- js files -->
<script src="Assets/js/modernizr.custom.js"></script>
<!-- /js files -->

</head>

<body style="background-image:url(images/canePlant.PNG);background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server">
    
    <section class="banner">
        <div class="row" style="margin:0;">
            <div class="col-md-3 col-md-offset-4" style="margin-top:156px;">
                <div class="wrapper-content bg-white pinside40">
                    <% if (labelErrorShow) Then %>
                    <div class="alert alert-danger">
                        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    </div>
                    <% End If %>
                    <div class="col-md-12 text-center" style="margin-top: 16px;">
                        <img src="images/dangote.png" />
                    </div>

                    <div class="col-md-12">
                        <div class="bg-light pinside40 outline">
                            <br />
                            <asp:TextBox ID="txtUsername" runat="server" class="form-control" placeholder="username"></asp:TextBox>
                        </div>
                        <br />
                        <div class="bg-light pinside40 outline">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="password" class="form-control" placeholder="password"></asp:TextBox>
                            <br />
                            <br />
                        </div>                                
                    </div>
                                
                    <div class="col-md-12">
                        <asp:Button ID="btnLogin" runat="server" Text="LOGIN" class="btn btn-default custom pull-right" />
                    </div>                                                             
                </div>
            </div>
        </div>


    </section>
<a href="#0" class="cd-top">Top</a>
		</form>		

<script src="Assets/js/jquery.min.js"></script>
<script src="Assets/js/bootstrap.min.js"></script>
<script src="Assets/js/SmoothScroll.min.js"></script>
<script src="Assets/js/top.js"></script>

    <style type="text/css">
        input:hover,
        input:focus {
            color: #6d8f28;
        }
        .form-control {
            font-family: 'Open Sans', sans-serif; 
            height: 40px;
            color: #6d8f28;
            border: transparent;
            border-radius: initial;
            /*border: 1px solid #6d8f28;*/
        }

        input::-webkit-input-placeholder {
            font-family: 'Open Sans', sans-serif;
          color: #6d8f28 !important;
        }
        input:-moz-placeholder { 
            font-family: 'Open Sans', sans-serif;
          color: #6d8f28 !important;
        }
        input::-moz-placeholder { 
            font-family: 'Open Sans', sans-serif;
          color: #6d8f28 !important;
        }
        input:-ms-input-placeholder {
            font-family: 'Open Sans', sans-serif;
          color: #6d8f28 !important;
        }
        input::-ms-input-placeholder {
            font-family: 'Open Sans', sans-serif;
          color: #6d8f28 !important;
        }
        input::placeholder { 
            font-family: 'Open Sans', sans-serif;
          color: #6d8f28 !important;
        }

        .btn.btn-default.custom {
            font-family: 'Open Sans', sans-serif;
            font-weight: bold;
            font-size: 15px;
            border-radius:initial;
            color: #6d8f28 !important;
        }
    </style>
</body>
</html>
