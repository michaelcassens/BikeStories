using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Stories
/// </summary>
public class Stories
{
	public Stories()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet getRandomStory()
    {
        Random myRandom = new Random();
        DataAccess myAccess = new DataAccess();
        DataSet ds = getHighestStoryID();
        DataSet myDS = null;
        if (ds.Tables[0].Rows.Count > 0)
        {
            do
            {

                // need to change to get the biggest quote id
                int randomNumber = myRandom.Next(1, Convert.ToInt32(ds.Tables[0].Rows[0]["StoryID"])+1);

                string myQuery = "spGetSpecificStoryByStoryID";
                SqlParameter[] myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("storyID", randomNumber);
                myDS = myAccess.getQuery(myQuery, myParameters);
            }
            while (myDS.Tables[0].Rows.Count == 0);
        }
        return myDS;

    }




    private DataSet getHighestStoryID()
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetHighestStoryID";
        DataSet myDS = myAccess.getQuery(myQuery);

        return myDS;

    }

    public int insertNewStory(int userID, string story)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spInsertNewStory";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("story", story);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int DeleteStory(int storyID)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spDeleteStory";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("storyID", storyID);
        
        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int UpdateStory(string story, int storyID)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spUpdateStory";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("story", story);
        myParameters[1] = new SqlParameter("storyID", storyID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public DataSet getSpecificStory(int specificStoryID)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetSpecificStoryByStoryID";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("storyID", specificStoryID);
        
        DataSet ds = myAccess.getQuery(myQuery, myParameters);

        return ds;
    }

    public DataSet getAllStories()
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetAllStories";
        
        DataSet ds = myAccess.getQuery(myQuery);

        return ds;
    }


}