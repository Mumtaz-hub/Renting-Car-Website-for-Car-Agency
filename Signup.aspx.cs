using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

public partial class Signup : System.Web.UI.Page
{
    clsUser objuser;
    // string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsignup_Click(object sender, EventArgs e)
    {
         objuser = new clsUser();
        try
        {
            bool ans;
            objuser.Username = txtuname.Text;
            objuser.Password = txtpswd.Text;
            objuser.FullName = txtfname.Text;
            objuser.Email = txtemail.Text;
            
          objuser.UserType = utype.Text;
            if (chkStatus.Checked == true)
            {
                objuser.Status = "Active";
            }
            else
            {
                objuser.Status = "Inactive";
            }

            objuser.MobileNo = txtmno.Text;
            ans = objuser.CheckUser(txtuname.Text);
            if (ans == true)
            {
                Alert.Visible = true;
                return;
            }
            else
            {

                objuser.InsertData(objuser);
            }

            
        }
        catch (Exception x)
        {
            Response.Write(x.Message);
        }
     }
    
}