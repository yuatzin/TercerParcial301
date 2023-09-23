<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAlumno.aspx.cs" Inherits="TercerParcial301.Vistas.RegistroAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="BIENVENIDO."></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Vistas/login.aspx">Regresar</asp:LinkButton>
        </div>
    </form>
</body>
</html>
