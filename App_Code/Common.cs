using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;



public class Common
{
    DBHelper myDB;
    DataTable dt;
    DataView dv;

	public Common()
	{
        myDB = new DBHelper();
	}

   
    public void setGridView(GridView gView, String sSQL)
    {
        dt = new DataTable();
        dt = myDB.GetFromDataTable(sSQL);
        dv = new DataView(dt);
        gView.DataSource = dv;
        gView.DataBind();
    }
    public void setDataList(DataList gView, String sSQL)
    {
        dt = new DataTable();
        dt = myDB.GetFromDataTable(sSQL);
        dv = new DataView(dt);
        gView.DataSource = dv;
        gView.DataBind();
    }
    public void setDataRepeater(Repeater gView, String sSQL)
    {
        dt = new DataTable();
        dt = myDB.GetFromDataTable(sSQL);
        dv = new DataView(dt);
        gView.DataSource = dv;
        gView.DataBind();
    }

    public void setDropDownList(DropDownList dropList, String sSQL, String display, String Value)
    {
        dt = new DataTable();
        dt = myDB.GetFromDataTable(sSQL);
        dv = new DataView(dt);
        dropList.DataTextField = display;
        dropList.DataValueField = Value;
        dropList.DataSource = dv;
        dropList.DataBind();
    }
    public int setAutoID(String tabName, String colName)
    {
        int ID;
        try
        {
            String sSQL = "Select max(" + colName + ")+1 as maxID From " + tabName;
            ID = myDB.GetIntScalarVal(sSQL);
            if (ID == 0)
            {
                ID = 1;
            }
        }
        catch
        {
            ID = 1;
        }
        return ID;
    }
}