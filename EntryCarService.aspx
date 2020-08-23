<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryCarService.aspx.cs" Inherits="EntryCarService" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">User CarService Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>--%>
                        <asp:TextBox ID="txtcscode" Visible="false" placeholder="Enter puccode" class="form-control" runat="server"></asp:TextBox>
                </div>
                        <div class="form-group">
                         <%--<label class="control-label mb-10 text-left"><span class="help">User Name:</span></label>--%>
                           <asp:TextBox ID="txtuname" Visible="false"  placeholder="Enter username" class="form-control" runat="server"></asp:TextBox>                  
                </div>
                    <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Service Date:</span></label>
                        <asp:TextBox ID="txtserdate"  placeholder="Enter service date" class="form-control" data-mask="99-99-9999" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Remark:</span></label>
                       <asp:TextBox ID="txtremark"  placeholder="Enter remark here" class="form-control" runat="server" required="true"></asp:TextBox>
                     </div>
                   <div>
                       <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" class="btn  btn-primary btn-rounded" Text="Save" /> &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="btnback" runat="server"  class="btn  btn-success btn-rounded" Text="Back" OnClick="btnback_Click" />
                   </div>
                                
                
              </div>
                    </div>
                </div>  
                </div>
    </div>
            </div>
      </div>
 </asp:Content>               
                
                
