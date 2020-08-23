using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

public partial class admin_Default : System.Web.UI.Page
{
    clsAdminUser objAdminUser;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        objAdminUser = new clsAdminUser();
        try
        {
            bool ans;
            ans = objAdminUser.UserLogin(txtemail.Text, txtPassword.Text);
            if (ans == true)
            {
               // objAdminUser = objAdminUser.GetData(txtemail.Text);
              /*  Session["email"] = objAdminUser.Email;
                Session["fullname"] = objAdminUser.FullName;
                Session["usertype"] = objAdminUser.UserType;*/
                Response.Redirect("Home.aspx");
            }
            else
            {
                Alert.Visible = true;
            }
        }
        catch (Exception x)
        {
            Response.Write(x.Message);
        }

    }
}
