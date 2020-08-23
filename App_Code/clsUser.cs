using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsUser
/// </summary>
public class clsUser
{
    public clsUser()
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
    public string Username { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string UserType { get; set; }
    public string Status { get; set; }
    public string MobileNo { get; set; }
    #endregion

    #region PublicFunctions
    public void InsertData(clsUser objUser)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into Users(Username,Password,FullName,Email,UserType,Status,MobileNo)values (@Username,@Password,@FullName,@Email,@UserType,@Status,@MobileNo)";
        cmd.Parameters.AddWithValue("@Username", objUser.Username);
        cmd.Parameters.AddWithValue("@Password", objUser.Password);
        cmd.Parameters.AddWithValue("@FullName", objUser.FullName);
        cmd.Parameters.AddWithValue("@Email", objUser.Email);
        cmd.Parameters.AddWithValue("@UserType", objUser.UserType);
        cmd.Parameters.AddWithValue("@Status", objUser.Status);
        cmd.Parameters.AddWithValue("@MobileNo", objUser.MobileNo);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsUser objUser, string un)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE Users set Username=@Username,Password=@Password,FullName=@FullName,Email=@Email,UserType=@UserType,Status=@Status,MobileNo=@MobileNo where Username=" + un;
        cmd.Parameters.AddWithValue("@Username", objUser.Username);
        cmd.Parameters.AddWithValue("@Password", objUser.Password);
        cmd.Parameters.AddWithValue("@FullName", objUser.FullName);
        cmd.Parameters.AddWithValue("@Email", objUser.Email);
        cmd.Parameters.AddWithValue("@UserType", objUser.UserType);
        cmd.Parameters.AddWithValue("@Status", objUser.Status);
        cmd.Parameters.AddWithValue("@MobileNo", objUser.MobileNo);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string un)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE Users where Username=" + un;

        myDB.Execute(sSQL, cmd);

    }
    public clsUser GetData(string un)
    {
        clsUser objUser;
        myDB = new DBHelper();
        objUser = new clsUser();
        sSQL = objUser.DispDataCode(un);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objUser.Username = sDr["Username"].ToString();
            objUser.Password = sDr["Password"].ToString();
            objUser.FullName = sDr["FullName"].ToString();
            objUser.Email = sDr["Email"].ToString();
            objUser.UserType = sDr["UserType"].ToString();
            objUser.Status = sDr["Status"].ToString();
            objUser.MobileNo = sDr["MobileNo"].ToString();

        }
        return objUser;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from Users";
        return sSQL;
    }
    public string DispDataCode(string un)
    {
        sSQL = "SELECT * from Users where Username = '" + un + "'";
        return sSQL;
    }
    public bool CheckUser(string username)
    {
        string ans = null;
        myDB = new DBHelper();
        sSQL = string.Format("select * from Users where Username='{0}'", username);
        ans = myDB.GetString(sSQL);
        if (ans != "")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public bool UserLogin(string username, string password)
    {
        string ans = null;
        myDB = new DBHelper();
        sSQL = string.Format("select * from Users where Username='{0}' AND Password='{1}'", username, password);
        ans = myDB.GetString(sSQL);
        if (ans != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    #endregion

}