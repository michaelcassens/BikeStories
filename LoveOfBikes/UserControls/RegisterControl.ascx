<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RegisterControl.ascx.cs" Inherits="UserControls_RegisterControl" %>

<div>
        <p></p>
        <table align="center" width="25%">
            <tr>
                <td colspan="2" align="center">&nbsp;</td>
            </tr>
            <tr><td colspan="4" align="center"><h2><asp:Label ID="lblTitle" runat="server"></asp:Label></h2></td></tr>
            <tr>
                <td colspan="2" align="center">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>First Name:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtFirstName" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>Last Name:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtLastName" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>Email:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" TextMode="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtEmail" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>Birth Date:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtBirthDate" TextMode="Date" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>User Name:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtUserName" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <h3>Password:</h3>
                </td>
                <td>
                    <asp:TextBox ID="txtPWD" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rqPWD" ControlToValidate="txtPWD" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
          
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSubmit_Click" style="height: 35px" />
                </td>
            </tr>
            
        </table>
    </div>