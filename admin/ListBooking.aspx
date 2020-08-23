<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/Main.master" CodeFile="ListBooking.aspx.cs" Inherits="admin_ListBooking" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">Booking List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of Booking Customer</h6>
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
                           
                             
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" DataKeyNames="BookingCode" OnRowEditing="GridView1_RowEditing" >
                            <Columns>
                                <asp:BoundField DataField="BookingCode" HeaderText="Booking Code" />
                    <asp:BoundField DataField="CustCode" HeaderText="Customer Code" />
                    <asp:BoundField DataField="PickupDate" HeaderText="Pickup Date" />
                    <asp:BoundField DataField="DropDate" HeaderText="Drop Date" />
                    <asp:BoundField DataField="CarCode" HeaderText="Car Code" />
                    <asp:BoundField DataField="DriverCode" HeaderText="Driver Code" />
                    <asp:BoundField DataField="Passengers" HeaderText="No. of Passengers" />
                    <asp:BoundField DataField="PickupAddress" HeaderText="Pickup Address" />
                    <asp:BoundField DataField="DropAddress" HeaderText="Drop Address" />
                    <asp:BoundField DataField="Remark" HeaderText="Remark" />
                    
                            
                            
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
