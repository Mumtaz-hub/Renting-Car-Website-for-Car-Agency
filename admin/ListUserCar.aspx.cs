using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ListUserCar : System.Web.UI.Page
{
    clsUserCar objtcchange;
    Common sCOM;
    string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objtcchange = new clsUserCar();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {

            sSQL = objtcchange.DispDataAll();


            //To Fill Gridview
            sCOM.setGridView(GridView1, sSQL);
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string ec;
        ec = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Write(ec);
        Response.Redirect("UserCar.aspx?action=edit&ec=" + ec);
    }
    
}
