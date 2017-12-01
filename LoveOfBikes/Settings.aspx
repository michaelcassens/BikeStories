<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Settings" MasterPageFile="~/Main.master"  MaintainScrollPositionOnPostback="true" %>
    <asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    
        <table align="center">
            <tr><td colspan="4">&nbsp;</td></tr>
            <tr><td colspan="4" align="center"><h2>Settings</h2></td></tr>
            <tr><td colspan="4">&nbsp;</td></tr>
            <tr>
                <td>
                    <asp:Panel ID="myProfile" runat="server" Width="100" Height="100" HorizontalAlign="Center" >
                        <p></p>
                        <asp:HyperLink runat="server" NavigateUrl="UpdateProfile.aspx" Font-Underline="true"><h3>Update Profile</h3></asp:HyperLink>
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Stories" runat="server" Width="100" Height="100" HorizontalAlign="Center" >
                        <asp:HyperLink runat="server" NavigateUrl="UpdateStories.aspx" Font-Underline="true"><h3>Update Stories</h3></asp:HyperLink>
                    </asp:Panel>
                </td>
                
            </tr>
        </table>



    </asp:Content>