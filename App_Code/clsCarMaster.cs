using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for classCarMaster
/// </summary>
public class clsCarMaster
{
    public clsCarMaster()
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
    public int CarCode { get; set; }
    public string CarName { get; set; }
    public string CarPhoto { get; set; }
    public int BrandCode { get; set; }
    
    #endregion

    #region PublicFunctions
    public void InsertData(clsCarMaster objcarmaster)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into CarMaster(CarName,CarPhoto,BrandCode)values (@CarName,@CarPhoto,@BrandCode)";
        cmd.Parameters.AddWithValue("@CarName", objcarmaster.CarName);
        cmd.Parameters.AddWithValue("@CarPhoto", objcarmaster.CarPhoto);
        cmd.Parameters.AddWithValue("@BrandCode", objcarmaster.BrandCode);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsCarMaster objcarmaster, string carcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE CarMaster set CarName=@CarName,CarPhoto=@CarPhoto,BrandCode=@BrandCode where CarCode=" + carcode;
        cmd.Parameters.AddWithValue("@CarName", objcarmaster.CarName);
        cmd.Parameters.AddWithValue("@CarPhoto", objcarmaster.CarPhoto);
        cmd.Parameters.AddWithValue("@BrandCode", objcarmaster.BrandCode);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string carcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE CarMaster where CarCode=" + carcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsCarMaster GetData(string carcode)
    {
        clsCarMaster objcarmaster;
        myDB = new DBHelper();
        objcarmaster = new clsCarMaster();
        sSQL = objcarmaster.DispDataCode(carcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objcarmaster.CarCode=Convert.ToInt32( sDr["CarCode"].ToString());
            objcarmaster.CarName = sDr["CarName"].ToString();
            objcarmaster.CarPhoto = sDr["CarPhoto"].ToString();
            objcarmaster.BrandCode = Convert.ToInt32(sDr["BrandCode"].ToString());

        }
        return objcarmaster;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from CarMaster";
        return sSQL;
    }
    public string DispDataCode(string carcode)
    {
        sSQL = "SELECT * from CarMaster where CarCode=" + carcode;
        return sSQL;
    }
    #endregion
}