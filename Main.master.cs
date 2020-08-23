using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.MasterPage
{
    String sSQL, uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        uname = (String)Session["uname"];
        if(uname!=null)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}
