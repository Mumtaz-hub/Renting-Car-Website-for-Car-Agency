using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ListDriver : System.Web.UI.Page
{
    clsDriver objdriver;
    Common sCOM;
    string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objdriver = new clsDriver();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {

            sSQL = objdriver.DispDataAll();


            //To Fill Gridview
            sCOM.setGridView(GridView1, sSQL);
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string ec;
        ec = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Write(ec);
        Response.Redirect("EntryDriver.aspx?action=edit&ec=" + ec);
    }
    protected void btnview_Click(object sender, EventArgs e)
    {
        Response.Redirect("EntryDriver.aspx?action=add");
    }
}