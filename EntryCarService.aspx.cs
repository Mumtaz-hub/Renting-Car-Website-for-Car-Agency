using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryCarService : System.Web.UI.Page
{
    clsCarService objcarservice;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        objcarservice = new clsCarService();
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
                txtserdate.Text = DateTime.Now.Date.ToString();
                txtcscode.Text = sCOM.setAutoID("CarService", "CSCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    txtcscode.Text = ec;
                    objcarservice = objcarservice.GetData(ec);
                   
                    txtuname.Text = objcarservice.Username;
                    txtserdate.Text = objcarservice.ServiceDate.ToString();
                    txtremark.Text = objcarservice.Remark;
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

        objcarservice = new clsCarService();
        try
        {
            objcarservice.Username = txtuname.Text;
            objcarservice.ServiceDate = Convert.ToDateTime(txtserdate.Text);
            objcarservice.Remark = txtremark.Text;
           
            
            if (Request.QueryString["action"] == "add")
            {
                objcarservice.InsertData(objcarservice);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objcarservice.UpdateData(objcarservice, txtcscode.Text);
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListCarService.aspx");
    }
}