<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateFriends.aspx.cs" Inherits="UpdateFriends" MasterPageFile="~/Main.master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table align="center" width="25%">
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr> <td align="center"><h2>Update Friends</h2></td></tr>
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr>
                <td align="center">

                
      <asp:DataGrid ID="dgFriends" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
            BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Font-Size="Medium" Width="75%"
            >

            <AlternatingItemStyle BackColor="White" />

            <Columns>
                <asp:TemplateColumn HeaderText="My Friends">
                    <ItemTemplate>
                        <a href="MyFriendsPageR.aspx?fid=<%#Encrypt(Convert.ToString(Eval("userID")))%>"><%#Eval("username") %></a>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Remove">
                    <ItemTemplate>
                        <a href="RemoveFriend.aspx?fid=<%#Encrypt(Convert.ToString(Eval("userID")))%>">Delete</a>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F7DE" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" Mode="NumericPages" />
            <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        </asp:DataGrid>
      <asp:Label ID="lblMessage" runat="server"></asp:Label>

                    </td>
            </tr>
        </table>
    </div>
</asp:Content>