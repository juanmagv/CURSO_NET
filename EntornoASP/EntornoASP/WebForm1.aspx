<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EntornoASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="stylesheet1.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Ingrese primer valor<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Ingrese segundo valor<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Suma</asp:ListItem>
            <asp:ListItem>Resta</asp:ListItem>
            <asp:ListItem>Multi</asp:ListItem>
            <asp:ListItem>Divi</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="calcular" OnClick="Button1_Click1"/>
       
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       
    </form>
</body>
</html>
