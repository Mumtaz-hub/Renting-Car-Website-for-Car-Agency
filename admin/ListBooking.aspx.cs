﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ListBooking : System.Web.UI.Page
{
    clsBooking objbooking;
    Common sCOM;
    string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {
        objbooking = new clsBooking();
        sCOM = new Common();
        if (!Page.IsPostBack)
        {

            sSQL = objbooking.DispDataAll();


            //To Fill Gridview
            sCOM.setGridView(GridView1, sSQL);
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string ec;
        ec = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Write(ec);
        Response.Redirect("EntryBooking.aspx?action=edit&ec=" + ec);

       
    }
    /*protected void btnview_Click(object sender, EventArgs e)
    {
        Response.Redirect("EntryBooking.aspx?action=add");
    }*/
}