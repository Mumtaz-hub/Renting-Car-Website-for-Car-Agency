<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Main.master" AutoEventWireup="true" CodeFile="ListCustomer.aspx.cs" Inherits="ListCustomer" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">Customer List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of Customers</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
                                <%--<asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click"  class=" btn btn-info btn-rounded" Text="Add New" />--%>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustCode" OnRowEditing="GridView1_RowEditing" CssClass="table table-striped table-bordered">
                                    <Columns>
                                        <asp:BoundField DataField="CustCode" HeaderText="Customer Code" />
                                        <asp:BoundField DataField="CustName" HeaderText="Customer Name" />
                                        <%--<asp:BoundField DataField="UserName" HeaderText="Users Name" />--%>
                                        <asp:BoundField DataField="Address" HeaderText="Address" />
                                        <asp:BoundField DataField="Telephone" HeaderText="Telephone" />
                                        <asp:BoundField DataField="Mobile" HeaderText="Mobile No" />
                                        <asp:BoundField DataField="Email" HeaderText="Email ID" />
                                        
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

