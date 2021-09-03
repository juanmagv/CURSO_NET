<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CuestionarioASP_NET.Default" %>

<!DOCTYPE html>
<link rel="stylesheet" href="css/Estilos.css"/>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <H1 name="titulo">Examen CSS</H1> 
            <h2>¿Que nos permite css?</h2>

            <asp:RadioButton ID="RadioButton1" runat="server" Text="a.
                    Separa presentación de contenido..." GroupName="1"/><br />
             <asp:RadioButton ID="RadioButton2" runat="server" Text="b.
                    Optimiza la organización del html separando código y sea mas fácil revisar el diseño..." GroupName="1"/><br />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Mayor flexibilidad, escalabilidad..." GroupName="1"/><br />
            <asp:RadioButton ID="RadioButton4" runat="server" Text="d.
                    Todas son correctas." GroupName="1"/><br />
              
            <h2>Una regla CSS se compone de tres partes:</h2>
             <asp:RadioButton ID="RadioButton5" runat="server" Text="a.
                        El selector | La propiedad | Etiqueta" GroupName="2"/><br />
             <asp:RadioButton ID="RadioButton6" runat="server" Text="b.
                        El selector | etiqueta html | El valor" GroupName="2"/><br />
             <asp:RadioButton ID="RadioButton7" runat="server" Text="c.
                        Etiqueta html |  El valor | La propiedad" GroupName="2"/><br />
             <asp:RadioButton ID="RadioButton8" runat="server" Text="d.
                        El selector | La propiedad | El valor" GroupName="2"/><br />
            
                     <h2>¿Cómo se inserta un comentario en CSS?</h2>
            <asp:RadioButton ID="RadioButton9" runat="server" Text="a.
                                # esto es un comentario" GroupName="3"/><br />
             <asp:RadioButton ID="RadioButton10" runat="server" Text="b.
                                // esto es un comentario" GroupName="3"/><br />
             <asp:RadioButton ID="RadioButton11" runat="server" Text="c.
                                ' esto es un comentario" GroupName="3"/><br />
             <asp:RadioButton ID="RadioButton12" runat="server" Text="d.
                               /* esto es un comentario */" GroupName="3"/><br />
                   <h2>Hay 3 tipos de selectores CSS:</h2>
              <asp:RadioButton ID="RadioButton13" runat="server" Text="a.
                    Selector HTML: es la etiqueta HTML sin los símbolos <>" GroupName="4"/><br />
            <asp:RadioButton ID="RadioButton14" runat="server" Text="b.
                    Selector de CLASE: es una configuración creada por  nosotros mismo y podemos ponerle cualquier nombre. " GroupName="4"/><br />
              <asp:RadioButton ID="RadioButton15" runat="server" Text="c.
                    Selector de ID: es como el selector de clase, pero se usa  para identificar un elemento en particular.." GroupName="4"/><br />
            <asp:RadioButton ID="RadioButton16" runat="server" Text="d.
                    Todas son correctas..." GroupName="4"/>
             Selector de ID: es como el selector de clase, pero se usa  para identificar un elemento en particular.." GroupName="4"/><br />
            <asp:RadioButton ID="RadioButton17" runat="server" Text="" GroupName="4"/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Te falta la cancion" ControlToValidate="TextBox1" ForeColor="#CC0000">*Tienes que introducir cancion</asp:RequiredFieldValidator>
            <br />
            <br />
            Introduce el rango adecuado entre 10 y 20
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" EnableTheming="False" ErrorMessage="Error de rango" ForeColor="#CC0000" MaximumValue="20" MinimumValue="10" Type="Integer">* El valor no esta en el rango permitido</asp:RangeValidator>
            <br />
            contraseña<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            comprobar contraseña<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>comprobar correr<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Error del formato del campo" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$">Error de mail</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ver respuestas" OnClick="Button1_Click" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Las contraseñas no coinciden" ForeColor="#CC0000">Las contraseñas no coinciden</asp:CompareValidator>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
             <asp:Image  src="/IMG/homer2.jpg" runat="server" visible="false" id="homer2" Width="268px"/>
            <asp:Image  src="/IMG/fallaste.png" runat="server" visible="false" id="homer"/>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
