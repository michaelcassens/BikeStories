<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" MasterPageFile="~/Main.master"%>


<asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <table align="center" width="50%">
        
       
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td colspan="3">
                <asp:DataList ID="dlStories" runat="server" Width="85%" HorizontalAlign="Center" 
                    CellPadding="10" RepeatColumns="5" RepeatDirection="Horizontal" ForeColor="#333333" CellSpacing="20" BorderWidth="1">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <ItemTemplate>
        <%#Eval("Story")%><br />
        
    </ItemTemplate>
    
    </asp:DataList>
    

            </td>
        </tr>
    </table>



</asp:Content>