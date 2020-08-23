<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Main.master" AutoEventWireup="true" CodeFile="ListFeedBack.aspx.cs" Inherits="ListFeedBack" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark">FeedBack List</h5>
        </div>
    </div>
    <!-- /Title -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">List of FeedBack</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <div class="table-responsive">
                                <%--<asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click"  class=" btn btn-info btn-rounded" Text="Add Feedback" />--%>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="FBCode" OnRowEditing="GridView1_RowEditing" CssClass="table table-striped table-bordered">
                                    <Columns>
                                        <asp:BoundField DataField="FBCode" HeaderText="FeedBack Code" />
                                        <asp:BoundField DataField="FBDate" HeaderText="FeedBack Date" />
                                        <asp:BoundField DataField="FBTitle" HeaderText="FeedBack Title" />
                                        <asp:BoundField DataField="ShortDescription" HeaderText="Short Description" />
                                        <asp:BoundField DataField="Username" HeaderText="Username" />
                                        
                                        
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

