<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryBooking.aspx.cs" Inherits="EntryBooking" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">Booking Data Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Booking Code:</span></label>--%>
                        <asp:TextBox ID="txtbcode" Visible="false" placeholder="Enter bookingcode" class="form-control" runat="server"></asp:TextBox>
                </div>
                                <div class="form-group">  
                         <label class="control-label mb-10 text-left"><span class="help">Booking Date:</span></label>
                        <asp:TextBox ID="txtbdate" data-mask="99-99-9999"  class="form-control" runat="server"></asp:TextBox>
                </div>
                        <div class="form-group">
                         <label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>
                            <asp:DropDownList ID="drpcustcode" runat="server" class="form-control" AutoPostBack="True" />
                                           
                </div>
                    <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Pickup Date:</span></label>
                        <asp:TextBox ID="txtpckdate"  placeholder="Enter pickup-date" class="form-control"  runat="server" data-mask="99-99-9999" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Drop Date:</span></label>
                       <asp:TextBox ID="txtdrpdate"  placeholder="Enter drop date" class="form-control" runat="server" data-mask="99-99-9999" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Car Code:</span></label>
                       <asp:DropDownList ID="drpcarcode" runat="server" class="form-control" AutoPostBack="True" />
                     </div> 
                      <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Driver Code:</span></label>
                       <asp:DropDownList ID="drpdrcode" runat="server" class="form-control" AutoPostBack="True" />
                     </div> 
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Passengers:</span></label>
                       <asp:DropDownList ID="drppassengers" class="form-control" runat="server" required="true" AutoPostBack="True">
                             <asp:ListItem>1</asp:ListItem>
                             <asp:ListItem>2</asp:ListItem>
                             <asp:ListItem>3</asp:ListItem>
                             <asp:ListItem>4</asp:ListItem>
                             <asp:ListItem>5</asp:ListItem>
                             <asp:ListItem>6</asp:ListItem>
                             <asp:ListItem>7</asp:ListItem>
                             <asp:ListItem>8</asp:ListItem>
                             <asp:ListItem>9</asp:ListItem>
                             <asp:ListItem>10</asp:ListItem>
                           </asp:DropDownList>
                      </div>  
                                <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Fare:</span></label>
                        <asp:TextBox ID="txtfare"  placeholder="Enter fare" class="form-control"  runat="server"  required="true" oninvalid="this.setCustomValidity('Enter number for eg. 100')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Pickup Address:</span></label>
                       <asp:TextBox ID="txtpckaddress"  placeholder="Enter pickup-address" class="form-control" runat="server"  required="true" ></asp:TextBox>
                     </div> 
                                <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Drop Address:</span></label>
                       <asp:TextBox ID="txtdraddress"  placeholder="Enter drop-address" class="form-control" runat="server"  required="true" ></asp:TextBox>
                     </div>       
                       <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Remark:</span></label>
                       <asp:TextBox ID="txtremark"  placeholder="Enter remark" class="form-control" runat="server"  required="true" ></asp:TextBox>
                     </div> 
                                <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Status:</span></label>
                                    <asp:DropDownList ID="drpstatus" class="form-control" runat="server" AutoPostBack="True">
                                        <asp:ListItem>Pending</asp:ListItem>
                                        <asp:ListItem>Cancelled</asp:ListItem>
                                        <asp:ListItem>Completed</asp:ListItem>
                                    </asp:DropDownList>
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
                
                


