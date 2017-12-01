using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Author
/// </summary>
public class Author
{
	public Author()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataSet getAuthorIDByAuthorName(string author)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spGetAuthorIDByAuthorName";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("authorName", author);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

    public int insertNewAuthor(string author)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spInsertNewAuthor";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("author", author);
        int authorID = myAccess.executeScalar(myQuery, myParameters);

        return authorID;

    }

}