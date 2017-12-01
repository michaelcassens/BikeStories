<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyFriendsPage.aspx.cs" Inherits="MyFriendsPage" MasterPageFile="~/Main.master" %>

<asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <table align="center" width="75%">
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr> <td align="center"><h2><asp:Label ID="lblFriendsName" runat="server"></asp:Label></h2></td></tr>
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
     <tr>
                <td align="center">
    <asp:DataList ID="dlQuotes" runat="server" BackColor="White" BorderColor="#E7E7FF" Width="75%" HorizontalAlign="Center"
    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" RepeatColumns="5" RepeatDirection="Horizontal">
        <AlternatingItemStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle HorizontalAlign="Center" BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <ItemTemplate>
        <%#Eval("Quote")%><br />
        -- <%#Eval("Author")%>
        <p>
            
        </p>
        <a href="MyPage.aspx?id=<%#Eval("QuoteID") %>"><u>Add This Quote</u></a>
    </ItemTemplate>

    </asp:DataList>

   </td>
            </tr>
    <tr><td>&nbsp;</td></tr>
            </table>

</asp:Content>
