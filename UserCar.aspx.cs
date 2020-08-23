using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserCar : System.Web.UI.Page
{
    clsBrandMaster objbrandmaster;
    clsUserCar objusercar;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        objbrandmaster = new clsBrandMaster();
        objusercar = new clsUserCar();
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

            sSQL = objbrandmaster.DispDataAll();

            //To fill Dropdownlist

            sCOM.setDropDownList(DropDownList1, sSQL, "BrandName", "BrandCode");

           /* if (Request.QueryString["action"] == "add")
            {
                txtuccode.Text = sCOM.setAutoID("UserCar", "UCcode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    objusercar = objusercar.GetData(ec);
                    txtuccode.Text = objusercar.UCcode;
                    txtcarcode.Text = objusercar.CarCode;
                    txtregno.Text = objusercar.RegNo;
                    txtengno.Text = objusercar.EngineNo;
                    txtchasisno.Text = objusercar.ChasisNo;
                    txtbuydte.Text = objusercar.BuyDate;
                    txtuname.Text = objusercar.UserName;
                   

                }
            }*/
        }
        else
        {
            //Error Page
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        objusercar = new clsUserCar();
        try
        {
           // objusercar.UCcode = Convert.ToInt32(txtuccode.Text);
            objusercar.UserName = txtuname.Text;
            objusercar.CarCode = Convert.ToInt32(txtcarcode.Text);
            objusercar.BrandCode =Convert.ToInt32( DropDownList1.SelectedValue);
            objusercar.RegNo = txtregno.Text;
            objusercar.EngineNo = txtengno.Text;
            objusercar.ChasisNo = txtchasisno.Text;
            objusercar.BuyDate = Convert.ToDateTime(txtbuydte.Text);
            objusercar.UserName = txtuname.Text;
            objusercar.ModelYear =txtmodelyr.Text;
            objusercar.TransmissionMode = DropDownList3.SelectedValue;
            objusercar.FuelType = DropDownList2.SelectedValue;
            objusercar.Status = CheckBox1.Text;
            if (CheckBox1.Checked == true)
            {
                objusercar.Status = "Active";
            }
            else
            {
                objusercar.Status = "Inactive";
            }
            objusercar.InsertData(objusercar);
            /*if (Request.QueryString["action"] == "add")
            {
                
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objusercar.UpdateData(objusercar, txtuccode.Text);
            }*/
        }
        catch (Exception x)
        {
        }
    }
}