using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;


/// <summary>
/// Summary description for clsCustomer
/// </summary>
public class clsCustomer
{
	public clsCustomer()
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
    public int CustCode { get; set; }
    public string CustName { get; set; }
    public string UserName { get; set; }
    public string Address { get; set; }
    public string Telephone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    #endregion

    #region PublicFunctions
    public void InsertData(clsCustomer objcustomer)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into Customer(CustName,UserName,Address,Telephone,Mobile,Email)values (@CustName,@UserName,@Address,@Telephone,@Mobile,@Email)";
        cmd.Parameters.AddWithValue("@CustName", objcustomer.CustName);
        cmd.Parameters.AddWithValue("@UserName", objcustomer.UserName);
        cmd.Parameters.AddWithValue("@Address", objcustomer.Address);
        cmd.Parameters.AddWithValue("@Telephone", objcustomer.Telephone);
        cmd.Parameters.AddWithValue("@Mobile", objcustomer.Mobile);
        cmd.Parameters.AddWithValue("@Email", objcustomer.Email);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsCustomer objcustomer, string custcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE Customer set CustName=@CustName,UserName=@UserName,Address=@Address,Telephone=@Telephone,Mobile=@Mobile,Email=@Email where CustCode=" + custcode;
        cmd.Parameters.AddWithValue("@CustName", objcustomer.CustName);
        cmd.Parameters.AddWithValue("@UserName", objcustomer.UserName);
        cmd.Parameters.AddWithValue("@Address", objcustomer.Address);
        cmd.Parameters.AddWithValue("@Telephone", objcustomer.Telephone);
        cmd.Parameters.AddWithValue("@Mobile", objcustomer.Mobile);
        cmd.Parameters.AddWithValue("@Email", objcustomer.Email);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string custcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE Customer where CustCode=" + custcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsCustomer GetData(string custcode)
    {
        clsCustomer objcustomer;
        myDB = new DBHelper();
        objcustomer = new clsCustomer();
        sSQL = objcustomer.DispDataCode(custcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objcustomer.CustCode =Convert.ToInt32( sDr["CustCode"].ToString());
            objcustomer.CustName = sDr["CustName"].ToString();
            objcustomer.UserName = sDr["UserName"].ToString();
            objcustomer.Address= sDr["Address"].ToString();
            objcustomer.Telephone = sDr["Telephone"].ToString();
            objcustomer.Mobile = sDr["Mobile"].ToString();
            objcustomer.Email = sDr["Email"].ToString();

        }
        return objcustomer;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from Customer";
        return sSQL;
    }
    public string DispDataCode(string custcode)
    {
        sSQL = "SELECT * from Customer where CustCode=" + custcode;
        return sSQL;
    }
    #endregion

}