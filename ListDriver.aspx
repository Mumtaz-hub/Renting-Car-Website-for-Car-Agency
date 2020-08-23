<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeFile="ListDriver.aspx.cs" Inherits="ListDriver" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
 <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark"></h5>
        </div>
        <!-- Breadcrumb -->
        <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            <ol class="breadcrumb">

                <li class="active"><span></span></li>
            </ol>
        </div>
        <!-- /Breadcrumb -->
    </div>
    <!-- /Title -->
    <!-- Row -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of Driver Details</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <asp:Button ID="btnadd" runat="server" style="margin-bottom:20px;" Text="Add New" CssClass="btn btn-primary btn-rounded btn-icon left-icon" OnClick="btnadd_Click"/>

                    <div class="table-responsive" >
                       
                                <asp:GridView ID="GridView1" runat="server" CssClass="table mb-0"  AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" DataKeyNames="DCode">
                                     <Columns>
                    <asp:BoundField DataField="DCode" HeaderText="Driver Code" />
                    <asp:BoundField DataField="DriverName" HeaderText="Driver Name" />
                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile Number" />
                    <asp:BoundField DataField="ResidentAddress" HeaderText="Resident Address" />
                    <asp:BoundField DataField="LicenseNo" HeaderText="License Number" />
                    <asp:BoundField DataField="LicenseExpDate" HeaderText="License Expiry Date" />
                    <asp:BoundField DataField="DriverPhoto" HeaderText="Driver Photo" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:CommandField ShowEditButton="True" />
                    
                </Columns>
                                </asp:GridView>
                            </div>
                        </div>  
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>