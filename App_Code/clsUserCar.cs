using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsUserCar
/// </summary>
public class clsUserCar
{
	public clsUserCar()
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
    public int UCcode { get; set; }
    public int CarCode { get; set; }
    public int BrandCode { get; set; }
    public string RegNo  { get; set; }
    public string EngineNo { get; set; }
    public string ChasisNo { get; set; }
    public DateTime BuyDate { get; set; }
    public string UserName { get; set; }
    public string Status { get; set; }
    public string TransmissionMode { get; set; }
    public string FuelType { get; set; }
    public string ModelYear { get; set; }
    #endregion

    #region PublicFunctions
    public void InsertData(clsUserCar objusercar)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into UserCar(CarCode,BrandCode,RegNo,EngineNo,ChasisNo,BuyDate,UserName,Status,TransmissionMode,FuelType,ModelYear)values (@CarCode,@BrandCode,@RegNo,@EngineNo,@ChasisNo,@BuyDate,@UserName,@Status,@TransmissionMode,@FuelType,@ModelYear)";
        cmd.Parameters.AddWithValue("@CarCode", objusercar.CarCode);
        cmd.Parameters.AddWithValue("@BrandCode", objusercar.BrandCode);
        cmd.Parameters.AddWithValue("@RegNo", objusercar.RegNo);
        cmd.Parameters.AddWithValue("@EngineNo", objusercar.EngineNo);
        cmd.Parameters.AddWithValue("@ChasisNo", objusercar.ChasisNo);
        cmd.Parameters.AddWithValue("@BuyDate", objusercar.BuyDate);
        cmd.Parameters.AddWithValue("@UserName", objusercar.UserName);
        cmd.Parameters.AddWithValue("@Status", objusercar.Status);
        cmd.Parameters.AddWithValue("@TransmissionMode", objusercar.TransmissionMode);
        cmd.Parameters.AddWithValue("@FuelType", objusercar.FuelType);
        cmd.Parameters.AddWithValue("@ModelYear", objusercar.ModelYear);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsUserCar objusercar, string uccode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE UserCar set UCcode=@UCcode,CarCode=@CarCode,BrandCode=@BrandCode,RegNo=@RegNo,EngineNo=@EngineNo,ChasisNo=@ChasisNo,BuyDate=@BuyDate,UserName=@UserName,Status=@Status,TransmissionMode=@TransmissionMode,FuelType=@FuelType,ModelYear=@ModelYear where UCcode=" + uccode;
        cmd.Parameters.AddWithValue("@UCcode", objusercar.UCcode);
        cmd.Parameters.AddWithValue("@CarCode", objusercar.CarCode);
        cmd.Parameters.AddWithValue("@BrandCode", objusercar.BrandCode);
        cmd.Parameters.AddWithValue("@RegNo", objusercar.RegNo);
        cmd.Parameters.AddWithValue("@EngineNo", objusercar.EngineNo);
        cmd.Parameters.AddWithValue("@ChasisNo", objusercar.ChasisNo);
        cmd.Parameters.AddWithValue("@BuyDate", objusercar.BuyDate);
        cmd.Parameters.AddWithValue("@UserName", objusercar.UserName);
        cmd.Parameters.AddWithValue("@Status", objusercar.Status);
        cmd.Parameters.AddWithValue("@TransmissionMode", objusercar.TransmissionMode);
        cmd.Parameters.AddWithValue("@FuelType", objusercar.FuelType);
        cmd.Parameters.AddWithValue("@ModelYear", objusercar.ModelYear);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string uccode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE UserCar where UCcode=" + uccode;

        myDB.Execute(sSQL, cmd);

    }
    public clsUserCar GetData(string uccode)
    {
        clsUserCar objusercar;
        myDB = new DBHelper();
        objusercar = new clsUserCar();
        sSQL = objusercar.DispDataCode(uccode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objusercar.UCcode =Convert.ToInt32( sDr["UCcode"].ToString());
            objusercar.CarCode = Convert.ToInt32(sDr["CarCode"].ToString());
            objusercar.BrandCode = Convert.ToInt32(sDr["BrandCode"].ToString());
            objusercar.RegNo = sDr["RegNo"].ToString();
            objusercar.EngineNo =sDr["EngineNo"].ToString();
            objusercar.ChasisNo= sDr["ChasisNo"].ToString();
            objusercar.BuyDate =Convert.ToDateTime( sDr["BuyDate"].ToString());
            objusercar.UserName = sDr["UserName"].ToString();
            objusercar.Status = sDr["Status"].ToString();
            objusercar.TransmissionMode = sDr["TransmissionMode"].ToString();
            objusercar.FuelType = sDr["FuelType"].ToString();
            objusercar.ModelYear = sDr["ModelYear"].ToString();

        }
        return objusercar;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from UserCar";
        return sSQL;
    }
    public string DispDataCode(string uccode)
    {
        sSQL = "SELECT * from UserCar where UCCode=" + uccode;
        return sSQL;
    }
    public string DispDataUsername(string uname)
    {
        sSQL = "SELECT * from UserCar where Username='" + uname + "'";
        return sSQL;
    }
    #endregion
}