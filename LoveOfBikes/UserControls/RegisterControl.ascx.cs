using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_RegisterControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        //    fillVisibility();
            if (Session["userid"] != null)
            {
                // enter all the stuff
                fillUserInfo();
                btnSubmit.Text = "Update";
                lblTitle.Text = "Update Profile";
                rqPWD.Enabled = false;
            }
            else
            {
                btnSubmit.Text = "Register";
                lblTitle.Text = "Registration";
                rqPWD.Enabled = true;
            }
        }
        
    }

    private void fillUserInfo()
    {
        User myUser = new User();
        DataSet ds = myUser.getUserByUserID(Convert.ToInt32(Session["userid"]));
        if(ds.Tables[0].Rows.Count > 0)
        {
            txtFirstName.Text = ds.Tables[0].Rows[0]["firstName"].ToString();
            txtLastName.Text = ds.Tables[0].Rows[0]["lastName"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            txtBirthDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["birthdate"]).ToString("yyyy-MM-dd");
            string visibility = ds.Tables[0].Rows[0]["visibilityType"].ToString();
          //  ddlVisibilty.Items.FindByValue(visibility).Selected = true;
            txtUserName.Text = ds.Tables[0].Rows[0]["username"].ToString();
        }

    }
    private void fillVisibility()
    {
        //User myUser = new User();
        //DataSet ds = myUser.getVisibility();
        //ddlVisibilty.DataSource = ds.Tables[0];
        //ddlVisibilty.DataTextField = "VisibilityType";
        //ddlVisibilty.DataValueField = "VisibilityTypeID";
        //ddlVisibilty.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        User myUser = new User();
        int success = 0;
        // make sure the user name doesn't already exist
        
            if(Session["userid"] == null)
            {
                DataSet ds = myUser.getUserByUserName(txtUserName.Text);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblMessage.Text = "This username is already in use.";
                }
                else
                {
                    success = myUser.insertNewUser(txtFirstName.Text, txtLastName.Text, txtEmail.Text, Convert.ToDateTime(txtBirthDate.Text), txtUserName.Text,
                    txtPWD.Text, -1);
                }
               
        
            }
            else
            {
                if(txtPWD.Text != "")
                {
                    success = myUser.updateUser(txtFirstName.Text, txtLastName.Text, txtEmail.Text, Convert.ToDateTime(txtBirthDate.Text), txtUserName.Text,
                    txtPWD.Text, -1, Convert.ToInt32(Session["userid"]));
        
                }
                else
                {
                    success = myUser.updateUserWithoutPWD(txtFirstName.Text, txtLastName.Text, txtEmail.Text, Convert.ToDateTime(txtBirthDate.Text), txtUserName.Text,
                   -1, Convert.ToInt32(Session["userid"]));
                }
                
            }
            if (success > 0)
            {
                if (Session["userid"] != null)
                {
                    lblMessage.Text = "Updated Successfully!";
                }
                else
                {
                    lblMessage.Text = "Registered Successfully!";
                }
                Session["username"] = txtUserName.Text;
                DataSet ds1 = myUser.getUserByUserName(txtUserName.Text);
                Session["userID"] = Convert.ToInt32(ds1.Tables[0].Rows[0]["userID"]);
                Server.Transfer("MyPage.aspx");
            }
            else
            {
                if (Session["userid"] != null)
                {
                    lblMessage.Text = "Something has gone wrong with the update.";
                }
                else
                {

                }
                lblMessage.Text = "Something has gone wrong with the registration.";
            }
        
    }
}