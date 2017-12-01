<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="ResetPassword" MasterPageFile="~/Main.master" %>


<asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <table align="center">
             <tr><td colspan="2" align="center"><h2>Reset Password</h2></td></tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            
            <tr>
                <td>
                    <h3>New Password:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>Confirm Password:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" runat="server" ErrorMessage="Passwords must Match" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Update" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            
        </table>
    

</asp:Content>
