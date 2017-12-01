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

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Communication myCom = new Communication();

        string userName = txtUserName.Text;
        User myUser = new User();
        DataSet ds = myUser.getUserByUserName(userName);
        if(ds.Tables[0].Rows.Count > 0)
        {
            string email = ds.Tables[0].Rows[0]["email"].ToString();
            string userID = ds.Tables[0].Rows[0]["userID"].ToString();
            userID = Encrypt(userID);
            string body = "Click here to reset your password or copy and paste the link into your browser: http://www.atquotable.com/ResetPassword.aspx?id=" + userID;
            myCom.sendMessage(email, "Password Reset", body);
            lblMessage.Text = "Reset Sent!";
            txtUserName.Text = "";
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