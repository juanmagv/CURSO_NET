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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="Falta el nombre" ForeColor="#CC0000">*Campo vacio</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mail:"></asp:Label>
            <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Alta" OnClick="Button1_Click" />
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WEBFORMS/Default.aspx">Retornar</asp:HyperLink>
        </div>
    </form>
</body>
</html>
