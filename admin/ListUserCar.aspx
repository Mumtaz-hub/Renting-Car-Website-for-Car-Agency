<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Main.master" AutoEventWireup="true" CodeFile="ListUserCar.aspx.cs" Inherits="admin_ListUserCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">User's Car List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of User's Car</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
    
                          
                                <br />
                                <br />
                
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CarCode" OnRowEditing="GridView1_RowEditing" CssClass="table table-striped table-bordered">
                        <Columns>
                            <asp:BoundField DataField="UCcode" HeaderText="User Car Code" />
                            <asp:BoundField DataField="Carcode" HeaderText="Car Code" />
                            <asp:BoundField DataField="BrandCode" HeaderText="Brand" />
                            <asp:BoundField DataField="RegNo" HeaderText="Reg No" />
                            <asp:BoundField DataField="EngineNo" HeaderText="Engine No" />
                            <asp:BoundField DataField="ChasisNo" HeaderText="Chasis No" />
                            <asp:BoundField DataField="BuyDate" HeaderText="Buy Date" />
                            <asp:BoundField DataField="UserName" HeaderText="User Name" />
                            <asp:BoundField DataField="Status" HeaderText="Status" />
                            <asp:BoundField DataField="TransmissionMode" HeaderText="Transmission Mode" />
                            <asp:BoundField DataField="FuelType" HeaderText="Fuel Type" />
                            <asp:BoundField DataField="ModelYear" HeaderText="Model Year" />
                            
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

