using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryCarPUC : System.Web.UI.Page
{
    clsUserCar objusercar;
    clsCarPUC objcarpuc;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        objusercar = new clsUserCar();
        objcarpuc = new clsCarPUC();
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
            sSQL = objusercar.DispDataUsername("Apeksha");

            //To fill Dropdownlist

            sCOM.setDropDownList(DropDownList1, sSQL, "RegNo", "UCcode");
            if (Request.QueryString["action"] == "add")
            {
                txtpuccode.Text = sCOM.setAutoID("CarPUC", "PUCCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    objcarpuc = objcarpuc.GetData(ec);
                    txtpuccode.Text = ec;// objcarpuc.PUCCode.ToString();
                    // txtcarcode.Text = objcarpuc.CarCode.ToString();
                    txtuname.Text = objcarpuc.UserName;
                    txtpucdate.Text = objcarpuc.PUCDate.ToString();
                    txtpucno.Text = objcarpuc.PUCNo;
                    txtvalidity.Text = objcarpuc.Validity.ToString();
                    txtexpdate.Text = objcarpuc.ExpDate.ToString();
                    txtagencyname.Text = objcarpuc.AgencyName;

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

        objcarpuc = new clsCarPUC();
        try
        {
           //objcarpuc.PUCCode = Convert.ToInt32(txtpuccode.Text);
            //objcarpuc.CarCode = Convert.ToInt32(txtcarcode.Text);
            objcarpuc.CarCode = Convert.ToInt32(DropDownList1.SelectedValue);
            objcarpuc.PUCDate = Convert.ToDateTime(txtpucdate.Text);
            objcarpuc.PUCNo = txtpucno.Text;
            objcarpuc.Validity =Convert.ToInt32( txtvalidity.Text);
            objcarpuc.ExpDate = Convert.ToDateTime(txtexpdate.Text);
            objcarpuc.AgencyName = txtagencyname.Text;
            objcarpuc.UserName= txtuname.Text;
            // objcustomer.InsertData(objcustomer);
            if (Request.QueryString["action"] == "add")
            {
                objcarpuc.InsertData(objcarpuc);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objcarpuc.UpdateData(objcarpuc, txtpuccode.Text);
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListCarPUC.aspx");
    }
}