using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

public partial class admin_Signup : System.Web.UI.Page
{
    clsAdminUser objAdminUser;
   // string sSQL;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        objAdminUser = new clsAdminUser();
        try
        {
            bool ans;
            objAdminUser.Password = txtpswd.Text;
            objAdminUser.FullName = txtfname.Text;
            objAdminUser.Email = txtemail.Text;
            
          objAdminUser.UserType = utype.Text;
            if (chkStatus.Checked == true)
            {
                objAdminUser.Status = "Active";
            }
            else
            {
                objAdminUser.Status = "Inactive";
            }

            objAdminUser.Mobile = txtmno.Text;
            ans = objAdminUser.CheckUser(txtemail.Text);
            if (ans == true)
            {
                Alert.Visible = true;
                return;
            }
            else
            {

                objAdminUser.InsertData(objAdminUser);
            }

            
        }
        catch (Exception x)
        {
            Response.Write(x.Message);
        }
     }
}