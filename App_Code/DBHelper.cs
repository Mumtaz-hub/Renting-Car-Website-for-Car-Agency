using System;
using System.Text;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Diagnostics;


public class DBHelper
{
    public DBHelper()
    {
    }
    private string GetConStr
    {
        get
        {
            //string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
            //String strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString; //@"Data Source=.\SQLExpress;Initial Catalog=ShopEZDB;Integrated Security=True;Pooling=False";
            string strConnection = @"Data Source=.\SQLExpress;Initial Catalog=ProjectDB;Integrated Security=True;Pooling=False";
            //String strConnection = @"Data Source=GT-XPPRO\EXDEZINE;Initial Catalog=Recipe;User ID=dexter;Password=madness;Integrated Security=False";
            return strConnection;
        }
    }

    public DataTable GetFromDataTable(string sSQL)
    {
        SqlConnection cn = new SqlConnection(GetConStr);
        SqlCommand cmd = new SqlCommand(sSQL, cn);
        DataTable dt = new DataTable();
        IDataReader dr;

        cmd.CommandType = CommandType.Text;


        cn.Open();

        try
        {
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr != null)
            {
                dt.Load(dr);
            }
        }
        catch (SqlException x)
        {
            //You can write to eventlog if you want, but most web hosting won't allow it.
            Console.WriteLine(x.ToString());
            return null;
        }
        cn.Close();
        cmd = null;
        cn = null;

        return dt;
    }
    public DataSet GetFromDataSet(string sSQL)
    {
        SqlConnection cn = new SqlConnection(GetConStr);
        SqlCommand cmd = new SqlCommand(sSQL, cn);
        SqlDataAdapter sDA;
        DataSet sDS;
        sDS = new DataSet();

        try
        {
            cmd.CommandType = CommandType.Text;

            sDA = new SqlDataAdapter(cmd);
            sDA.Fill(sDS);
        }
        catch (SqlException x)
        {
            //You can write to eventlog if you want, but most web hosting won't allow it.
            WriteToEventLog(sSQL + "\n" + x.ToString(), 2);
            return null;
        }
        cn.Close();
        cmd = null;
        cn = null;

        return sDS;
    }

    public SqlDataReader GetFromReader(string sSQL)
    {
        SqlDataReader dr = null;
        SqlConnection cn = new SqlConnection(GetConStr);
        SqlCommand cmd = new SqlCommand(sSQL, cn);

        cmd.CommandType = CommandType.Text;

        cn.Open();

        try
        {
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (SqlException x)
        {
            //Log error messages
            System.Console.WriteLine(x.ToString());
        }

        cmd = null;
        cn = null;

        return dr;
    }
    public int GetInt32(string SPName)
    {
        int output = 0;
        SqlConnection cn = new SqlConnection(GetConStr);
        SqlCommand cmd = new SqlCommand(SPName, cn);

        cmd.CommandType = CommandType.Text;

        cn.Open();
        try
        {
            SqlDataReader dreader = cmd.ExecuteReader();
            if (dreader.Read())
            {
                if (!object.ReferenceEquals(dreader.GetValue(0), DBNull.Value))
                {
                    output = Convert.ToInt32(dreader.GetValue(0));
                }
            }

            dreader.Close();
        }
        catch (SqlException x)
        {
            //You can write to eventlog if you want, but most web hosting won't allow it.
            //WriteToEventLog(SPName +  + x.ToString(), 2);
        }
        cn.Close();
        cmd = null;
        cn = null;

        return output;
    }

    public string GetString(string sSQL)
    {
        string output = "";
        SqlConnection cn = new SqlConnection(GetConStr);
        SqlCommand cmd = new SqlCommand(sSQL, cn);
        SqlDataReader dreader;

        cmd.CommandType = CommandType.Text;

        //Open connection
        cn.Open();
        try
        {
            //Populate Data Reader
            dreader = cmd.ExecuteReader();

            //If dreader is non-empty object and if record of interest is non-null 
            if (dreader.Read())
                if (dreader.GetValue(0) != DBNull.Value)
                    output = dreader.GetString(0);

            //Close data reader
            dreader.Close();
        }
        catch (SqlException x)
        {
            //Log error messages
            //WriteToEventLog(SPName + "\n" + x.ToString(), 2);
        }

        //Close DB Connection
        cn.Close();

        cmd = null;
        cn = null;

        return output;
    }

    public int GetIntScalarVal(string sSQL)
    {
        int output = 0;
        SqlConnection cn = new SqlConnection(GetConStr);
        SqlCommand cmd = new SqlCommand(sSQL, cn);

        cmd.CommandType = CommandType.Text;

        cn.Open();
        try
        {

            output = Convert.ToInt32(cmd.ExecuteScalar());

        }
        catch (SqlException x)
        {
            //You can write to eventlog if you want, but most web hosting won't allow it.
            Console.WriteLine(x.ToString());
        }
        cn.Close();
        cmd = null;
        cn = null;

        return output;
    }

    public int Execute(string sSQL, SqlCommand sCommand)
    {
        int intErr = 0;
        SqlConnection cn = new SqlConnection(GetConStr);

        sCommand.Connection = cn;
        sCommand.CommandType = CommandType.Text;
        sCommand.CommandText = sSQL;

        cn.Open();
        try
        {
            sCommand.ExecuteNonQuery();
        }
        catch (SqlException x)
        {
            intErr = 1;
            System.Console.WriteLine(x.ToString());
        }
        cn.Close();

        sCommand = null;
        cn = null;

        return intErr;
    }


    private int WriteToEventLog(string msg, int EventID)
    {
        try
        {
            EventLog myEventLog = new EventLog("XDRecipe");
            myEventLog.Source = "XDWorldRecipe";
            myEventLog.WriteEntry(msg, EventLogEntryType.Warning, EventID);
            myEventLog = null;
        }
        catch
        {
            return 1;
        }

        return 0;
    }
}