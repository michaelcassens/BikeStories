using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyFPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Request.QueryString["fid"] != null || Request.QueryString["confid"] != null || Request.QueryString["defid"] != null) && Session["userid"] != null)
        {
            // add friend

            User myUser = new User();
            string encrypted = "";
            string decrypted = "";
            if(Request.QueryString["fid"] != null)
            {
                encrypted = Request.QueryString["fid"].ToString();
            }
            else if(Request.QueryString["confid"] != null)
            {
                encrypted = Request.QueryString["confid"].ToString();
            }
            else if (Request.QueryString["defid"] != null)
            {
                encrypted = Request.QueryString["defid"].ToString();
            }
            decrypted = Decrypt(encrypted);

            // check to see if they are already friends..
            int there = myUser.checkExistanceOfUserFriend(Convert.ToInt32(Session["userid"]), Convert.ToInt32(decrypted));

            int blocked = myUser.checkExistanceOfBlockedUser(Convert.ToInt32(decrypted), Convert.ToInt32(Session["userid"]));
            // make sure they aren't trying to make friends with themselves
            if(Convert.ToInt32(Session["userid"]) != Convert.ToInt32(decrypted))
            {
                if(there == 0 && blocked == 0)
                {
                    // insert request
                    if (Request.QueryString["fid"] != null)
                    {
                        myUser.insertUserFriendRequest(Convert.ToInt32(Session["userid"]), Convert.ToInt32(decrypted));
                    }
                    else if (Request.QueryString["confid"] != null)
                    {
                        myUser.deleteFriendRequest(Convert.ToInt32(decrypted), Convert.ToInt32(Session["userid"]));
                        myUser.insertUserFriend(Convert.ToInt32(Session["userid"]), Convert.ToInt32(decrypted));
                        myUser.insertUserFriend(Convert.ToInt32(decrypted), Convert.ToInt32(Session["userid"]));
                    }
                    else if(Request.QueryString["defid"] != null)
                    {
                        myUser.deleteFriendRequest(Convert.ToInt32(decrypted), Convert.ToInt32(Session["userid"]));
                        myUser.insertBlockedUser(Convert.ToInt32(Session["userid"]), Convert.ToInt32(decrypted));
                    }
                }
            }
            Server.Transfer("MyPage.aspx");
        }
    }
    private string Decrypt(string cipherText)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
}