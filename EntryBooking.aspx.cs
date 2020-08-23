using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryBooking : System.Web.UI.Page
{
    clsCarMaster objcarmaster;
    clsCustomer objcustomer;
    clsDriver objdriver;
    clsBooking objbooking;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        objbooking = new clsBooking();
        objcarmaster = new clsCarMaster();
        objcustomer = new clsCustomer();
        objdriver = new clsDriver();
        sCOM = new Common();

        //txtbdate.Text = .ToDateTime.now();

        //To fill Dropdownlist
       
        

        

        
        
        
        
       /* uname = (String)Session["uname"];
        if (uname != null)
        {
            txtdname.Text = uname;
        }
        else
        {
            txtdname.Text = "travelagent";
        }*/
        if (!Page.IsPostBack)
        {
            sSQL = objcarmaster.DispDataAll();
            sCOM.setDropDownList(drpcarcode, sSQL, "CarName", "CarCode");
            sSQL = objcustomer.DispDataAll();
            sCOM.setDropDownList(drpcustcode, sSQL, "CustName", "CustCode");

            sSQL = objdriver.DispDataAll();
            sCOM.setDropDownList(drpdrcode, sSQL, "DriverName", "Dcode");
            if (Request.QueryString["action"] == "add")
            {
                txtbdate.Text = DateTime.Now.Date.ToString();
                txtbcode.Text = sCOM.setAutoID("Booking", "BookingCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    txtbcode.Text = ec;
                    objbooking = objbooking.GetData(ec);
                    /*if (chkStatus.Checked == true)
                    {
                        objdriver.Status = "Active";
                    }
                    else
                    {
                        objdriver.Status = "Inactive";
                    }*/

                    txtpckdate.Text = objbooking.PickupDate.ToString();
                    txtdrpdate.Text = objbooking.DropDate.ToString();
                    drpcustcode.Text = objbooking.CustCode.ToString();
                    drpcarcode.Text = objbooking.CarCode.ToString();
                    drpdrcode.Text = objbooking.DriverCode.ToString();
                    drppassengers.Text = objbooking.Passengers.ToString();
                    txtpckaddress.Text = objbooking.PickupAddress;
                    txtdraddress.Text = objbooking.DropAddress;
                    txtremark.Text = objbooking.Remark;
                    txtbdate.Text = objbooking.BookingDate.ToString();
                    txtfare.Text = objbooking.Fare.ToString();
                    drpstatus.Text = objbooking.Status;
                    
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
            objbooking.Passengers = Convert.ToInt32(drppassengers.Text);
            objbooking.CustCode = Convert.ToInt32(drpcustcode.Text);
            objbooking.CarCode = Convert.ToInt32(drpcarcode.Text);
            objbooking.DriverCode = Convert.ToInt32(drpdrcode.Text);
            objbooking.PickupDate = Convert.ToDateTime(txtpckdate.Text);
            objbooking.DropDate = Convert.ToDateTime(txtdrpdate.Text);
            objbooking.PickupAddress = txtpckaddress.Text;
            objbooking.DropAddress = txtdraddress.Text;
            objbooking.Remark = txtremark.Text;
            objbooking.Fare = Convert.ToInt32(txtfare.Text);
            objbooking.BookingDate = Convert.ToDateTime(txtbdate.Text);
            objbooking.Status = drpstatus.Text;
           /* {
                objdriver.UpdateData(objdriver, drpstatus.Text);
            }*/

            if (Request.QueryString["action"] == "add")
            {
                objbooking.InsertData(objbooking);
                objbooking.UpdateDriver(objbooking.DriverCode.ToString());

            }
            else if (Request.QueryString["action"] == "edit")
            {
                objbooking.UpdateData(objbooking, txtbcode.Text);
            }
        }
        catch (Exception x)
        {
        }
    }
         protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListBooking.aspx");
    }
}