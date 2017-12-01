<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" MasterPageFile="~/Main.master" %>

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
                    <h3>User Name:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            
        </table>
    

</asp:Content>
