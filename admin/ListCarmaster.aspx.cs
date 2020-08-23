﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListCarmaster : System.Web.UI.Page
{
    clsCarMaster objcarmaster;
    Common sCOM;
    string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objcarmaster = new clsCarMaster();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {

            sSQL = objcarmaster.DispDataAll();
          
            
            //To Fill Gridview
            sCOM.setGridView(GridView1, sSQL);
        }
    }
    
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string ec;
        ec = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Write(ec);
        Response.Redirect("EntryCarmaster.aspx?action=edit&ec=" + ec);
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("EntryCarmaster.aspx?action=add");
    }
}