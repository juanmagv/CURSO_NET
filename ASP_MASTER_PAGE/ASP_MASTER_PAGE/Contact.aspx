<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASP_MASTER_PAGE.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Mi pagina de contacto.</h3>
    <address>
        C/ Ramirin<br />
        Langreo 33930</address>
<address>
        666 666 666</address>
<address>
        <img alt="" src="IMG/images.jpg" style="width: 273px; height: 184px" /></address>

    <address>
        <strong>Soporte:</strong>   <a href="mailto:Support@example.com">Soporte@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
<address>
        &nbsp;</address>
</asp:Content>
