<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="admin_Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>New Admin User Signup</title>

    <!-- Favicon -->
		<link rel="shortcut icon" href="favicon.ico"/>
		<link rel="icon" href="favicon.ico" type="image/x-icon"/>
		
		<!-- vector map CSS -->
        <link href="../vendors/bower_components/jasny-bootstrap/dist/css/jasny-bootstrap.min.css" rel="stylesheet" type="text/css" />
		
		
		
		<!-- Custom CSS -->
        <link href="../dist/css/style.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <!--Preloader-->
    <div class="preloader-it">
        <div class="la-anim-1"></div>
    </div>
    <!--/Preloader-->

    <div class="wrapper pa-0">
        <header class="sp-header">
            <div class="sp-logo-wrap pull-left">
                <a href="index.html">
                    <img class="brand-img mr-10" src="../dist/img/logo.png" alt="brand" />
                    <span class="brand-text">Car-Infotainment</span>
                </a>
            </div>
            <div class="form-group mb-0 pull-right">
                <span class="inline-block pr-10">Already have an account?</span>
                <a class="inline-block btn btn-info btn-rounded btn-outline" href="default.aspx">LogIn</a>
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
                                        <h3 class="text-center txt-dark mb-10">Sign up </h3>
                                        <h6 class="text-center nonecase-font txt-grey">Enter your details below</h6>
                                    </div>
                                    <div class="form-wrap">
                                        <form id="form1" runat="server">


                                            <div class="form-group">
                                                <asp:TextBox ID="txtfname" runat="server" class="form-control" placeholder="Enter your fullname" required="true" oninvalid="this.setCustomValidity('Enter Full Name for eg. John Shah')"
                                                 oninput="setCustomValidity('')"></asp:TextBox>
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group">
                                                <asp:TextBox ID="txtuname" runat="server" class="form-control" placeholder="Enter username" required="true"></asp:TextBox>
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group">
                                                <asp:TextBox ID="txtemail" runat="server" class="form-control" placeholder="Enter your email" type="email" required="true" oninvalid="this.setCustomValidity('Enter valid email for eg. john@gmail.com')"
                                                oninput="setCustomValidity('')"></asp:TextBox>
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group">
                                                <asp:TextBox ID="txtpswd" runat="server" class="form-control" placeholder="Enter your password" required="true" TextMode="Password"></asp:TextBox>
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group">
                                                <asp:TextBox ID="txtmno" runat="server" class="form-control" placeholder="Enter your mobile number" required="true" pattern="^\d{10}$" oninvalid="this.setCustomValidity('Enter valid format for eg. 9099876532')"
                                                oninput="setCustomValidity('')"></asp:TextBox>
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group">
                                                <asp:DropDownList ID="utype" runat="server" class="form-control" placeholder="User Type ">
                                                    <asp:ListItem>Admin</asp:ListItem>
                                                    <asp:ListItem>Operator</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group">
                                                <asp:CheckBox ID="chkStatus" runat="server" class="form-control" Checked="true" Text="Is Active" />
                                            </div>
                                            <!-- form-group -->

                                            <div class="form-group text-center">By clicking the Sign Up button below, you agreed to our privacy policy and terms of use of our website.
                                            <asp:Button ID="btnsignup" runat="server" Text="Sign In"  class=" btn btn-info btn-rounded" OnClick="btnsignup_Click" /></div>
                                            <%--<div class="mg-t-40 tx-center">Not yet a member? <a href="Login.aspx" class="tx-info">Login</a></div>--%>



                                            <!-- login-wrapper -->
                                            <div class="form-group">
                                                <div class="alert alert-danger" id="Alert" runat="server" visible="false"></div>
                                            </div>

                                            <!-- d-flex -->
                                        </form>

                                    </div>
                                </div>
                            </div>
                        </div>
                        }
                    </div>
                </div>
            </div>
        </div>
    </div>
<!-- JavaScript -->
		
		<!-- jQuery -->
        <script src="../vendors/bower_components/jquery/dist/jquery.min.js"></script>
		
		<!-- Bootstrap Core JavaScript -->
        <script src="../vendors/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
        <script src="../vendors/bower_components/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"></script>
		
		<!-- Slimscroll JavaScript -->
        <script src="../dist/js/jquery.slimscroll.js"></script>
		
		<!-- Init JavaScript -->
        <script src="../dist/js/init.js"></script>
</body>
</html>
