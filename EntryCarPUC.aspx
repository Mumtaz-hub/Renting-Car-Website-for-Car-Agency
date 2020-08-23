<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryCarPUC.aspx.cs" Inherits="EntryCarPUC" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">User Car Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>--%>
                        <asp:TextBox ID="txtpuccode" Visible="false" placeholder="Enter puccode" class="form-control" runat="server"></asp:TextBox>
                </div>
                        <div class="form-group">
                         <label class="control-label mb-10 text-left"><span class="help">Car Number:</span></label>
                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" AutoPostBack="True">
                        </asp:DropDownList>                        
                </div>
                    <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">PUC Date:</span></label>
                        <asp:TextBox ID="txtpucdate"  placeholder="Enter puc date" class="form-control" data-mask="99-99-9999" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">PUC Number:</span></label>
                       <asp:TextBox ID="txtpucno"  placeholder="Enter puc number" class="form-control" runat="server" required="true" oninvalid="this.setCustomValidity('Enter valid PUC Number for eg. P102110599')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                   <div class="form-group">
                          <label class="control-label mb-10 text-left"><span class="help">Validity:</span></label>
                       <asp:TextBox ID="txtvalidity"  placeholder="Enter validity" class="form-control" runat="server" required="true"></asp:TextBox>
                     </div>
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Expiry Date:</span></label>
                       <asp:TextBox ID="txtexpdate"  placeholder="Enter expiry date" class="form-control" data-mask="99-99-9999" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Agency Name:</span></label>
                       <asp:TextBox ID="txtagencyname"  placeholder="Enter agency name" class="form-control" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Agency Name for eg. Sainath')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div>
                        <div class="form-group">
                           <%--<label class="control-label mb-10 text-left"><span class="help">User Name:</span></label>--%>
                       <asp:TextBox ID="txtuname"  placeholder="Enter user name" Visible="false" class="form-control" runat="server"  required="true" oninvalid="this.setCustomValidity('Enter Username for eg. John')"
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
            </div>
      </div>
 </asp:Content>               
                
                

                
                    
                