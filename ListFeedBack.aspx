<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ListFeedBack.aspx.cs" Inherits="ListFeedBack" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
 <!-- Title -->
    <div class="row heading-bg">
        <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
            <h5 class="txt-dark"></h5>
        </div>
        <!-- Breadcrumb -->
        <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12">
            <ol class="breadcrumb">

                <li class="active"><span></span></li>
            </ol>
        </div>
        <!-- /Breadcrumb -->
    </div>
    <!-- /Title -->
    <!-- Row -->
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default card-view">
                <div class="panel-heading">
                    <div class="pull-left">
                        <h6 class="panel-title txt-dark">FeedBack List</h6>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="panel-wrapper collapse in">
                    <div class="panel-body">
                        <div class="table-wrap">
                            <asp:Button ID="btnadd" runat="server" style="margin-bottom:20px;" Text="Add FeedBack" CssClass="btn btn-primary btn-rounded btn-icon left-icon" OnClick="btnadd_Click"/>
                           
                             <div class="table-responsive" >
                       
                                <asp:GridView ID="GridView1" runat="server" CssClass="table mb-0"  AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" DataKeyNames="FBCode">
                                     <Columns>
                    <asp:BoundField DataField="FBCode" HeaderText="FeedBack Code" />
                                        <asp:BoundField DataField="FBDate" HeaderText="FeedBack Date" />
                                        <asp:BoundField DataField="FBTitle" HeaderText="FeedBack Title" />
                                        <asp:BoundField DataField="ShortDescription" HeaderText="Short Description" />
                                        <%--<asp:BoundField DataField="Username" HeaderText="Username" />--%>
                    <%--<asp:CommandField ShowEditButton="True" />--%>
                    
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

