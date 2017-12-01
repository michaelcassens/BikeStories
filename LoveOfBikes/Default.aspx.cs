using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Stories myStory = new Stories();
        DataSet ds = myStory.getRandomStory();
        if(ds != null)
        {
            lblDailyStory.Text = ds.Tables[0].Rows[0]["Story"].ToString();
        }
        else
        {
            lblDailyStory.Text = "There are no stories yet.";
        }
        

    }
}