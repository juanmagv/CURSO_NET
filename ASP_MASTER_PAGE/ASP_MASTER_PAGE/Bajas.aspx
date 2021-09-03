<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bajas.aspx.cs" Inherits="ASP_MASTER_PAGE.Bajas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <div id="container">
     <div class="filas"><H1>GESTIÓN DE CLIENTES</H1></div>
     <div class="filas"><h2>Bajas de clientes</h2></div>  
     <div class="filas">
     <div class="titulos">introduce el ID a eliminar:</div>
          <div class="controles">
              <asp:DropDownList ID="dlbajasa" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID" DataValueField="ID"></asp:DropDownList>
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
              <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
          </div>
    </div>
   <div class="filas">

       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
           <AlternatingRowStyle BackColor="White" />
           <Columns>
               <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
               <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
               <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
               <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
               <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
               <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
           </Columns>
           <EditRowStyle BackColor="#7C6F57" />
           <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#E3EAEB" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#F8FAFA" />
           <SortedAscendingHeaderStyle BackColor="#246B61" />
           <SortedDescendingCellStyle BackColor="#D4DFE1" />
           <SortedDescendingHeaderStyle BackColor="#15524A" />
       </asp:GridView>

   </div>
    </div>
</asp:Content>
