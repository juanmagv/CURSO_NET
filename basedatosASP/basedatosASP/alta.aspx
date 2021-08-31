<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="basedatosASP.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mail:"></asp:Label>
            <asp:TextBox ID="txtMail" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Alta" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
        </div>
    </form>
</body>
</html>
