using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsFeedBack
/// </summary>
public class clsFeedBack
{
	public clsFeedBack()
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
    public int FBCode { get; set; }
    public DateTime FBDate { get; set; }
    public string FBTitle { get; set; }
    public string ShortDescription { get; set; }
    public string Username { get; set; }

    #endregion

    #region PublicFunctions
    public void InsertData(clsFeedBack objfeedback)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into FeedBack(FBDate,FBTitle,ShortDescription,Username)values (@FBDate,@FBTitle,@ShortDescription,@Username)";
        cmd.Parameters.AddWithValue("@FBDate", objfeedback.FBDate);
        cmd.Parameters.AddWithValue("@FBTitle", objfeedback.FBTitle);
        cmd.Parameters.AddWithValue("@ShortDescription", objfeedback.ShortDescription);
        cmd.Parameters.AddWithValue("@Username", objfeedback.Username);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsFeedBack objfeedback, string fbcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE FeedBack set FBDate=@FBDate,FBTitle=@FBTitle,ShortDescription=@ShortDescription,Username=@Username where FBCode=" + fbcode;
        cmd.Parameters.AddWithValue("@FBDate", objfeedback.FBDate);
        cmd.Parameters.AddWithValue("@FBTitle", objfeedback.FBTitle);
        cmd.Parameters.AddWithValue("@ShortDescription", objfeedback.ShortDescription);
        cmd.Parameters.AddWithValue("@Username", objfeedback.Username);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string fbcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE FeedBack where FBCode=" + fbcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsFeedBack GetData(string fbcode)
    {
        clsFeedBack objfeedback;
        myDB = new DBHelper();
        objfeedback = new clsFeedBack();
        sSQL = objfeedback.DispDataCode(fbcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objfeedback.FBDate = Convert.ToDateTime(sDr["FBDate"].ToString());
            objfeedback.FBTitle = sDr["FBTitle"].ToString();
            objfeedback.ShortDescription = sDr["ShortDescription"].ToString();
            objfeedback.Username = sDr["Username"].ToString();

        }
        return objfeedback;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from FeedBack";
        return sSQL;
    }
    public string DispDataCode(string fbcode)
    {
        sSQL = "SELECT * from FeedBack where FBCode=" + fbcode;
        return sSQL;
    }
    #endregion
}