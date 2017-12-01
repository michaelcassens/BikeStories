<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewComment.aspx.cs" Inherits="AddNewComment" MasterPageFile="~/Main.master"%>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <p></p>
         <table align="center" width="50%">
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr> 
                <td>&nbsp;</td>
                <td align="center"><h2>Add a New Story</h2></td></tr>
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" valign="top">
                    <h3>Story:</h3>
                </td>
                <td align="center">
                    <asp:TextBox ID="txtStory" runat="server" TextMode="MultiLine" Rows="25" Columns="50"></asp:TextBox>
                </td>
            </tr>
             <tr><td>&nbsp;</td></tr>
            
            <tr>
                <td>&nbsp;</td>
                <td colspan="1" align="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
             <tr><td>&nbsp;</td></tr>
        </table>
    </div>


</asp:Content>