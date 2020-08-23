using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListCustomer : System.Web.UI.Page
{
    clsCustomer objcustomer;
    Common sCOM;
    string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objcustomer = new clsCustomer();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {
            sSQL = objcustomer.DispDataAll();
            //To Fill Gridview
            sCOM.setGridView(GridView1, sSQL);
        }
    
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string ec;
        ec = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Write(ec);
        Response.Redirect("EntryCustomer.aspx?action=edit&ec=" + ec);
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("EntryCustomer.aspx?action=add");
    }
}