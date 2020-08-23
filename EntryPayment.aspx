<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryPayment.aspx.cs" Inherits="EntryPayment" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">Payment Form</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Payment Code:</span></label>--%>
                        <asp:TextBox ID="txtpaymtcode" Visible="false" placeholder="Enter paymentcode" class="form-control" runat="server"></asp:TextBox>
                </div>
                                <div class="form-group">  
                         <label class="control-label mb-10 text-left"><span class="help">Payment Date:</span></label>
                        <asp:TextBox ID="txtpaymtdate" data-mask="99-99-9999"  class="form-control" runat="server"></asp:TextBox>
                </div>
                        <div class="form-group">
                         <label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>
                            <asp:DropDownList ID="drpcustcode" runat="server" class="form-control" required="true" AutoPostBack="True" />
                                           
                </div>
                    <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Amount:</span></label>
                        <asp:TextBox ID="txtamount"  placeholder="Enter amount" class="form-control"  runat="server"  required="true" oninvalid="this.setCustomValidity('Enter digit for eg. 100')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Reference Number:</span></label>
                       <asp:TextBox ID="txtrefno"  placeholder="Enter reference number" class="form-control" runat="server"  required="true" pattern="^\d{10}$" oninvalid="this.setCustomValidity('Enter number ')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Reference Date:</span></label>
                      <asp:TextBox ID="txtrefdate"  placeholder="Enter reference date" class="form-control" data-mask="99-99-9999" runat="server"  required="true" oninvalid="this.setCustomValidity('Enter date for eg.MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div> 
                       
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Mode:</span></label>
                       <asp:DropDownList ID="drpmode" class="form-control" runat="server" required="true" AutoPostBack="True">
                             <asp:ListItem>Cash</asp:ListItem>
                             <asp:ListItem>Demand Draft</asp:ListItem>
                             <asp:ListItem>Cheque</asp:ListItem>
                           </asp:DropDownList>
                      </div>  
                                <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Bank Name:</span></label>
                       <asp:TextBox ID="txtbankname"  placeholder="Enter bank name" class="form-control"  runat="server"  required="true" oninvalid="this.setCustomValidity('Enter name for eg.I.D.B.I')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                                <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Cheque Number:</span></label>
                        <asp:TextBox ID="txtchqno"  placeholder="Enter cheque number" class="form-control"  runat="server"  required="true" pattern="^\d{6}$" oninvalid="this.setCustomValidity('Enter six digit number for eg.123456')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Cheque Date:</span></label>
                       <asp:TextBox ID="txtchqdte"  placeholder="Enter cheque date" class="form-control" data-mask="99-99-9999" runat="server"  required="true" oninvalid="this.setCustomValidity('Enter date for eg.MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div> 
                                <div class="form-group">
                           <%--<label class="control-label mb-10 text-left"><span class="help">Username:</span></label>--%>
                       <asp:TextBox ID="txtuname"  placeholder="Enter username" Visible="false" class="form-control" runat="server"  required="true" ></asp:TextBox>
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
                
                


