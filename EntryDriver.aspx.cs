using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryDriver : System.Web.UI.Page
{
    clsDriver objdriver;
    Common sCOM;
    String sSQL, uname;
    String filePath, url;
    protected void Page_Load(object sender, EventArgs e)
    {
        objdriver = new clsDriver();
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
                txtdcode.Text = sCOM.setAutoID("Driver", "DCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    txtdcode.Text = ec;
                    objdriver = objdriver.GetData(ec);
                    /*if (chkStatus.Checked == true)
                    {
                        objdriver.Status = "Active";
                    }
                    else
                    {
                        objdriver.Status = "Inactive";
                    }*/
                    txtuname.Text = objdriver.Username;
                    txtdname.Text = objdriver.DriverName;
                    txtmno.Text = objdriver.MobileNo.ToString();
                    txtresadd.Text = objdriver.ResidentAddress;
                    txtlicno.Text = objdriver.LicenseNo.ToString();
                    txtlicexpdate.Text = objdriver.LicenseExpDate.ToString();
                    txtdphoto.Text = objdriver.DriverPhoto;
                    drpstatus.Text = objdriver.Status;
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

        //url = "http://www.mettawalfare.somee.com/";
        objdriver = new clsDriver();
        if ((FileUpload1.HasFile))
        {
            if ((CheckFileType(FileUpload1.FileName)))
            {
                filePath = "~/Drivers/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(filePath));
                txtdphoto.Text = filePath;
                //Image2.ImageUrl = filePath;
            }
        }
        
        try
        {
            
            //objdriver.Dcode= Convert.ToInt32(txtdcode.Text);
            objdriver.Username = txtuname.Text;
            objdriver.DriverName = txtdname.Text;
            objdriver.MobileNo = txtmno.Text;
            objdriver.ResidentAddress = txtresadd.Text;
            objdriver.LicenseNo = txtlicno.Text;
            objdriver.LicenseExpDate = Convert.ToDateTime(txtlicexpdate.Text);
            objdriver.DriverPhoto = txtdphoto.Text;
            objdriver.Status = drpstatus.Text;
            

            if (Request.QueryString["action"] == "add")
            {
                objdriver.InsertData(objdriver);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objdriver.UpdateData(objdriver, txtdcode.Text);
            }
        }
        catch (Exception x)
        {
        }
    }
    public bool CheckFileType(string fileName)
    {
        string ext = Path.GetExtension(fileName);
        switch (ext.ToLower())
        {
            case ".gif":
                return true;
            case ".png":
                return true;
            case ".jpg":
                return true;
            case ".jpeg":
                return true;
            default:
                return false;
        }
    }

    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListDriver.aspx");
    }
}