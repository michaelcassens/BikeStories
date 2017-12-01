using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["attempts"] != null)
        {
            if(Convert.ToInt32(Session["attempts"]) == 0)
            {
                User myUser = new User();
                DataSet ds = myUser.getAllUsers();
                dgView.DataSource = ds.Tables[0];
                dgView.DataBind();
            }
        }
    }
}