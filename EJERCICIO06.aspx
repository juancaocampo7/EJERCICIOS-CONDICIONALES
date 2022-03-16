<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJERCICIO06.aspx.cs" Inherits="EJERCICIOS_CONDICIONALES.EJERCICIO6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Digite su número 1:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnum1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Digite su número 2:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnum2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Respuesta al Usuario:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblrspta" runat="server"></asp:Label>
                    <asp:Label ID="lblrspta2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btncalcular" runat="server" OnClick="btncalcular_Click" Text="Calcular" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
