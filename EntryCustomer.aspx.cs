using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryCustomer : System.Web.UI.Page
{
    clsCustomer objcustomer;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        objcustomer = new clsCustomer();
        sCOM = new Common();
        uname = (String)Session["uname"];
        if (uname != null)
        {
            txtuname.Text = uname;
        }
        else
        {
            txtuname.Text = "travelagent";
        }
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["action"] == "add")
            {
                txtcustcode.Text = sCOM.setAutoID("Customer", "CustCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    objcustomer = objcustomer.GetData(ec);
                    txtcustcode.Text = objcustomer.CustCode.ToString();
                    txtcustname.Text = objcustomer.CustName;
                    txtuname.Text = objcustomer.UserName;
                    txtaddress.Text = objcustomer.Address;
                    txttphone.Text = objcustomer.Telephone;
                    txtmobile.Text = objcustomer.Mobile;
                    txtemail.Text = objcustomer.Email;

                }

            }
            else
            {
                //Error Page
            }
        }
       
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        
        objcustomer = new clsCustomer();
        try
        {
            objcustomer.CustCode = Convert.ToInt32(txtcustcode.Text);
            objcustomer.CustName = txtcustname.Text;
            objcustomer.UserName = txtuname.Text;
            objcustomer.Address = txtaddress.Text;
            objcustomer.Telephone = txttphone.Text;
            objcustomer.Mobile = txtmobile.Text;
            objcustomer.Email = txtemail.Text;
           // objcustomer.InsertData(objcustomer);
            if (Request.QueryString["action"] == "add")
            {
                objcustomer.InsertData(objcustomer);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objcustomer.UpdateData(objcustomer, txtcustcode.Text);
            }
            
        }
        catch (Exception ex)
        {
            
        }
    }
    
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListCustomer.aspx");
    }
}