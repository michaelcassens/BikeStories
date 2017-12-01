<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFriends.aspx.cs" Inherits="AddFriends" MasterPageFile="~/Main.master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <table align="center" width="50%">
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
            <tr> <td align="center" colspan="2"><h2>Add New Friends</h2></td></tr>
            <tr>
                <td  align="center">&nbsp;</td>
            </tr>
        <tr>
            <td align="center">
                <h3>Search By User Name:</h3>

            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:Button ID="btnSearchUserName" runat="server" Text="Search" OnClick="btnSearchUserName_Click" />
            </td>
        </tr>
        <tr>
            <td align="center">
                <h3>Search By Last Name:</h3>
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:Button ID="btnSearchLastName" runat="server" Text="Search" OnClick="btnSearchLastName_Click" />
            </td>
        </tr>

        <tr>
            <td colspan="3">
            &nbsp;

            </td>

        </tr>

            <tr>
            <td colspan="3" align="center">
                <asp:DataGrid ID="dgFriends" runat="server" BackColor="White" BorderColor="White" 
                    BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="5" GridLines="None" 
                     AutoGenerateColumns="false" Font-Size="Medium" Width="75%">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundColumn DataField="FirstName" HeaderText="First Name"></asp:BoundColumn>
                        <asp:BoundColumn DataField="LastName" HeaderText="Last Name"></asp:BoundColumn>
                        <asp:BoundColumn DataField="UserName" HeaderText="User Name"></asp:BoundColumn>
                        
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <a href="MyFPage.aspx?fid=<%#Encrypt(Convert.ToString(Eval("userID")))%>"><u>Add Friend</u></a>
                    </ItemTemplate>
                </asp:TemplateColumn>
            
                        
                    </Columns>
                </asp:DataGrid>
               
            </td>

        </tr>
    
    </table>
</asp:Content>