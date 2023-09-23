<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="TercerParcial301.Vistas.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="BIENVENIDO"></asp:Label>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Alta personal </asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Registro venta</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Cancelaciones</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Alta producto</asp:LinkButton>
            <br />
            <br />
            <br />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/Vistas/login.aspx">Regresar</asp:LinkButton>
    </form>
</body>
</html>
