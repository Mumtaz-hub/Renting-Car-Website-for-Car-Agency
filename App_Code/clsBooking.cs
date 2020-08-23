using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsBooking
/// </summary>
public class clsBooking
{
	public clsBooking()
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
    public int BookingCode { get; set; }
    public DateTime BookingDate { get; set; }
    public int CustCode { get; set; }
    public DateTime PickupDate { get; set; }
    public DateTime DropDate { get; set; }
    public int CarCode { get; set; }
    public int DriverCode { get; set; }
    public int Passengers { get; set; }
    public int Fare { get; set; }
    public string PickupAddress { get; set; }
    public string DropAddress { get; set; }
    public string Remark { get; set; }
    public string Status { get; set; }

    #endregion

    #region PublicFunctions
    public void InsertData(clsBooking objbooking)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into Booking(BookingDate,CustCode,PickupDate,DropDate,CarCode,DriverCode,Passengers,Fare,PickupAddress,DropAddress,Remark,Status)values (@BookingDate,@CustCode,@PickupDate,@DropDate,@CarCode,@DriverCode,@Passengers,@Fare,@PickupAddress,@DropAddress,@Remark,@Status)";
        cmd.Parameters.AddWithValue("@BookingDate", objbooking.BookingDate);
        cmd.Parameters.AddWithValue("@CustCode", objbooking.CustCode);
        cmd.Parameters.AddWithValue("@PickupDate", objbooking.PickupDate);
        cmd.Parameters.AddWithValue("@DropDate", objbooking.DropDate);
        cmd.Parameters.AddWithValue("@CarCode", objbooking.CarCode);
        cmd.Parameters.AddWithValue("@DriverCode", objbooking.DriverCode);
        cmd.Parameters.AddWithValue("@Passengers", objbooking.Passengers);
        cmd.Parameters.AddWithValue("@Fare", objbooking.Fare);
        cmd.Parameters.AddWithValue("@PickupAddress", objbooking.PickupAddress);
        cmd.Parameters.AddWithValue("@DropAddress", objbooking.DropAddress);
        cmd.Parameters.AddWithValue("@Remark", objbooking.Remark);
        cmd.Parameters.AddWithValue("@Status", objbooking.Status);
        
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsBooking objbooking, string bcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE Booking set BookingDate=@BookingDate,CustCode=@CustCode,PickupDate=@PickupDate,DropDate=@DropDate,CarCode=@CarCode,DriverCode=@DriverCode,Passengers=@Passengers,Fare=@Fare,PickupAddress=@PickupAddress,DropAddress=@DropAddress,Remark=@Remark,Status=@Status where BookingCode=" + bcode;
        cmd.Parameters.AddWithValue("@BookingDate", objbooking.BookingDate);
        cmd.Parameters.AddWithValue("@CustCode", objbooking.CustCode);
        cmd.Parameters.AddWithValue("@PickupDate", objbooking.PickupDate);
        cmd.Parameters.AddWithValue("@DropDate", objbooking.DropDate);
        cmd.Parameters.AddWithValue("@CarCode", objbooking.CarCode);
        cmd.Parameters.AddWithValue("@DriverCode", objbooking.DriverCode);
        cmd.Parameters.AddWithValue("@Passengers", objbooking.Passengers);
        cmd.Parameters.AddWithValue("@Fare", objbooking.Fare);
        cmd.Parameters.AddWithValue("@PickupAddress", objbooking.PickupAddress);
        cmd.Parameters.AddWithValue("@DropAddress", objbooking.DropAddress);
        cmd.Parameters.AddWithValue("@Remark", objbooking.Remark);
        cmd.Parameters.AddWithValue("@Status", objbooking.Status);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateDriver(string dcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "Update Driver set Status = 'Occupied' where Dcode = " + dcode;
        myDB.Execute(sSQL, cmd);
    }
    public void DeleteData(string bcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE Booking where BookingCode=" + bcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsBooking GetData(string bcode)
    {
        clsBooking objbooking;
        myDB = new DBHelper();
        objbooking = new clsBooking();
        sSQL = objbooking.DispDataCode(bcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objbooking.BookingDate = Convert.ToDateTime(sDr["BookingDate"].ToString());
            objbooking.CustCode = Convert.ToInt32(sDr["CustCode"].ToString());
            objbooking.CarCode =  Convert.ToInt32(sDr["CarCode"].ToString());
            objbooking.DriverCode = Convert.ToInt32(sDr["DriverCode"].ToString());
            objbooking.Passengers= Convert.ToInt32(sDr["Passengers"].ToString());
            objbooking.PickupAddress = sDr["PickupAddress"].ToString();
            objbooking.Fare = Convert.ToInt32(sDr["Fare"].ToString());
            objbooking.DropAddress = sDr["DropAddress"].ToString();
            objbooking.PickupDate = Convert.ToDateTime(sDr["PickupDate"].ToString());
            objbooking.DropDate = Convert.ToDateTime(sDr["DropDate"].ToString());
            objbooking.Remark = sDr["Remark"].ToString();

        }
        return objbooking;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from Booking";
        return sSQL;
    }
    public string DispDataCode(string bcode)
    {
        sSQL = "SELECT * from Booking where BookingCode=" + bcode;
        return sSQL;
    }
    #endregion
}
