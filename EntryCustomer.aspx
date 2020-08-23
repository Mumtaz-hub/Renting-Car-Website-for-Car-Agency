<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryCustomer.aspx.cs" Inherits="EntryCustomer" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">Customer Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>--%>
                        <asp:TextBox ID="txtcustcode" Visible="false" placeholder="Enter customercode" class="form-control" runat="server"></asp:TextBox>
                </div>
                        <div class="form-group">
                         <label class="control-label mb-10 text-left"><span class="help">Customer Name:</span></label>
                        <asp:TextBox ID="txtcustname"  placeholder="Enter customer name" class="form-control" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Customer Name for eg. John Shah')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                </div>
                    <div class="form-group">
                        <%--<label class="control-label mb-10 text-left"><span class="help">User Name:</span></label>--%>
                        <asp:TextBox ID="txtuname"  Visible="false" placeholder="Enter user name" class="form-control" runat="server" required="true"></asp:TextBox>
                    </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Address:</span></label>
                       <asp:TextBox ID="txtaddress"  placeholder="Enter address" class="form-control" runat="server" required="true"></asp:TextBox>
                     </div>
                   <div class="form-group">
                          <label class="control-label mb-10 text-left"><span class="help">Telephone:</span></label>
                       <asp:TextBox ID="txttphone"  placeholder="Enter telephone no(02637)" class="form-control" runat="server" pattern="^\d{11}$" required="true" oninvalid="this.setCustomValidity('Enter Telephone no for eg. 02637-212312')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Mobile:</span></label>
                       <asp:TextBox ID="txtmobile"  placeholder="Enter mobile number" class="form-control" runat="server" pattern="^\d{10}$" required="true" oninvalid="this.setCustomValidity('Enter Mobile no for eg. 9099876785')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Email:</span></label>
                       <asp:TextBox ID="txtemail"  placeholder="Enter email id" class="form-control" runat="server" type="email" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. john@yahoo.com')"
                            oninput="setCustomValidity('')"></asp:TextBox>
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
 </asp:Content>               
                
                

                
                    
                