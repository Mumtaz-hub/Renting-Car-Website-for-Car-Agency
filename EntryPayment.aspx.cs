using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryPayment : System.Web.UI.Page
{
    //clsCarMaster objcarmaster;
    clsCustomer objcustomer;
    //clsDriver objdriver;
    //clsBooking objpayment;
    clsPayment objpayment;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        //objpayment = new clsBooking();
        //objcarmaster = new clsCarMaster();
        objcustomer = new clsCustomer();
        //objdriver = new clsDriver();
        objpayment = new clsPayment();
        sCOM = new Common();

        //txtbdate.Text = .ToDateTime.now();

        //To fill Dropdownlist
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
            //sSQL = objcarmaster.DispDataAll();
            //sCOM.setDropDownList(drpcarcode, sSQL, "CarName", "CarCode");
            sSQL = objcustomer.DispDataAll();
            sCOM.setDropDownList(drpcustcode, sSQL, "CustName", "CustCode");

            //sSQL = objdriver.DispDataAll();
            //sCOM.setDropDownList(drpdrcode, sSQL, "DriverName", "Dcode");
            if (Request.QueryString["action"] == "add")
            {
                txtpaymtdate.Text = DateTime.Now.Date.ToString();
                txtpaymtcode.Text = sCOM.setAutoID("Payment", "PaymentCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    txtpaymtcode.Text = ec;
                    objpayment = objpayment.GetData(ec);
                    /*if (chkStatus.Checked == true)
                    {
                        objdriver.Status = "Active";
                    }
                    else
                    {
                        objdriver.Status = "Inactive";
                    }*/

                    txtpaymtdate.Text = objpayment.PaymentDate.ToString();
                    drpcustcode.Text = objpayment.CustCode.ToString();
                    txtamount.Text = objpayment.Amount.ToString();
                    txtrefno.Text = objpayment.ReferenceNo.ToString();
                    txtrefdate.Text = objpayment.ReferenceDate.ToString();
                    drpmode.Text = objpayment.Mode.ToString();
                    txtbankname.Text = objpayment.BankName;
                    txtchqno.Text = objpayment.ChequeNo.ToString();
                    txtchqdte.Text = objpayment.ChequeDate.ToString();
                    txtuname.Text = objpayment.Username;
                    

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
        try
        {

            //objdriver.Dcode= Convert.ToInt32(txtdcode.Text);
            objpayment.PaymentDate = Convert.ToDateTime(txtpaymtdate.Text);
            objpayment.CustCode = Convert.ToInt32(drpcustcode.Text);
            objpayment.Amount = Convert.ToDecimal(txtamount.Text);
            objpayment.ReferenceNo = txtrefno.Text;
            objpayment.ReferenceDate = Convert.ToDateTime(txtrefdate.Text);
            objpayment.Mode =drpmode.Text;
            objpayment.BankName = txtbankname.Text;
            objpayment.ChequeNo = Convert.ToInt32(txtchqno.Text);
            objpayment.ChequeDate = Convert.ToDateTime(txtchqdte.Text);
            objpayment.Username =txtuname.Text;
            
            
            if (Request.QueryString["action"] == "add")
            {
                objpayment.InsertData(objpayment);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objpayment.UpdateData(objpayment, txtpaymtcode.Text);
            }
        }
        catch (Exception x)
        {
        }
    }
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListPayment.aspx");
    }
}