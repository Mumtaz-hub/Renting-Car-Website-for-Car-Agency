using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    clsUser objuser;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        objuser = new clsUser();
        try
        {
            bool ans;
            ans = objuser.UserLogin(txtuname.Text, txtPassword.Text);
            if (ans == true)
            {
                objuser = objuser.GetData(txtuname.Text);
                Session["uname"] = objuser.Username;
                Session["fullname"] = objuser.FullName;
                Session["usertype"] = objuser.UserType;
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