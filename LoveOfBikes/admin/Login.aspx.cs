using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(txtPWD.Text == "t3st" && txtUser.Text == "test")
        {
            Session["attempts"] = 0;
            Server.Transfer("View.aspx");

        }
        else
        {
            if(Session["attempts"] != null)
            {
                Session["attempts"] = Convert.ToInt32(Session["attempts"]) + 1;
            }
            else
            {
                Session["attempts"] = 1;
            }
            
        }
    }
}