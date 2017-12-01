<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FriendRequests.aspx.cs" Inherits="FriendRequests" MasterPageFile="~/Main.master" %>


<asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
     <table align="center" width="75%">
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr> <td align="center"><h2>Friend Requests</h2></td></tr>
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    <asp:DataGrid ID="dgFriends" runat="server" BackColor="White" BorderColor="White" 
                    BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AutoGenerateColumns="false"
                         Font-Size="Medium" Width="50%">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundColumn DataField="FirstName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="LastName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="UserName"></asp:BoundColumn>
                        
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <a href="MyFPage.aspx?confid=<%#Encrypt(Convert.ToString(Eval("UserRequestID")))%>">Confirm Friend</a>
                            </ItemTemplate>
                        </asp:TemplateColumn>
            
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <a href="MyFPage.aspx?defid=<%#Encrypt(Convert.ToString(Eval("UserRequestID")))%>">Deny Request</a>
                            </ItemTemplate>
                        </asp:TemplateColumn>
            
                    </Columns>
                </asp:DataGrid>
                </td>
            </tr>
        </table>

</asp:Content>

