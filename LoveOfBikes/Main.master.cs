using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            hlUser.Text = "Welcome " + Session["username"].ToString();
            hlLogin.Text = "Logout";
            hlLogin.NavigateUrl = "~/Logout.aspx";
            hlLogin2.Text = "Logout";
            hlLogin2.NavigateUrl = "~/Logout.aspx";
        }
    
    }
}
