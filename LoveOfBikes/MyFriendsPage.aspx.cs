using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyFriendsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            if(!Page.IsPostBack)
        {
            if (Session["friendsID"] != null)
            {
                User myUser = new User();
                fillStories();
                DataSet ds = myUser.getUserByUserID(Convert.ToInt32(Session["friendsID"]));
                if(ds.Tables[0].Rows.Count > 0)
                {
                    lblFriendsName.Text = ds.Tables[0].Rows[0]["firstName"] + " " + ds.Tables[0].Rows[0]["lastName"] + "'s page";
                }
            }

            
        }
    }

    private void fillStories()
    {
        User myUser = new User();
        DataSet ds = myUser.getStoriesByUserID(Convert.ToInt32(Session["friendsID"]));
        dlQuotes.DataSource = ds.Tables[0];
        dlQuotes.DataBind();

    }
}