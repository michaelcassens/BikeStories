<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="admin_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="dgView" AutoGenerateColumns="false" runat="server">
            <Columns>

                <asp:BoundField DataField="username" />
            </Columns>

        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
