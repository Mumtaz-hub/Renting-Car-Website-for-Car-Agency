<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryDriver.aspx.cs" Inherits="EntryDriver" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">Driver Data Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>--%>
                        <asp:TextBox ID="txtdcode" Visible="false" placeholder="Enter drivercode" class="form-control" runat="server"></asp:TextBox>
                </div>
                                <div class="form-group">
                         <%--<label class="control-label mb-10 text-left"><span class="help">User Name:</span></label>--%>
                           <asp:TextBox ID="txtuname"   placeholder="Enter username" visible="false" class="form-control" runat="server" oninvalid="this.setCustomValidity('Enter User Name for eg. Johnsan Mehta')"
                            oninput="setCustomValidity('')"></asp:TextBox>                 
                </div>
                        <div class="form-group">
                         <label class="control-label mb-10 text-left"><span class="help">Driver Name:</span></label>
                           <asp:TextBox ID="txtdname"   placeholder="Enter drivername" class="form-control" runat="server" oninvalid="this.setCustomValidity('Enter Driver Name for eg. Johnsan Mehta')"
                            oninput="setCustomValidity('')"></asp:TextBox>                 
                </div>
                    <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Mobile Number:</span></label>
                        <asp:TextBox ID="txtmno"  placeholder="Enter mobileno" class="form-control"  runat="server" pattern="^\d{10}$" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. 9909987321')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                    </div>
                     
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Resident Address:</span></label>
                       <asp:TextBox ID="txtresadd"  placeholder="Enter resident address" class="form-control" runat="server" required="true"></asp:TextBox>
                     </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">License Number:</span></label>
                       <asp:TextBox ID="txtlicno"  placeholder="Enter your licenseno" class="form-control" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. GJ21 20140010158')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div> 
                      <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">License Expiry Date:</span></label>
                       <asp:TextBox ID="txtlicexpdate"  placeholder="Enter licexpdate" class="form-control" data-mask="99-99-9999" runat="server" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                     </div> 
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Driver Photo:</span></label>
                       <asp:TextBox ID="txtdphoto"  placeholder="Driver photo" Visible="false" class="form-control" runat="server" required="true" ></asp:TextBox>
                           <asp:FileUpload ID="FileUpload1" runat="server" />
                      </div>  
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Status:</span></label>
                         <asp:DropDownList ID="drpstatus" class="form-control" runat="server" AutoPostBack="True">
                             <asp:ListItem>Available</asp:ListItem>
                             <asp:ListItem>Occupied</asp:ListItem>
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
                
                

