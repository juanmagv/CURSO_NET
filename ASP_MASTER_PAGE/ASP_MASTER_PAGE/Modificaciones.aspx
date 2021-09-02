<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificaciones.aspx.cs" Inherits="ASP_MASTER_PAGE.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="container">
     <div class="filas"><H1>GESTIÓN DE CLIENTES</H1></div>
     <div class="filas"><h2>Modificar clientes</h2></div>     
     <div class="filas">
          <div class="titulos">id:</div>
          <div class="controles">
              <asp:DropDownList ID="dlID" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="dlID_SelectedIndexChanged">
              </asp:DropDownList>
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT [ID] FROM [cliente]"></asp:SqlDataSource>
              <asp:Button ID="btBuscar" runat="server" OnClick="btBuscar_Click" Text="Buscar" />
          </div>
    </div>
    <div class="filas">
         <div class="titulos">Nombre:</div>
          <div class="controles">
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
          </div>
    </div>
    <div class="filas">
        <div class="titulos">Apellido 1:</div>
        <div class="controles">
            <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
        </div>
    </div>
   <div class="filas">
        <div class="titulos">Apellido 2:</div>
        <div class="controles">
            <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="filas">
        <div class="titulos">Ciudad:</div>
        <div class="controles">
            <asp:TextBox ID="txtciudad" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="filas">
        <div class="titulos">Categoría:</div>
        <div class="controles">
            <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="filas">
        <asp:Button ID="btnModificar" runat="server" OnClick="Button1_Click" Text="Modificar" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>

    <div class="filas">
    </div>
    </div>
    </asp:Content>