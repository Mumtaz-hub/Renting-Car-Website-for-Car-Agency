<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListCarPUC.aspx.cs" MasterPageFile="~/admin/Main.master" Inherits="admin_ListCarPUC" %>


<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">CarPUC List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of CarPUC</h6>
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
                           
                             
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" DataKeyNames="PUCCode" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                               
                    <asp:BoundField DataField="PUCCode" HeaderText="PUC Code" />
                    <asp:BoundField DataField="CarCode" HeaderText="Car Code" />
                    <asp:BoundField DataField="PUCDate" HeaderText="PUC Date" />
                    <asp:BoundField DataField="PUCNo" HeaderText="PUC Number" />
                    <asp:BoundField DataField="Validity" HeaderText="Validity" />
                    <asp:BoundField DataField="ExpDate" HeaderText="Expiry Date" />
                    <asp:BoundField DataField="AgencyName" HeaderText="Agency Name" />
                    <asp:BoundField DataField="Username" HeaderText="User Name" />
                            
                          
                            
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
