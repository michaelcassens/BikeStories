using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["username"] != null)
        {
            Server.Transfer("MyPage.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string user = txtUserName.Text;
        string pwd = txtPWD.Text;

        User myUser = new User();
        int good = myUser.checkUser(user, pwd);
        if(good > 0)
        {
            lblMessage.Text = "Logged in!";
            Session["username"] = user;
            DataSet ds = myUser.getUserByUserName(user);
            Session["userID"] = Convert.ToInt32(ds.Tables[0].Rows[0]["userID"]);
            Server.Transfer("MyPage.aspx");
        }
        else
        {
            lblMessage.Text = "Your username/password combination is incorrect.";
        }
    }
}