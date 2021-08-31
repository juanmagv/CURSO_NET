<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="basedatosASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/alta.aspx">Alta de usuario</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/consulta.aspx">Consulta de usuario</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/baja.aspx">Baja de usuario</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/modificacion.aspx">Modificacion de usuario</asp:HyperLink>
        </div>
    </form>
</body>
</html>
