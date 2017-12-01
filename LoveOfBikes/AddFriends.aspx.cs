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

public partial class AddFriends : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    ///  logged in, should call one method, if not, call another..
    ///  
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSearchUserName_Click(object sender, EventArgs e)
    {
        User myUser = new User();
        DataSet ds = null;
        if (Session["username"] != null)
        {
           
            ds = myUser.searchForUsersByUserNameLoggedIn(txtUserName.Text, Convert.ToInt32(Session["userid"]),2);
            DataSet ds2 = myUser.searchForUsersByUserNameLoggedIn(txtUserName.Text, Convert.ToInt32(Session["userid"]), 3);
            ds.Merge(ds2);
        }
        else
        {
            ds = myUser.searchForUsersByUserNameLoggedOut(txtUserName.Text);
        }
        
        bindData(ds);
    }
    protected void btnSearchLastName_Click(object sender, EventArgs e)
    {
        DataSet ds = null;
        
        User myUser = new User();
        if (Session["username"] != null)
        {
            ds = myUser.searchForUserByLastNameLoggedIn(txtLastName.Text, Convert.ToInt32(Session["userid"]),2);
            DataSet ds2 = myUser.searchForUserByLastNameLoggedIn(txtLastName.Text, Convert.ToInt32(Session["userid"]), 3);
            ds.Merge(ds2);
        }
        else
        {
            ds = myUser.searchForUserByLastNameLoggedOut(txtLastName.Text);
        }
        
        bindData(ds);
    }

    private void bindData(DataSet ds)
    {
        if(ds.Tables[0].Rows.Count > 0)
        {
            dgFriends.DataSource = ds.Tables[0];
            dgFriends.DataBind();
            dgFriends.Visible = true;
            
        }
        else
        {
            dgFriends.Visible = false;
            
        }
        

    }

    protected string Encrypt(string clearText)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }
}