<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryFeedBack.aspx.cs" Inherits="EntryFeedBack" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">FeedBack Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">FBCode:</span></label>--%>
                        <asp:TextBox ID="txtfbcode" Visible="false" placeholder="Enter feedback code" class="form-control" runat="server"></asp:TextBox>
                </div>
                        
                    
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Feedback Date:</span></label>
                       <asp:TextBox ID="txtfbdate"  placeholder="Enter address" class="form-control" runat="server" required="true"></asp:TextBox>
                     </div>
                                <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Feedback Title:</span></label>
                        <asp:TextBox ID="txtfbtitle"  placeholder="Enter title" class="form-control" runat="server" required="true"></asp:TextBox>
                    </div>
                                <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Short Description:</span></label>
                        <asp:TextBox ID="txtshortdes"  placeholder="Enter your description" class="form-control" runat="server" required="true"></asp:TextBox>
                    </div>
                                <div class="form-group">
                        <%--<label class="control-label mb-10 text-left"><span class="help">User Name:</span></label>--%>
                        <asp:TextBox ID="txtuname" visible="false" placeholder="Enter username" class="form-control" runat="server" required="true"></asp:TextBox>
                    </div>
                  
                        
                   <div>
                       <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" class="btn  btn-primary btn-rounded" Text="Send" /> &nbsp;&nbsp;&nbsp;&nbsp;
                       <%--<asp:Button ID="btnback" runat="server"  class="btn  btn-success btn-rounded" Text="Back" OnClick="btnback_Click" />--%>
                   </div>
                                
                
              </div>
                    </div>
                </div>  
                </div>
    </div>
 </asp:Content>               
                
                

                
                    
                
