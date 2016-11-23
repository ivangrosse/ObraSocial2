<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaMedico.aspx.cs" Inherits="ObraSocialWeb_2.Views.ConsultaMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Listado de médicos</h1>
        <hr />
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                </Columns>
            </asp:GridView>
            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ObraSocialConnectionString %>" SelectCommand="SELECT MEDICO.nombre, ESPECIALIDAD.descripcion FROM ESPECIALIDAD INNER JOIN MEDICO ON ESPECIALIDAD.id_especialidad = MEDICO.id_especialidad"></asp:SqlDataSource>
            
        </div>
        <a href="Default.aspx">Volver al inicio.</a>
    
    </div>
        
    </form>
</body>
</html>
