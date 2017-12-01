using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            fillStories();
        }
        
    }
    
    private void fillStories()
    {
        Stories myStory = new Stories();
        DataSet ds = myStory.getAllStories();
        fillDataSet(ds);

    }

    
    
    private void fillDataSet(DataSet ds)
    {
        Cache["results"] = ds;
        dlStories.DataSource = ds.Tables[0];
        dlStories.DataBind();
    }
    
    protected void dgResults_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {

     //   dlStories.DataSource = Cache["results"];
      //  dlStories.CurrentPageIndex = e.NewPageIndex;
       // dlStories.DataBind();
      
    }
    
}