<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datos.aspx.cs" Inherits="ExamTablas.capaPresentacion.datos" %>

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
                <li><a href="tecnicos.aspx">Tecnicos</a></li>
                <li><a href="asignaciones.aspx">Asignaciones</a></li>
                <li><a class="active" href="datos.aspx">Datos</a></li>
            </ul>
        </div>

        <div>
            <h1 class="titulo">Datos de Técnicos</h1>
            <h1>Datos de Asignaciones</h1>
        </div>
        <div>
        </div>

        <div>
            <asp:GridView ID="GridView2" runat="server" Height="120" Width="600px" CssClass="tabla-tecnicos"> </asp:GridView>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="120px" Width="450px" CssClass="tabla-datos1"></asp:GridView>
        </div>

    </form>
</body>
</html>
