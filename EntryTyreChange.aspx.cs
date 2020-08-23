using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryTyreChange : System.Web.UI.Page
{
    clsTyreChange objtcchange;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {

        objtcchange = new clsTyreChange();
        sCOM = new Common();
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
            if (Request.QueryString["action"] == "add")
            {
                txttcdate.Text = DateTime.Now.Date.ToString();
                txttccode.Text = sCOM.setAutoID("TyreChange", "TCCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    txttccode.Text = ec;
                    objtcchange = objtcchange.GetData(ec);
                    /*if (chkStatus.Checked == true)
                    {
                        objtcchange.Status = "Active";
                    }
                    else
                    {
                        objtcchange.Status = "Inactive";
                    }*/

                    txttcdate.Text = objtcchange.TyreChangeDate.ToString();
                    txtkms.Text = objtcchange.Kilometers.ToString();
                    txttyrebrand.Text = objtcchange.TyreBrand;
                    tyside.Text = objtcchange.TyreSide;
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
            if (chkremould.Checked == true)
            {
                objtcchange.Remould = "Yes";
            }
            else
            {
                objtcchange.Remould = "No";
            }
            //objtcchange.Dcode= Convert.ToInt32(txttccode.Text);
            objtcchange.TyreChangeDate = Convert.ToDateTime(txttcdate.Text);
            objtcchange.Kilometers = Convert.ToDecimal(txtkms.Text);
            objtcchange.TyreBrand = txttyrebrand.Text;
            objtcchange.TyreSide = tyside.Text;
            if (Request.QueryString["action"] == "add")
            {
                objtcchange.InsertData(objtcchange);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objtcchange.UpdateData(objtcchange, txttccode.Text);
            }
        }
        catch (Exception x)
        {
        }
    }
    protected void btnback_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListTyreChange.aspx");
    }
}