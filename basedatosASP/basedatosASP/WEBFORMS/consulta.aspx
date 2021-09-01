<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="basedatosASP.consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            Ingrese el nombre de usuario<asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WEBFORMS/Default.aspx">Retornar</asp:HyperLink>
           
        </div>
    </form>
</body>
</html>
