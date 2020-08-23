using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsCarPUC
/// </summary>
public class clsCarPUC
{
	public clsCarPUC()
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
    public int PUCCode { get; set; }
    public int CarCode { get; set; }
    public DateTime PUCDate { get; set; }
    public string PUCNo { get; set; }
    public int Validity { get; set; }
    public DateTime ExpDate { get; set; }
    public string AgencyName { get; set; }
    public string UserName { get; set; }
    #endregion

    #region PublicFunctions
    public void InsertData(clsCarPUC objcarpuc)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into CarPUC(CarCode,PUCDate,PUCNo,Validity,ExpDate,AgencyName,UserName)values (@CarCode,@PUCDate,@PUCNo,@Validity,@ExpDate,@AgencyName,@UserName)";
        cmd.Parameters.AddWithValue("@CarCode", objcarpuc.CarCode);
        cmd.Parameters.AddWithValue("@PUCDate", objcarpuc.PUCDate);
        cmd.Parameters.AddWithValue("@PUCNo", objcarpuc.PUCNo);
        cmd.Parameters.AddWithValue("@Validity", objcarpuc.Validity);
        cmd.Parameters.AddWithValue("@ExpDate", objcarpuc.ExpDate);
        cmd.Parameters.AddWithValue("@AgencyName", objcarpuc.AgencyName);
        cmd.Parameters.AddWithValue("@UserName", objcarpuc.UserName);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsCarPUC objcarpuc, string puccode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE CarPUC set CarCode=@CarCode,PUCDate=@PUCDate,PUCNo=@PUCNo,Validity=@Validity,ExpDate=@ExpDate,AgencyName=@AgencyName,UserName=@UserName  where PUCCode=" + puccode;
        cmd.Parameters.AddWithValue("@CarCode", objcarpuc.CarCode);
        cmd.Parameters.AddWithValue("@PUCDate", objcarpuc.PUCDate);
        cmd.Parameters.AddWithValue("@PUCNo", objcarpuc.PUCNo);
        cmd.Parameters.AddWithValue("@Validity", objcarpuc.Validity);
        cmd.Parameters.AddWithValue("@ExpDate", objcarpuc.ExpDate);
        cmd.Parameters.AddWithValue("@AgencyName", objcarpuc.AgencyName);
        cmd.Parameters.AddWithValue("@UserName", objcarpuc.UserName);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string puccode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE CarPUC where PUCCode=" + puccode;

        myDB.Execute(sSQL, cmd);

    }
    public clsCarPUC GetData(string puccode)
    {
        clsCarPUC objcarpuc;
        myDB = new DBHelper();
        objcarpuc = new clsCarPUC();
        sSQL = objcarpuc.DispDataCode(puccode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
           // objcarpuc.PUCCode = Convert.ToInt32(sDr["PUCCode"].ToString());
            objcarpuc.CarCode = Convert.ToInt32(sDr["CarCode"].ToString());
            objcarpuc.PUCDate = Convert.ToDateTime(sDr["PUCDate"].ToString());
            objcarpuc.PUCNo = sDr["PUCNo"].ToString();
            objcarpuc.Validity = Convert.ToInt32(sDr["Validity"].ToString());
            objcarpuc.ExpDate = Convert.ToDateTime(sDr["ExpDate"].ToString());
            objcarpuc.AgencyName = sDr["AgencyName"].ToString();
            objcarpuc.UserName = sDr["UserName"].ToString();

        }
        return objcarpuc;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from CarPUC";
        return sSQL;
    }
    public string DispDataCode(string puccode)
    {
        sSQL = "SELECT * from CarPUC where PUCCode=" + puccode;
        return sSQL;
    }
    
    #endregion
}