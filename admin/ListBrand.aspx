<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/Main.master" CodeFile="ListBrand.aspx.cs" Inherits="ListBrand" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">Brand List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of Brand</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
                            <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click"  class=" btn btn-info btn-rounded" Text="Add New" />
                           
                             
                                <br />
                                <br />
                           
                             
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" DataKeyNames="BrandCode" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                                <asp:BoundField DataField="BrandCode" HeaderText="Brand Code" />
                                <asp:BoundField DataField="BrandName" HeaderText="Brand Name" />
                                <asp:CommandField ShowEditButton="True" ButtonType="Button">
                            <ControlStyle CssClass="btn btn-xs btn-info btn-success btn-outline btn-rounded" />
                            </asp:CommandField>
                            
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