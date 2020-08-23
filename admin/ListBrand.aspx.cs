using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListBrand : System.Web.UI.Page
{
    clsBrandMaster objbrandmaster;
    Common sCOM;
    string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objbrandmaster = new clsBrandMaster();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {
            sSQL = objbrandmaster.DispDataAll();
            //To Fill Gridview
            sCOM.setGridView(GridView1, sSQL);
        }
    }
    

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string ec;
        ec = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Write(ec);
        Response.Redirect("EntryBrand.aspx?action=edit&ec=" + ec);
        
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("EntryBrand.aspx?action=add");
    }
}