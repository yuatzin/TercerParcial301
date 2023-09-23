<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TercerParcial301.Vistas.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Tipo"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="SHA1" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Algoritmo"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Width="345px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Insertar Datos" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Vistas/login.aspx">Regresar</asp:LinkButton>
        </div>
    </form>
</body>
</html>
