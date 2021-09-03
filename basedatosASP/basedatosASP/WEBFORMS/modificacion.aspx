<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificacion.aspx.cs" Inherits="basedatosASP.modificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            Nombre de usuario:<asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            Clave:<asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            <br />
            Mail:<asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modificar" />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WEBFORMS/Default.aspx">Retornar</asp:HyperLink>
            <br />
            <br />
          
        </div>
    </form>
</body>
</html>
