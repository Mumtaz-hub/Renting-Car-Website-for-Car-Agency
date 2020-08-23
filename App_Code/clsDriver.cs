using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsDriver
/// </summary>
public class clsDriver
{
	public clsDriver()
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
    public int Dcode { get; set; }
    public string Username { get; set; }
    public string DriverName { get; set; }
    public string MobileNo { get; set; }
    public string ResidentAddress { get; set; }
    public string LicenseNo { get; set; }
    public DateTime LicenseExpDate { get; set; }
    public string DriverPhoto { get; set; }
    public string Status { get; set; }

    #endregion

    #region PublicFunctions
    public void InsertData(clsDriver objdriver)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into Driver(Username,DriverName,MobileNo,ResidentAddress,LicenseNo,LicenseExpDate,DriverPhoto,Status)values (@Username,@DriverName,@MobileNo,@ResidentAddress,@LicenseNo,@LicenseExpDate,@DriverPhoto,@Status)";
        cmd.Parameters.AddWithValue("@Username", objdriver.Username);
        cmd.Parameters.AddWithValue("@DriverName", objdriver.DriverName);
        cmd.Parameters.AddWithValue("@MobileNo", objdriver.MobileNo);
        cmd.Parameters.AddWithValue("@ResidentAddress", objdriver.ResidentAddress);
        cmd.Parameters.AddWithValue("@LicenseNo", objdriver.LicenseNo);
        cmd.Parameters.AddWithValue("@LicenseExpDate", objdriver.LicenseExpDate);
        cmd.Parameters.AddWithValue("@DriverPhoto", objdriver.DriverPhoto);
        cmd.Parameters.AddWithValue("@Status", objdriver.Status);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsDriver objdriver, string dcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE Driver set Username=@Username,DriverName=@DriverName,MobileNo=@MobileNo,ResidentAddress=@ResidentAddress,LicenseNo=@LicenseNo,LicenseExpDate=@LicenseExpDate,DriverPhoto=@DriverPhoto,Status=@Status where Dcode=" + dcode;
        cmd.Parameters.AddWithValue("@Username", objdriver.Username);
        cmd.Parameters.AddWithValue("@DriverName", objdriver.DriverName);
        cmd.Parameters.AddWithValue("@MobileNo", objdriver.MobileNo);
        cmd.Parameters.AddWithValue("@ResidentAddress", objdriver.ResidentAddress);
        cmd.Parameters.AddWithValue("@LicenseNo", objdriver.LicenseNo);
        cmd.Parameters.AddWithValue("@LicenseExpDate", objdriver.LicenseExpDate);
        cmd.Parameters.AddWithValue("@DriverPhoto", objdriver.DriverPhoto);
        cmd.Parameters.AddWithValue("@Status", objdriver.Status);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string dcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE Driver where DCode=" + dcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsDriver GetData(string dcode)
    {
        clsDriver objdriver;
        myDB = new DBHelper();
        objdriver = new clsDriver();
        sSQL = objdriver.DispDataCode(dcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objdriver.Username = sDr["Username"].ToString();
            objdriver.MobileNo = sDr["MobileNo"].ToString();
            objdriver.DriverName = sDr["DriverName"].ToString();
            objdriver.ResidentAddress = sDr["ResidentAddress"].ToString();
            objdriver.LicenseNo = sDr["LicenseNo"].ToString();
            objdriver.LicenseExpDate = Convert.ToDateTime(sDr["LicenseExpDate"].ToString());
            objdriver.DriverPhoto = sDr["DriverPhoto"].ToString();
            objdriver.Status = sDr["Status"].ToString();

        }
        return objdriver;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from Driver";
        return sSQL;
    }
    public string DispDataCode(string dcode)
    {
        sSQL = "SELECT * from Driver where DCode=" + dcode;
        return sSQL;
    }
    #endregion
}