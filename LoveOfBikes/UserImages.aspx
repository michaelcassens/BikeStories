<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserImages.aspx.cs" Inherits="UserImages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/blackborwo.jpg" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
    

    </div>
    </form>
</body>
</html>
