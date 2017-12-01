<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="~/Main.master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p></p>
    <p></p>
    <div>
        
        <table align="center">
             <tr><td colspan="2" align="center"><h2>Login</h2></td></tr>
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
                <td>
                    <h3>Password:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtPWD" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:HyperLink ID="hlForgotPassword" runat="server" NavigateUrl="~/ForgotPassword.aspx"><h4>Forgot Password?</h4></asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:HyperLink ID="hlRegister" runat="server" NavigateUrl="Register.aspx"><h4>Register</h4></asp:HyperLink>
                </td>
            </tr>

        </table>
    </div>
    </asp:Content>