<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/Main.master" CodeFile="EntryBrand.aspx.cs" Inherits="EntryBrand" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <%--<h5 class="txt-dark">Brand List</h5>--%>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">Brand Entry Form</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
                        
                      <div class="form-group">
                         <%--<label class="form-control-label">BrandCode: <span class="tx-danger"></span></label>--%>
                         <asp:TextBox ID="txtbcode" Visible="false" class="form-control" placeholder="Enter brandcode" runat="server" required="true"></asp:TextBox>
                        </div>
                         <div class="form-group">
                           <label class="form-control-label">BrandName: <span class="tx-danger"></span></label>
                        <asp:TextBox ID="txtbname" class="form-control" placeholder="Enter brandname" runat="server" required="true" oninvalid="this.setCustomValidity('Enter brandname for eg. Honda')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                            </div>
                        <div class="form-group text-left m-b-0">
                        <asp:Button ID="btnsave"  runat="server" OnClick="btnsave_Click" class=" btn btn-default btn-default" Text="Save"  /> &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnback" runat="server"  class="btn  btn-primary btn-default" Text="Back" OnClick="btnback_Click" />
                           </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
