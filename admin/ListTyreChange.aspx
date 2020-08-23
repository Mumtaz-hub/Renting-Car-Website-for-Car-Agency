<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListTyreChange.aspx.cs" MasterPageFile="~/admin/Main.master" Inherits="admin_ListTyreChange" %>



<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">List of TyreChange</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">TyreChange Data</h6>
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
                           
                             
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" DataKeyNames="TCCode" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                               <asp:BoundField DataField="TCCode" HeaderText="Tyre Change Code" />
                    <asp:BoundField DataField="TyreChangeDate" HeaderText="Tyre Change Date" />
                    <asp:BoundField DataField="Kilometers" HeaderText="Total Kilometers" />
                    <asp:BoundField DataField="TyreBrand" HeaderText="Tyre Brand" />
                    <asp:BoundField DataField="TyreSide" HeaderText="Tyre Side" />
                    <asp:BoundField DataField="Remould" HeaderText="Remould" />
                            
                           
                            
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

