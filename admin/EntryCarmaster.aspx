<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/admin/Main.master" CodeFile="EntryCarmaster.aspx.cs" Inherits="EntryCarmaster" %>

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
                        <h6 class="panel-title txt-dark">Car Entry Form</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
                        <div class="form-group">
                         <%--<label class="form-control-label">Car Code:: <span class="tx-danger"></span></label>--%>
                         <asp:TextBox ID="txtcarcode" Visible="false" class="form-control" placeholder="Enter carcode" runat="server" required="true"></asp:TextBox>
                        </div>
                         <div class="form-group">
                           <label class="form-control-label">Car Name: <span class="tx-danger"></span></label>
                        <asp:TextBox ID="txtcarname" class="form-control" placeholder="Enter carname" runat="server" required="true" oninvalid="this.setCustomValidity('Enter brandname for eg. Honda')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                            </div>

                                <div class="form-group">
                           <label class="form-control-label">Model Name:<span class="tx-danger"><br />
                                    </span></label>
                            <asp:DropDownList ID="DropDownList1" class="form-control" placeholder="Select" runat="server"  required="true" AutoPostBack="True">
                                </asp:DropDownList>
                            &nbsp;
                                    
                                    <div class="form-group">
                           <label class="form-control-label">Car Photo: <span class="tx-danger"></span></label>
                        <asp:TextBox ID="txtphoto" class="form-control" visible="false" runat="server" required="true" oninvalid="this.setCustomValidity('Enter brandname for eg. Honda')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                            <asp:FileUpload ID="FileUpload1" class="form-control" runat="server" />

                        <div class="form-group text-left m-b-0">
                            <br />
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
