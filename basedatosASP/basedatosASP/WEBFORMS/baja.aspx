<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="baja.aspx.cs" Inherits="basedatosASP.baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Nombre de usuario<asp:TextBox ID="txtBaja" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="txtBorrar" runat="server" OnClick="txtBorrar_Click" Text="Borrar" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
