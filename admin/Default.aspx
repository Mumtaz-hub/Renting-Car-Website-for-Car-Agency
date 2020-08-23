<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>

    <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/core.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/components.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/icons.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/pages.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/responsive.css" rel="stylesheet" type="text/css" />

    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->

    <script src="assets/js/modernizr.min.js"></script>
    <!-- Bracket CSS -->
    <link rel="stylesheet" href="css/bracket.css" />
</head>
<body>
    <div class="account-pages"></div>
    <div class="clearfix"></div>
    <div class="wrapper-page">
        <div class=" card-box">
            <div class="panel-heading">
                <h3 class="text-center">Sign In to <strong class="text-custom">Car Infortainment</strong> </h3>
            </div>


            <div class="panel-body">

                <form id="form1" runat="server">
                    <div class="d-flex align-items-center justify-content-center bg-br-primary ht-100v">
                        <div class="login-wrapper wd-300 wd-xs-350 pd-25 pd-xs-40 bg-white rounded shadow-base">
                            <div class="form-group">
                                <div class="alert alert-danger" id="Alert" runat="server" visible="false">
                                    <a href="#" class="close">&times;</a>
                                    <strong>UserName or Password Not Matched, Please choose valid UserName or Password.</strong>
                                </div>
                            </div>
                            <%--<div class="signin-logo tx-center tx-28 tx-bold tx-inverse"><span class="tx-normal"></span>Car Infortainment <span class="tx-normal"></span></div>
                            <div class="tx-center mg-b-60">Admin Login</div>--%>

                            <div class="form-group">
                                <asp:TextBox ID="txtemail" runat="server" class="form-control" placeholder="Enter your email" type="email" required="true"></asp:TextBox>
                            </div>
                            <!-- form-group -->
                            <div class="form-group">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control" placeholder="Enter your password" required="true"></asp:TextBox>
                                <a href="#" class="tx-info tx-12 d-block mg-t-10">Forgot password?</a>
                            </div>
                            <!-- form-group -->
                            <asp:Button ID="btnLogin" runat="server" Text="Sign In" class="btn btn-info btn-block" OnClick="btnLogin_Click" />
                            <div class="mg-t-60 tx-center">Not yet a member? <a href="Signup.aspx" class="tx-info">Sign Up</a></div>
                        </div>
                        <!-- login-wrapper -->

                        <!-- form-group -->
                    </div>
                    <!-- d-flex -->
                </form>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12 text-center">
                <p>Don't have an account? <a href="Signup.aspx" class="text-primary m-l-5"><b>Sign Up</b></a></p>

            </div>
        </div>

    </div>

    <script>
        var resizefunc = [];
    </script>

    <!-- jQuery  -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/detect.js"></script>
    <script src="assets/js/fastclick.js"></script>
    <script src="assets/js/jquery.slimscroll.js"></script>
    <script src="assets/js/jquery.blockUI.js"></script>
    <script src="assets/js/waves.js"></script>
    <script src="assets/js/wow.min.js"></script>
    <script src="assets/js/jquery.nicescroll.js"></script>
    <script src="assets/js/jquery.scrollTo.min.js"></script>


    <script src="assets/js/jquery.core.js"></script>
    <script src="assets/js/jquery.app.js"></script>
</body>
</html>
