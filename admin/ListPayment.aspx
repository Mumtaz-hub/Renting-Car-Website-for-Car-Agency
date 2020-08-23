<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/admin/Main.master" CodeFile="ListPayment.aspx.cs" Inherits="admin_ListPayment" %>



<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">Payment List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">Payment Details</h6>
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
                           
                             
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" DataKeyNames="PaymentCode" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                               <asp:BoundField DataField="PaymentCode" HeaderText="Payment Code" />
                    <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
                    <asp:BoundField DataField="CustCode" HeaderText="Customer Code" />
                    <asp:BoundField DataField="Amount" HeaderText="Total Amount" />
                    <asp:BoundField DataField="ReferenceNo" HeaderText="Reference No" />
                    <asp:BoundField DataField="ReferenceDate" HeaderText="Reference Date" />
                    <asp:BoundField DataField="Mode" HeaderText="Mode of Payment" />
                    <asp:BoundField DataField="BankName" HeaderText="Bank Name" />
                    <asp:BoundField DataField="ChequeNo" HeaderText="Cheque Number" />
                    <asp:BoundField DataField="ChequeDate" HeaderText="ChequeDate" />
                            
                            
                            
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

