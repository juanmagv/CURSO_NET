<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioValidacion_ASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="css/StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
              <div class="filas">
                   <div class="titulos">
                    <asp:Label ID="Label1" runat="server" Text="Nombre de usuario:" Width="250px"></asp:Label>
                   </div>
                   <div class="controles">
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Falta el campo Nombre" ForeColor="#CC0000">*Introduce el campo</asp:RequiredFieldValidator>
                   </div>
               </div>
             <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                </div>
                  <div class="controles">
                     <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                   </div>
              </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label3" runat="server" Text="Repita la clave:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="La contraseña no coincide" ForeColor="#CC0000">*La contraseña no coincide</asp:CompareValidator>
                </div>
             </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label4" runat="server" Text="Correo electrónico:"></asp:Label>
                </div>
                <div class="controles">
           <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="*El correo no es valido" ForeColor="#CC0000" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
            </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label>
                </div>
                <div class="controles">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Falta campo apellido" ForeColor="#CC0000">Introduce el campo</asp:RequiredFieldValidator>
                </div>
                </div>
            
            <div class="filas">
            <div class="titulos">
                    <asp:Label ID="Label6" runat="server" Text="Nombre de usuario:" Width="250px"></asp:Label>
                </div>
                <div class="controles">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox6" ErrorMessage="Falta el campo nombre" ForeColor="#CC0000">*Introduce el campo</asp:RequiredFieldValidator>
           </div>

          </div>
             <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label7" runat="server" Text="Pais de Origen:"></asp:Label>
                </div>
                <div class="controles"><asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Francia</asp:ListItem>
                <asp:ListItem>Portugal</asp:ListItem>
                <asp:ListItem>Italia</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="NO se ha seleccionado Pais" ForeColor="#CC0000">*Seleccion valor</asp:RequiredFieldValidator>
           </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label8" runat="server" Text="Provincia:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Falata la provincia" ForeColor="#CC0000" ControlToValidate="TextBox7">*Introduce el campo</asp:RequiredFieldValidator>
           </div>
           </div>
             </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label9" runat="server" Text="Código Postal:"></asp:Label>
                </div>
                <div class="controles">
           <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="*El valor introducido  no es valido" MaximumValue="55555" MinimumValue="11111" ControlToValidate="TextBox8" ForeColor="#CC0000">*El codigo postal no es valido</asp:RangeValidator>
            </div>
            </div>
             <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label10" runat="server" Text="Género: "></asp:Label>
                </div>
                  <div class="controles">
            <asp:RadioButton ID="rb1" runat="server" Text="Hombre" GroupName="1" checked="true" />
            <asp:RadioButton ID="rb2" runat="server" Text="Mujer" GroupName="1"  />
            </div>
           </div>
         <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label11" runat="server" Text="Fecha de nacimiento:"></asp:Label>
                </div>
             <div class="controles">
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </div>
             </div>
        <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label12" runat="server" Text="Comentarios:"></asp:Label>
                </div>
                <div class="controles">
         <asp:TextBox ID="TextBox9" runat="server" Height="105px" Width="198px"></asp:TextBox>
          </div>
           </div>
           <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label13" runat="server" Text="&nbsp"></asp:Label>
                </div>
                <div class="controles">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" />
            <asp:Label runat="server" ID="lbChTerminos" ForeColor="#CC0000" Visible="False" Text="&nbsp&nbsp Acepto los términos y condiciones"></asp:Label>
             </div>
       
            <div class="titulos">
                    <asp:Label ID="Label14" runat="server" Text="&nbsp"></asp:Label>
                </div>
        <div class="controles">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Aceptar" />
             </div>
        </div>
 
    </form>
</body>
</html>
