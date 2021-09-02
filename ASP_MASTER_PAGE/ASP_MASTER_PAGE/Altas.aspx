<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Altas.aspx.cs" Inherits="ASP_MASTER_PAGE.Altas" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
   <div id="container">
     <div class="filas"><H1>GESTIÓN DE CLIENTES</H1></div>
     <div class="filas"><h2>Altas de clientes</h2></div>     
     <div class="filas">
          <div class="titulos">id:</div>
          <div class="controles">
              <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="Falta el ID" ForeColor="#CC0000">*Debe rellenar campo</asp:RequiredFieldValidator>
          </div>
    </div>
    <div class="filas">
         <div class="titulos">Nombre:</div>
          <div class="controles">
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="Falta el Nombre" ForeColor="#CC0000">*Debe rellenar campo</asp:RequiredFieldValidator>
          </div>
    </div>
    <div class="filas">
        <div class="titulos">Apellido 1:</div>
        <div class="controles">
            <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtApellido1" ErrorMessage="Falta el primer apellido" ForeColor="#CC0000">*Debe rellenar campo</asp:RequiredFieldValidator>
        </div>
    </div>
   <div class="filas">
        <div class="titulos">Apellido 2:</div>
        <div class="controles">
            <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtApellido2" ErrorMessage="Falta el segundo  apellido" ForeColor="#CC0000">*Debe rellenar campo</asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="filas">
        <div class="titulos">Ciudad:</div>
        <div class="controles">
            <asp:TextBox ID="txtciudad" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtciudad" ErrorMessage="Falta la ciudad" ForeColor="#CC0000">*Debe rellenar campo</asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="filas">
        <div class="titulos">Categoría:</div>
        <div class="controles">
            <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtCategoria" ErrorMessage="La categoria no es válida" ForeColor="#CC0000" MaximumValue="99" MinimumValue="1">*Debe ser un valor numérico</asp:RangeValidator>
        </div>
    </div>
    <div class="filas">
        <asp:Button ID="btnAnnadir" runat="server" Text="Añadir" OnClick="btnAnnadir_Click" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>

    <div class="filas">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
    </div>
</asp:Content>
