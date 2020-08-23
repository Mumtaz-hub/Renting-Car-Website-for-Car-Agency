using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsPayment
/// </summary>
public class clsPayment
{
	public clsPayment()
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
    public int PaymentCode { get; set; }
    public DateTime PaymentDate { get; set; }
    public int CustCode { get; set; }
    public decimal Amount { get; set; }
    public string ReferenceNo { get; set; }
    public DateTime ReferenceDate { get; set; }
    public string Mode { get; set; }
    public string BankName { get; set; }
    public int ChequeNo { get; set; }
    public DateTime ChequeDate { get; set; }
    public string Username { get; set; }
    

    #endregion

    #region PublicFunctions
    public void InsertData(clsPayment objpayment)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "INSERT into Payment(PaymentDate,CustCode,Amount,ReferenceNo,ReferenceDate,Mode,BankName,ChequeNo,ChequeDate,Username)values (@PaymentDate,@CustCode,@Amount,@ReferenceNo,@ReferenceDate,@Mode,@BankName,@ChequeNo,@ChequeDate,@Username)";
        cmd.Parameters.AddWithValue("@PaymentDate", objpayment.PaymentDate);
        cmd.Parameters.AddWithValue("@CustCode", objpayment.CustCode);
        cmd.Parameters.AddWithValue("@Amount", objpayment.Amount);
        cmd.Parameters.AddWithValue("@ReferenceNo", objpayment.ReferenceNo);
        cmd.Parameters.AddWithValue("@ReferenceDate", objpayment.ReferenceDate);
        cmd.Parameters.AddWithValue("@Mode", objpayment.Mode);
        cmd.Parameters.AddWithValue("@BankName", objpayment.BankName);
        cmd.Parameters.AddWithValue("@ChequeNo", objpayment.ChequeNo);
        cmd.Parameters.AddWithValue("@ChequeDate", objpayment.ChequeDate);
        cmd.Parameters.AddWithValue("@Username", objpayment.Username);
        

        myDB.Execute(sSQL, cmd);

    }
    public void UpdateData(clsPayment objpayment, string paymentcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "UPDATE Payment set PaymentDate=@PaymentDate,CustCode=@CustCode,Amount=@Amount,ReferenceNo=@ReferenceNo,ReferenceDate=@ReferenceDate,Mode=@Mode,BankName=@BankName,ChequeNo=@ChequeNo,ChequeDate=@ChequeDate,Username=@Username where PaymentCode=" + paymentcode;
        cmd.Parameters.AddWithValue("@PaymentDate", objpayment.PaymentDate);
        cmd.Parameters.AddWithValue("@CustCode", objpayment.CustCode);
        cmd.Parameters.AddWithValue("@Amount", objpayment.Amount);
        cmd.Parameters.AddWithValue("@ReferenceNo", objpayment.ReferenceNo);
        cmd.Parameters.AddWithValue("@ReferenceDate", objpayment.ReferenceDate);
        cmd.Parameters.AddWithValue("@Mode", objpayment.Mode);
        cmd.Parameters.AddWithValue("@BankName", objpayment.BankName);
        cmd.Parameters.AddWithValue("@ChequeNo", objpayment.ChequeNo);
        cmd.Parameters.AddWithValue("@ChequeDate", objpayment.ChequeDate);
        cmd.Parameters.AddWithValue("@Username", objpayment.Username);
        myDB.Execute(sSQL, cmd);

    }
    public void DeleteData(string paymentcode)
    {
        cmd = new SqlCommand();
        myDB = new DBHelper();
        sSQL = "DELETE Payment where PaymentCode=" + paymentcode;

        myDB.Execute(sSQL, cmd);

    }
    public clsPayment GetData(string paymentcode)
    {
        clsPayment objpayment;
        myDB = new DBHelper();
        objpayment = new clsPayment();
        sSQL = objpayment.DispDataCode(paymentcode);
        SqlDataReader sDr = myDB.GetFromReader(sSQL);
        sDr.Read();
        if (sDr.HasRows)
        {
            objpayment.PaymentDate = Convert.ToDateTime(sDr["PaymentDate"].ToString());
            objpayment.CustCode = Convert.ToInt32(sDr["CustCode"].ToString());
            objpayment.Amount = Convert.ToDecimal(sDr["Amount"].ToString());
            objpayment.ReferenceNo = sDr["ReferenceNo"].ToString();
            objpayment.ReferenceDate = Convert.ToDateTime(sDr["ReferenceDate"].ToString());
            objpayment.Mode = sDr["Mode"].ToString();
            objpayment.BankName = sDr["BankName"].ToString();
            objpayment.ChequeNo = Convert.ToInt32(sDr["ChequeNo"].ToString());
            objpayment.ChequeDate = Convert.ToDateTime(sDr["ChequeDate"].ToString());
            objpayment.Username = sDr["Username"].ToString();
            

        }
        return objpayment;

    }
    public string DispDataAll()
    {

        sSQL = "SELECT * from Payment";
        return sSQL;
    }
    public string DispDataCode(string paymentcode)
    {
        sSQL = "SELECT * from Payment where PaymentCode=" + paymentcode;
        return sSQL;
    }
    #endregion
}