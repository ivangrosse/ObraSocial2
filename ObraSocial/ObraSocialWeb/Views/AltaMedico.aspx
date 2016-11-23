<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaMedico.aspx.cs" Inherits="ObraSocialWeb.Vista.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Suscripcion de medico</title>
</head>
<body>
    <h1>Suscripción de Médico.</h1>
    <form id="form1" runat="server">
    <div>
        <label>Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged"></asp:TextBox></br></br>
        <label>Apellido:</label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></br></br>
        <label>DNI:</label>
        <asp:TextBox ID="txtDni" runat="server"></asp:TextBox></br></br>
        <label>Matrícula Profesional:</label>
        <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox></br></br>
        <label>Número de cuenta:</label>
        <asp:TextBox ID="txtCuenta" runat="server"></asp:TextBox></br></br>
        <label>Especialidad:</label>
        <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox></br></br>
    </div>
    <div>

    </div>
        <p>

        <asp:Button ID="btnAltaMedico" runat="server" Text="Suscribir Médico" OnClick="btnAltaMedico_Click" />

        </p>
    </form>
    <a href="Index.aspx">Volver al inicio.</a>
</body>
</html>
