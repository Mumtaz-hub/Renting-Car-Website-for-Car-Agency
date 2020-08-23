<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/Main.master" CodeFile="ListDriver.aspx.cs" Inherits="admin_ListDriver" %>


<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">Driver Data</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">Driver List</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
                            <%--<asp:Button ID="btnview" runat="server" OnClick="btnview_Click"  class=" btn btn-info btn-rounded" Text="View" />--%>
                           
                             
                                <br />
                                <br />
                           
                             
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" DataKeyNames="DCode" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                                <asp:BoundField DataField="DCode" HeaderText="Driver Code" />
                    <asp:BoundField DataField="DriverName" HeaderText="Driver Name" />
                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile Number" />
                    <asp:BoundField DataField="ResidentAddress" HeaderText="Resident Address" />
                    <asp:BoundField DataField="LicenseNo" HeaderText="License Number" />
                    <asp:BoundField DataField="LicenseExpDate" HeaderText="License Expiry Date" />
                    <asp:BoundField DataField="DriverPhoto" HeaderText="Driver Photo" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                           
                            
                            
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
