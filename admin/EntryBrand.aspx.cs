using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryBrand : System.Web.UI.Page
{

    clsBrandMaster objbrandmaster;
    Common sCOM;
    // string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objbrandmaster = new clsBrandMaster();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["action"] == "add")
            {
                txtbcode.Text = sCOM.setAutoID("BrandMaster", "BrandCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    objbrandmaster = objbrandmaster.GetData(ec);
                    txtbcode.Text = objbrandmaster.BrandCode.ToString();
                    txtbname.Text = objbrandmaster.BrandName;

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
        objbrandmaster = new clsBrandMaster();
        try
        {
            objbrandmaster.BrandCode = Convert.ToInt32(txtbcode.Text);
            objbrandmaster.BrandName = txtbname.Text;

            if (Request.QueryString["action"] == "add")
            {
                objbrandmaster.InsertData(objbrandmaster);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objbrandmaster.UpdateData(objbrandmaster, txtbcode.Text);
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnfind_Click(object sender, EventArgs e)
    {
        objbrandmaster = new clsBrandMaster();
        if (txtbcode.Text != "")
        {
            objbrandmaster = objbrandmaster.GetData(txtbcode.Text);
            txtbcode.Text = objbrandmaster.BrandCode.ToString();
            txtbname.Text = objbrandmaster.BrandName;


        }
    }
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListBrand.aspx");
    }
}
