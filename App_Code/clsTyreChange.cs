using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsTyreChange
/// </summary>
public class clsTyreChange
{
	public clsTyreChange()
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
    public int TCCode { get; set; }
    public DateTime TyreChangeDate { get; set; }
    public Decimal Kilometers { get; set; }
    public string TyreBrand { get; set; }
    public string TyreSide { get; set; }
    public string Remould { get; set; }
    

    #endregion

    #region PublicFunctions
    public void InsertData(clsTyreChange objtchange)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into TyreChange(TyreChangeDate,Kilometers,TyreBrand,TyreSide,Remould)values (@TyreChangeDate,@Kilometers,@TyreBrand,@TyreSide,@Remould)";
        cmd.Parameters.AddWithValue("@TyreChangeDate", objtchange.TyreChangeDate);
        cmd.Parameters.AddWithValue("@Kilometers", objtchange.Kilometers);
        cmd.Parameters.AddWithValue("@TyreBrand", objtchange.TyreBrand);
        cmd.Parameters.AddWithValue("@TyreSide", objtchange.TyreSide);
        cmd.Parameters.AddWithValue("@Remould", objtchange.Remould);
        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsTyreChange objtchange, string tyrechcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE TyreChange set TyreChangeDate=@TyreChangeDate,Kilometers=@Kilometers,TyreBrand=@TyreBrand,TyreSide=@TyreSide,Remould=@Remould where TCCode=" + tyrechcode;
        cmd.Parameters.AddWithValue("@TyreChangeDate", objtchange.TyreChangeDate);
        cmd.Parameters.AddWithValue("@Kilometers", objtchange.Kilometers);
        cmd.Parameters.AddWithValue("@TyreBrand", objtchange.TyreBrand);
        cmd.Parameters.AddWithValue("@TyreSide", objtchange.TyreSide);
        cmd.Parameters.AddWithValue("@Remould", objtchange.Remould);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string tyrechcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE TyreChange where TCCode=" + tyrechcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsTyreChange GetData(string tyrechcode)
    {
        clsTyreChange objtchange;
        myDB = new DBHelper();
        objtchange = new clsTyreChange();
        sSQL = objtchange.DispDataCode(tyrechcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objtchange.TyreChangeDate= Convert.ToDateTime(sDr["TyreChangeDate"].ToString());
            objtchange.Kilometers =Convert.ToDecimal( sDr["Kilometers"].ToString());
            objtchange.TyreBrand= sDr["TyreBrand"].ToString();
            objtchange.TyreSide = sDr["TyreSide"].ToString();
            objtchange.Remould = sDr["Remould"].ToString();

        }
        return objtchange;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from TyreChange";
        return sSQL;
    }
    public string DispDataCode(string tyrechcode)
    {
        sSQL = "SELECT * from TyreChange where TCCode=" + tyrechcode;
        return sSQL;
    }
    #endregion
}