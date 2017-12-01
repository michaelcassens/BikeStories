<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" MasterPageFile="~/Main.master" %>
<%@ Register TagPrefix="qt" TagName="reg" Src="~/UserControls/RegisterControl.ascx" %>

<asp:Content ID="content" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <qt:reg id="registration" runat="server"></qt:reg>    
    

</asp:Content>
