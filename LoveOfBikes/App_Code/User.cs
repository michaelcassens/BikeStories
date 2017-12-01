using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
	public User()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int checkUser(string user, string pwd)
    {
        DataAccess myAccess = new DataAccess();

        // encrypt password before testing..
        Byte[] encryptedPWD = encrypt(pwd);

        string myQuery = "spCheckUser";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("username", user);
        myParameters[1] = new SqlParameter("pwd", encryptedPWD);

        int rows = myAccess.executeScalar(myQuery, myParameters);

        return rows;
    }

    

    public int checkExistanceOfBlockedUser(int userID, int blockedUserID)
    {
        DataAccess myAccess = new DataAccess();



        string myQuery = "spCheckExistenceOfBlockedUser";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("blockedUserID", blockedUserID);

        int rows = myAccess.executeScalar(myQuery, myParameters);

        return rows;
    }

    public int checkExistanceOfUserFriend(int userID, int friendID)
    {
        DataAccess myAccess = new DataAccess();



        string myQuery = "spCheckExistenceOfUserFriends";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("friendID", friendID);

        int rows = myAccess.executeScalar(myQuery, myParameters);

        return rows;
    }

    public int insertNewUser(string firstName, string lastName, string email, DateTime birthdate, string user, string pwd, int visibility)
    {
        DataAccess myAccess = new DataAccess();

        // encrypt password before testing..
        Byte[] encryptedPWD = encrypt(pwd);

        string myQuery = "spInsertNewUser";
        SqlParameter[] myParameters = new SqlParameter[7];
        myParameters[0] = new SqlParameter("firstName", firstName);
        myParameters[1] = new SqlParameter("lastName", lastName);
        myParameters[2] = new SqlParameter("email", email);
        myParameters[3] = new SqlParameter("birthdate", birthdate);
        myParameters[4] = new SqlParameter("username", user);
        myParameters[5] = new SqlParameter("pwd", encryptedPWD);
        myParameters[6] = new SqlParameter("visibiltyType", visibility);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int updateUser(string firstName, string lastName, string email, DateTime birthdate, string user, string pwd, int visibility, int userID)
    {
        DataAccess myAccess = new DataAccess();

        // encrypt password before testing..
        Byte[] encryptedPWD = encrypt(pwd);

        string myQuery = "spUpdateUser";
        SqlParameter[] myParameters = new SqlParameter[8];
        myParameters[0] = new SqlParameter("firstName", firstName);
        myParameters[1] = new SqlParameter("lastName", lastName);
        myParameters[2] = new SqlParameter("email", email);
        myParameters[3] = new SqlParameter("birthdate", birthdate);
        myParameters[4] = new SqlParameter("username", user);
        myParameters[5] = new SqlParameter("pwd", encryptedPWD);
        myParameters[6] = new SqlParameter("visibilityType", visibility);
        myParameters[7] = new SqlParameter("userID", userID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int updateUserWithoutPWD(string firstName, string lastName, string email, DateTime birthdate, string user, int visibility, int userID)
    {
        DataAccess myAccess = new DataAccess();

        
        string myQuery = "spUpdateUserWithoutPassword";
        SqlParameter[] myParameters = new SqlParameter[7];
        myParameters[0] = new SqlParameter("firstName", firstName);
        myParameters[1] = new SqlParameter("lastName", lastName);
        myParameters[2] = new SqlParameter("email", email);
        myParameters[3] = new SqlParameter("birthdate", birthdate);
        myParameters[4] = new SqlParameter("username", user);
        myParameters[5] = new SqlParameter("visibilityType", visibility);
        myParameters[6] = new SqlParameter("userID", userID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int updateUserPassword(string pwd, int userID)
    {
        DataAccess myAccess = new DataAccess();

        // encrypt password before testing..
        Byte[] encryptedPWD = encrypt(pwd);

        string myQuery = "spUpdateUserPassword";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("pwd", encryptedPWD);
        myParameters[1] = new SqlParameter("userID", userID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int insertUserQuote(int quoteID, int userID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spInsertNewUserQuotes";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("quoteID", quoteID);
        myParameters[1] = new SqlParameter("userID", userID);
        
        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int checkUserQuote(int quoteID, int userID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spCheckUserQuote";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("quoteID", quoteID);
       
        
        int rows = myAccess.executeScalar(myQuery, myParameters);

        return rows;
    }
    

    public int deleteUserFriend(int userID, int friendID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spDeleteUserFriend";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("friendID", friendID);
        
        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }
     public int deleteFriendRequest(int userID, int friendID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spDeleteFriendRequest";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("friendID", friendID);
        
        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }
    
    
    public int insertUserFriend(int userID, int friendID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spInsertUserFriend";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("friendID", friendID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int insertUserFriendRequest(int userID, int friendID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spInsertUserFriendRequest";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("friendID", friendID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }

    public int insertBlockedUser(int userID, int blockedUserID)
    {
        DataAccess myAccess = new DataAccess();


        string myQuery = "spInsertBlockUser";
        SqlParameter[] myParameters = new SqlParameter[2];
        myParameters[0] = new SqlParameter("userID", userID);
        myParameters[1] = new SqlParameter("blockedUserID", blockedUserID);

        int rows = myAccess.nonQuery(myQuery, myParameters);

        return rows;
    }


    public DataSet getFriendRequests(int userID)
    {
        
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetFriendRequests";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("userID", userID);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

    public DataSet getStoriesByUserID(int userID)
    {
        Random myRandom = new Random();
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetStoriesByUserID";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("userID", userID);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

    public DataSet getUserFriendsByUserID(int userID)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetUserFriends";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("userID", userID);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }
    
        
    
        
    public DataSet searchForUsersByUserNameLoggedIn(string username, int userID, int visibility)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spSearchForFriendsBasedOnVisibilityWithUserNameLoggedIn";
        SqlParameter[] myParameters = new SqlParameter[3];
        myParameters[0] = new SqlParameter("username", username);
        myParameters[1] = new SqlParameter("userid", userID);
        myParameters[2] = new SqlParameter("visibility", visibility);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

    public DataSet searchForUsersByUserNameLoggedOut(string username)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spSearchForFriendsBasedOnVisibilityWithUserNameLoggedOut";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("username", username);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

         public DataSet searchForUserByLastNameLoggedIn(string lastname, int userID, int visibility)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spSearchForFriendsBasedOnVisibilityWithLastNameLoggedIn";
        SqlParameter[] myParameters = new SqlParameter[3];
        myParameters[0] = new SqlParameter("lastname", lastname);
        myParameters[1] = new SqlParameter("userID", userID);
        myParameters[2] = new SqlParameter("visibility", visibility);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }
         public DataSet searchForUserByLastNameLoggedOut(string lastname)
         {
             DataAccess myAccess = new DataAccess();

             string myQuery = "spSearchForFriendsBasedOnVisibilityWithLastNameLoggedOut";
             SqlParameter[] myParameters = new SqlParameter[1];
             myParameters[0] = new SqlParameter("lastname", lastname);
             DataSet myDS = myAccess.getQuery(myQuery, myParameters);

             return myDS;

         }
        
        public DataSet getUserByUserName(string username)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetSpecificUserByUserName";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("username", username);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

        public DataSet getUserByUserID(int userID)
        {
            DataAccess myAccess = new DataAccess();

            string myQuery = "spGetUserByUserID";
            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("userID", userID);
            DataSet myDS = myAccess.getQuery(myQuery, myParameters);

            return myDS;

        }

    public DataSet getUserByLastName(string lastname)
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetUsersByLastName";
        SqlParameter[] myParameters = new SqlParameter[1];
        myParameters[0] = new SqlParameter("lastname", lastname);
        DataSet myDS = myAccess.getQuery(myQuery, myParameters);

        return myDS;

    }

    public DataSet getVisibility()
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetAllVisibilityTypes";
        
        DataSet myDS = myAccess.getQuery(myQuery);

        return myDS;

    }

    public DataSet getAllUsers()
    {
        DataAccess myAccess = new DataAccess();

        string myQuery = "spGetUsers";

        DataSet myDS = myAccess.getQuery(myQuery);

        return myDS;

    }
    /*
     * This method encrypts a string and returns the byte array using the md5 algorithm
     */
    private Byte[] encrypt(string unencryptedString)
    {
        // encrypt password before inserted..
        Byte[] hashedDataBytes = null;
        UTF8Encoding encoder = new UTF8Encoding();

        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

        hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes(unencryptedString));

        return hashedDataBytes;
    }


}


