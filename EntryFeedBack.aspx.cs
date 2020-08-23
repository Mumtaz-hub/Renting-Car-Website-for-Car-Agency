using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EntryFeedBack : System.Web.UI.Page
{
    clsFeedBack objfeedback;
    Common sCOM;
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        objfeedback = new clsFeedBack();
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
                txtfbdate.Text = DateTime.Now.Date.ToString();
                txtfbcode.Text = sCOM.setAutoID("FeedBack", "FBCode").ToString();
            }
            else if (Request.QueryString["action"] == "edit")
            {

                if (Request.QueryString["ec"] != null)
                {
                    string ec = (Request.QueryString["ec"].ToString());
                    objfeedback = objfeedback.GetData(ec);
                    txtfbdate.Text = objfeedback.FBDate.ToString();
                    txtfbtitle.Text = objfeedback.FBTitle;
                    txtuname.Text = objfeedback.Username;
                    txtshortdes.Text = objfeedback.ShortDescription;
                    

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

        objfeedback = new clsFeedBack();
        try
        {
            objfeedback.FBDate = Convert.ToDateTime(txtfbdate.Text);
            objfeedback.FBTitle = txtfbtitle.Text;
            objfeedback.Username = txtuname.Text;
            objfeedback.ShortDescription = txtshortdes.Text;
            
            objfeedback.InsertData(objfeedback);
           /* if (Request.QueryString["action"] == "add")
            {
                objfeedback.InsertData(objfeedback);
            }
            else if (Request.QueryString["action"] == "edit")
            {
                objfeedback.UpdateData(objfeedback, txtcustcode.Text);
            }*/

        }
        catch (Exception ex)
        {
        }
    }
}