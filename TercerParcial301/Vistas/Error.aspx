<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TercerParcial301.Vistas.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Pagina sin acceso."></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Acceso Denegado."></asp:Label>
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Vistas/login.aspx">Regresar</asp:LinkButton>
        </div>
    </form>
</body>
</html>
