<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateStories.aspx.cs" Inherits="UpdateStories" MasterPageFile="~/Main.master" %>

<asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <table align="center" width="75%">
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr> <td align="center"><h2>Update Stories</h2></td></tr>
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr>
                <td align="center">

    <asp:DataList ID="dlStories" runat="server" BackColor="White" BorderColor="#E7E7FF" Width="75%" HorizontalAlign="Center"
    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" RepeatColumns="5" RepeatDirection="Horizontal">
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle HorizontalAlign="Center" BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <ItemTemplate>
        <%#Eval("Story")%><br />
        
            <a href="AddNewComment.aspx?sid=<%#Encrypt(Convert.ToString(Eval("StoryID"))) %>"><u>Edit</u></a>
        &nbsp;&nbsp;&nbsp;
            <a href="DeleteStory.aspx?sid=<%#Encrypt(Convert.ToString(Eval("StoryID"))) %>"><u>Delete</u></a>

    </ItemTemplate>
    
    </asp:DataList>
                          </td>
            </tr>
        </table>
</asp:Content>

