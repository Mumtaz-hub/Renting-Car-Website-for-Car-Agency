using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for clsAdminUser
/// </summary>
public class clsAdminUser
{
    public clsAdminUser()
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
    public string Email { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
    public string Mobile { get; set; }
    public string UserType { get; set; }
    public string Status { get; set; }
    #endregion

    #region PublicFunctions
    public void InsertData(clsAdminUser objAdminUser)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into Adminusers(Email,Password,FullName,Mobile,UserType,Status)values (@Email,@Password,@FullName,@Mobile,@UserType,@Status)";
        cmd.Parameters.AddWithValue("@Email", objAdminUser.Email);
        cmd.Parameters.AddWithValue("@Password", objAdminUser.Password);
        cmd.Parameters.AddWithValue("@FullName", objAdminUser.FullName);
        cmd.Parameters.AddWithValue("@Mobile", objAdminUser.Mobile);
        cmd.Parameters.AddWithValue("@UserType", objAdminUser.UserType);
        cmd.Parameters.AddWithValue("@Status", objAdminUser.Status);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsAdminUser objAdminUser, string em)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE Adminusers set Email=@Email,Password=@Password,FullName=@FullName,Mobile=@Mobile,UserType=@UserType,Status=@Status where Email=" + em;
        cmd.Parameters.AddWithValue("@Email", objAdminUser.Email);
        cmd.Parameters.AddWithValue("@Password", objAdminUser.Password);
        cmd.Parameters.AddWithValue("@FullName", objAdminUser.FullName);
        cmd.Parameters.AddWithValue("@Mobile", objAdminUser.Mobile);
        cmd.Parameters.AddWithValue("@UserType", objAdminUser.UserType);
        cmd.Parameters.AddWithValue("@Status", objAdminUser.Status);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string em)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE Adminusers where Email=" + em;

        myDB.Execute(sSQL, cmd);

    }
    public clsAdminUser GetData(string em)
    {
        clsAdminUser objAdminUser;
        myDB = new DBHelper();
        objAdminUser = new clsAdminUser();
        sSQL = objAdminUser.DispDataCode(em);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objAdminUser.Email = sDr["Email"].ToString();
            objAdminUser.Password = sDr["Password"].ToString();
            objAdminUser.FullName = sDr["FullName"].ToString();
            objAdminUser.Mobile = sDr["Mobile"].ToString();
            objAdminUser.UserType = sDr["UserType"].ToString();
            objAdminUser.Status = sDr["Status"].ToString();

        }
        return objAdminUser;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from Adminusers";
        return sSQL;
    }
    public string DispDataCode(string em)
    {
        sSQL = "SELECT * from Adminusers where Email='" + em + "'";
        return sSQL;
    }
    public bool CheckUser(string email)
    {
        string ans = null;
        myDB = new DBHelper();
        sSQL = string.Format("select * from Adminusers where Email='{0}'", email);
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
    public bool UserLogin(string email, string password)
    {
        string ans = null;
        myDB = new DBHelper();
        sSQL = string.Format("select * from Adminusers where Email='{0}' AND Password='{1}'", email, password);
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