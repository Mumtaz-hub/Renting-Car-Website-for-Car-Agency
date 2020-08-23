using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsBrandMaster
/// </summary>
public class clsBrandMaster
{
	public clsBrandMaster()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    #region LocalVariables
    String sSQL;
    SqlCommand cmd;
    DBHelper myDB;
    #endregion

    #region PublicProperties
    public int BrandCode { get; set; }
    public string BrandName { get; set; }

    #endregion

    #region PublicFunctions
    public void InsertData(clsBrandMaster objbrandmaster)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into BrandMaster(BrandName)values (@BrandName)";
        //cmd.Parameters.AddWithValue("@BrandCode", objbrandmaster.BrandCode);
        cmd.Parameters.AddWithValue("@BrandName", objbrandmaster.BrandName);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsBrandMaster objbrandmaster, string brandcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE BrandMaster set BrandName=@BrandName where BrandCode=" + brandcode;
        cmd.Parameters.AddWithValue("@BrandName", objbrandmaster.BrandName);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string brandcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE BrandMaster where BrandCode=" + brandcode;
        myDB.Execute(sSQL, cmd);

    }
    public clsBrandMaster GetData(string brandcode)
    {
        clsBrandMaster objbrandmaster;
        myDB = new DBHelper();
        objbrandmaster = new clsBrandMaster();
        sSQL = objbrandmaster.DispDataCode(brandcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objbrandmaster.BrandCode =Convert.ToInt32( sDr["BrandCode"].ToString());
            objbrandmaster.BrandName = sDr["BrandName"].ToString();
            

        }
        return objbrandmaster;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from BrandMaster";
        return sSQL;
    }
    public string DispDataCode(string brandcode)
    {
        sSQL = "SELECT * from BrandMaster where BrandCode=" + brandcode;
        return sSQL;
    }
    #endregion
}