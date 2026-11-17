<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="ExamTablas.capaPresentacion.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ExamenTecnico</title>
    <link rel="stylesheet" type="text/css" href="/css/estilos.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a class="active" href="inicio.aspx">Inicio</a></li>
                <li><a href="tecnicos.aspx">Tecnicos</a></li>
                <li><a href="asignaciones.aspx">Asignaciones</a></li>
                <li><a href="datos.aspx">Datos</a></li>
            </ul>
        </div>

        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://fernandojuca.com/wp-content/uploads/2018/05/SERVICIO-TECNICO.jpg" Height="944px" Width="1690px" />
        </div>
    </form>
</body>
</html>
