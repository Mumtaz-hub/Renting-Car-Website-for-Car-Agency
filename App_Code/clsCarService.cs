using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsCarService
/// </summary>
public class clsCarService
{
	public clsCarService()
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
    public int CSCode { get; set; }
    public string Username { get; set; }
    public DateTime ServiceDate { get; set; }
    public string Remark { get; set; }
    #endregion

    #region PublicFunctions
    public void InsertData(clsCarService objcarservice)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into CarService(Username,ServiceDate,Remark)values (@Username,@ServiceDate,@Remark)";
        cmd.Parameters.AddWithValue("@Username", objcarservice.Username);
        cmd.Parameters.AddWithValue("@ServiceDate",objcarservice.ServiceDate);
        cmd.Parameters.AddWithValue("@Remark", objcarservice.Remark);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsCarService objcarservice, string cscode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE CarService set Username=@Username,ServiceDate=@ServiceDate,Remark=@Remark where CSCode="+ cscode;
        cmd.Parameters.AddWithValue("@Username", objcarservice.Username);
        cmd.Parameters.AddWithValue("@ServiceDate", objcarservice.ServiceDate);
        cmd.Parameters.AddWithValue("@Remark", objcarservice.Remark);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string cscode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE CarService where CSCode=" + cscode;

        myDB.Execute(sSQL, cmd);

    }
    public clsCarService GetData(string cscode)
    {
        clsCarService objcarservice;
        myDB = new DBHelper();
        objcarservice = new clsCarService();
        sSQL = objcarservice.DispDataCode(cscode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            //objcarservice.CSCode = Convert.ToInt32(sDr["CSCode"].ToString());
            objcarservice.Username = sDr["UserName"].ToString();
            objcarservice.ServiceDate = Convert.ToDateTime(sDr["ServiceDate"].ToString());
            objcarservice.Remark = sDr["Remark"].ToString();
          

        }
        return objcarservice;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from CarService";
        return sSQL;
    }
    public string DispDataCode(string cscode)
    {
        sSQL = "SELECT * from CarService where CSCode=" + cscode;
        return sSQL;
    }
    #endregion
}