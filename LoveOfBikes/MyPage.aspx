<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyPage.aspx.cs" Inherits="MyPage" MasterPageFile="~/Main.master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table cellpadding="5" border ="0" align="center">

        <tr>

            <td valign="top" align="center">

&nbsp;<asp:DataList ID="dlStories" runat="server" BackColor="White" BorderColor="#E7E7FF" Width="75%" HorizontalAlign="Center"
    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" RepeatColumns="5" RepeatDirection="Horizontal">
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle HorizontalAlign="Center" BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <ItemTemplate>
        <%#Eval("Story")%><br />
        
        <p>
            
        </p>

    </ItemTemplate>

    </asp:DataList>
&nbsp;
                <p></p>
                <asp:HyperLink ID="hlAddMyOwnStory" runat="server" Text="Add a New Story" NavigateUrl="~/AddNewComment.aspx" Font-Size="Medium" Font-Underline="true"></asp:HyperLink>&nbsp;|&nbsp;
    <asp:HyperLink ID="hlSettings" runat="server" Text="Settings" NavigateUrl="~/Settings.aspx" Font-Size="Medium" Font-Underline="true"></asp:HyperLink>
     

            </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
    </table>
    
    
</asp:Content>