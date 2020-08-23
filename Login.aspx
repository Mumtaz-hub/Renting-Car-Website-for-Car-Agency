<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login</title>
    <!-- Favicon -->
    <link rel="shortcut icon" href="favicon.ico"/>
    <link rel="icon" href="favicon.ico" type="image/x-icon"/>

    <!-- vector map CSS -->
    <link href="vendors/bower_components/jasny-bootstrap/dist/css/jasny-bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom CSS -->
    <link href="dist/css/style.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <!--Preloader-->
    <!--/Preloader-->

    <div class="wrapper pa-0">
        <header class="sp-header">
            <div class="sp-logo-wrap pull-left">
                <a href="index.html">
                    <img class="brand-img mr-10" src="dist/img/logo.png" alt="brand" />
                    <span class="brand-text">Car-Infotainment</span>
                </a>
            </div>
            <div class="form-group mb-0 pull-right">
                <span class="inline-block pr-10">Don't have an account?</span>
                <a class="inline-block btn btn-info  btn-rounded btn-outline" href="Signup.aspx">Sign Up</a>
            </div>
            <div class="clearfix"></div>
        </header>

        <!-- Main Content -->
        <div class="page-wrapper pa-0 ma-0 auth-page">
            <div class="container-fluid">
                <!-- Row -->
                <div class="table-struct full-width full-height">
                    <div class="table-cell vertical-align-middle auth-form-wrap">
                        <div class="auth-form  ml-auto mr-auto no-float">
                            <div class="row">
                                <div class="col-sm-12 col-xs-12">
                                    <div class="mb-30">
                                        <h3 class="text-center txt-dark mb-10">Sign In</h3>
                                        <h6 class="text-center nonecase-font txt-grey">Enter valid Login Information</h6>
                                    </div>
                                    <div class="form-wrap">
                                        <form id="form1" runat="server">
                                            <div class="form-group">
                                                <div class="alert alert-danger" id="Alert" runat="server" visible="false">
                                                    <a href="#" class="close">&times;</a>
                                                    <strong>UserName or Password Not Matched, Please choose valid UserName or Password.</strong>
                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <asp:TextBox ID="txtuname" runat="server" class="form-control" placeholder="Enter your username" required="true"></asp:TextBox>
                                            </div>
                                            <!-- form-group -->
                                            <div class="form-group">
                                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control" placeholder="Enter your password" required="true"></asp:TextBox>
                                                <a href="#" class="tx-info tx-12 d-block mg-t-10">Forgot password?</a>
                                            </div>
                                            <!-- form-group -->
                                            <asp:Button ID="btnLogin" runat="server" Text="Sign In" class="btn btn-info  btn-rounded" OnClick="btnLogin_Click" />
                                            <div class="mg-t-60 tx-center">Are you admin? <a href="admin/Default.aspx" class="tx-info">Sign In</a></div>

                                            <!-- login-wrapper -->
                                            
                                            <!-- form-group -->

                                            <!-- d-flex -->
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /Row -->
            </div>

        </div>
        <!-- /Main Content -->

    </div>
    <!-- /#wrapper -->
    <!-- JavaScript -->

    <!-- jQuery -->
    <script src="vendors/bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="vendors/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="vendors/bower_components/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"></script>

    <!-- Slimscroll JavaScript -->
    <script src="dist/js/jquery.slimscroll.js"></script>

    <!-- Init JavaScript -->
    <script src="dist/js/init.js"></script>
</body>
</html>



