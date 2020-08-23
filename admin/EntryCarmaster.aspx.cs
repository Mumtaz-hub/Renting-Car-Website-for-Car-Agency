using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryCarmaster : System.Web.UI.Page
{
    clsBrandMaster objbrandmaster;
    clsCarMaster objcarmaster;
    Common sCOM;
    String sSQL;
    String filePath, url;
    protected void Page_Load(object sender, EventArgs e)
    {

        objbrandmaster = new clsBrandMaster();
        objcarmaster = new clsCarMaster();
        sCOM = new Common();

        if (!Page.IsPostBack)
        {

            sSQL = objbrandmaster.DispDataAll();

            //To fill Dropdownlist

            sCOM.setDropDownList(DropDownList1, sSQL, "BrandName", "BrandCode");

            if (Request.QueryString["action"] == "add")
            {
                txtcarcode.Text = sCOM.setAutoID("CarMaster", "CarCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    objcarmaster = objcarmaster.GetData(ec);
                    txtcarcode.Text = objcarmaster.CarCode.ToString();
                    txtcarname.Text = objcarmaster.CarName;
                    txtphoto.Text = objcarmaster.CarPhoto;

                }
            }
        }
        else
        {
            //Error Page
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        //url = "http://www.mettawalfare.somee.com/";
        objcarmaster = new clsCarMaster();
        if ((FileUpload1.HasFile))
        {
            if ((CheckFileType(FileUpload1.FileName)))
            {
                filePath = "~/Cars/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(filePath));
                txtphoto.Text = filePath;
                //Image2.ImageUrl = filePath;
            }
        }
        objcarmaster = new clsCarMaster();
        try
        {
            objcarmaster.CarCode = Convert.ToInt32(txtcarcode.Text);
            objcarmaster.CarName = txtcarname.Text;
            objcarmaster.CarPhoto = txtphoto.Text;
            objcarmaster.BrandCode = Convert.ToInt32(DropDownList1.SelectedValue);

            if (Request.QueryString["action"] == "add")
            {
                objcarmaster.InsertData(objcarmaster);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objcarmaster.UpdateData(objcarmaster, txtcarcode.Text);
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
        Response.Redirect("ListCarmaster.aspx");
    }


}