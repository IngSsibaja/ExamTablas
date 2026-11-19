<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tecnicos.aspx.cs" Inherits="ExamTablas.capaPresentacion.tecnicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ExamenTecnico</title>
    <link rel="stylesheet" type="text/css" href="/css/estilos.css?v2"/>
</head>
<body class="portada">
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a href="inicio.aspx">Inicio</a></li>
                <li><a class="active" href="tecnicos.aspx">Tecnicos</a></li>
                <li><a href="asignaciones.aspx">Asignaciones</a></li>
                <li><a href="datos.aspx">Datos</a></li>
            </ul>
        </div>

        <div>
            <h1 class="h1">¡Bienvenido al Gestor de Técnicos!</h1>
        </div>

        <div>
            <asp:GridView ID="GridView1" runat="server" Height="120" Width="437px" CssClass="tabla-tecnicos"></asp:GridView>
        </div>

        <div>
            <asp:Label ID="lblid_tecnico" runat="server" Text="ID_Tecnico" Height="47px" Width="85"></asp:Label>
            <asp:TextBox ID="txtid_tecnico" runat="server" Height="47px" Width="215px" BorderColor="#24272B" BorderStyle="Outset" BorderWidth="5px"></asp:TextBox>
            <br />
            <asp:Label ID="lblnombre" runat="server" Text="Nombre" Height="47px" Width="85"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" Height="47px" Width="215px" BorderColor="#24272B" BorderStyle="Outset" BorderWidth="5px"></asp:TextBox>
            <br />
            <asp:Label ID="lblespecialidad" runat="server" Text="Especialidad" Height="47px" Width="85"></asp:Label>
            <asp:TextBox ID="txtespecialidad" runat="server" Height="47px" Width="215px" BorderColor="#24272B" BorderStyle="Outset" BorderWidth="5px" ></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Cliente" Height="54px" Width="222px" OnClick="btnAgregar_Click" />
            <asp:Button ID="btnborar" runat="server" Text="Borrar Cliente" Height="54px" Width="222px" OnClick="btnBorrar_Click" />
            <asp:Button ID="btnEditar" runat="server" Text="Editar Cliente" Height="54px" Width="222px" OnClick="btnEditar_Click" />
        </div>
    </form>
</body>
</html>
