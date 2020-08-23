<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="UserCar.aspx.cs" Inherits="UserCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                    
                                    <%--<label class="control-label mb-10 text-left"><span class="help">User Car Code</span></label>--%>
                                        <asp:TextBox ID="txtuccode" runat="server" class="form-control" required="true" Visible="false"></asp:TextBox>
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Car Code</span></label>
                                        <asp:TextBox ID="txtcarcode" runat="server" class="form-control" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                                     </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Brand Code</span></label>
                                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" AutoPostBack="True">
                                        </asp:DropDownList>
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Fuel Type</span></label>
                                        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="True" >
                                            <asp:ListItem>Diesel</asp:ListItem>
                                            <asp:ListItem>Petrol</asp:ListItem>
                                        </asp:DropDownList>
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Transmission Mode</span></label>
                                        <asp:DropDownList ID="DropDownList3" runat="server" class="form-control" AutoPostBack="True" >
                                            <asp:ListItem>Manual</asp:ListItem>
                                            <asp:ListItem>Auto</asp:ListItem>
                                        </asp:DropDownList>
                                    
                                </div>
                                <div class="form-group">
                                   
                                    <label class="control-label mb-10 text-left"><span class="help">Reg No</span></label>
                                        <asp:TextBox ID="txtregno" runat="server" class="form-control" required="true"  oninvalid="this.setCustomValidity('Enter reg no for eg. GJ21 AA 7000')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                                        
                                    
                                </div>
                                <div class="form-group">
                                   
                                    <label class="control-label mb-10 text-left"><span class="help">Engine No</span></label>
                                        <asp:TextBox ID="txtengno" runat="server" class="form-control" required="true"   oninvalid="this.setCustomValidity('Enter engine no for eg. 52WVC10338 ')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                                        
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Chasis No</span></label>
                                        <asp:TextBox ID="txtchasisno" runat="server" class="form-control" required="true" oninvalid="this.setCustomValidity('Enter chasis no for eg. 600132CTZP78900')"
           oninput="setCustomValidity('')"></asp:TextBox>
                                       
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Model Year</span></label>
                                        <asp:TextBox ID="txtmodelyr" runat="server" class="form-control"  required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                                        
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10"><span class="text-muted">Buy Date</span></label>
                                        <asp:TextBox ID="txtbuydte" runat="server" placeholder="Enter date" data-mask="99-99-9999" class="form-control" required="true" oninvalid="this.setCustomValidity('Enter Valid format for eg. MM/DD/YYYY')"
                            oninput="setCustomValidity('')"></asp:TextBox>
                                        
                                    
                                </div>
                                <div class="form-group">
                                    
                                    <%--<label class="control-label mb-10"><span class="text-muted">User Name</span></label>--%>
                                        <asp:TextBox ID="txtuname" runat="server" placeholder="Enter username" visible="false" class="form-control" required="true"></asp:TextBox>
                                        
                                    
                                </div>
                                
                                <div class="form-group">
                                    
                                    <label class="control-label mb-10 text-left"><span class="help">Status</span></label>
                                        <asp:CheckBox ID="CheckBox1" runat="server" class="form-control" Text="Active" />
                                    
                                </div>
                                <div class="form-group">
                                    &nbsp;
                                    
                                        <asp:Button ID="btnsave" runat="server" CssClass="btn btn-primary btn-rounded" OnClick="btnsave_Click" Text="Save" />
                                    
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /Row -->
    </div>
</asp:Content>
