<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EntryTyreChange.aspx.cs" Inherits="EntryTyreChange" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
        <div class="row">
            <div class="col-sm-12">
                <div class="panel panel-default card-view">
                    <div class="panel-heading">
                        <div class="pull-left">
                            <h6 class="panel-title txt-dark">Tyre Change Data Entry</h6>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="panel-wrapper collapse in">
                        <div class="panel-body">
                            <div class="form-wrap">
                                <div class="form-group">  
                         <%--<label class="control-label mb-10 text-left"><span class="help">Customer Code:</span></label>--%>
                        <asp:TextBox ID="txttccode" Visible="false" placeholder="Enter drivercode" class="form-control" runat="server"></asp:TextBox>
                </div>
                        <div class="form-group">
                         <label class="control-label mb-10 text-left"><span class="help">Tyre Change Date:</span></label>
                           <asp:TextBox ID="txttcdate"   placeholder="Enter date" data-mask="99-99-9999" class="form-control" runat="server" oninvalid="this.setCustomValidity('Enter Valid date for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>                  
                </div>
                    <div class="form-group">
                        <label class="control-label mb-10 text-left"><span class="help">Kilometers:</span></label>
                        <asp:TextBox ID="txtkms"  placeholder="Enter kms" class="form-control"  runat="server" required="true"></asp:TextBox>
                    </div>
                     
                        <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Tyre Brand:</span></label>
                       <asp:TextBox ID="txttyrebrand"  placeholder="Enter brand of tyre" class="form-control" runat="server" required="true"></asp:TextBox>
                     </div>
                     <div class="form-group">
                           <label class="control-label mb-10 text-left"><span class="help">Tyre Side:</span></label>
                         <asp:DropDownList ID="tyside" class="form-control" runat="server" required="true" AutoPostBack="True">
                             <asp:ListItem>Front Right</asp:ListItem>
                             <asp:ListItem>Front Left</asp:ListItem>
                             <asp:ListItem>Rear Right</asp:ListItem>
                             <asp:ListItem>Rear Left</asp:ListItem>
                           </asp:DropDownList>
                     </div> 
                     
                     <div class="form-group">
                           <%--<label class="control-label mb-10 text-left"><span class="help">Remould:</span></label>--%>
                       <asp:CheckBox ID="chkremould" runat="server" class="form-control" Checked="true" Text="Remould"/>
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
                