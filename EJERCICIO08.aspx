<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJERCICIO08.aspx.cs" Inherits="EJERCICIOS_CONDICIONALES.EJERCICIO8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 28px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nombre del Articulo:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnomart" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtclave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Precio Original:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpreorig" runat="server"></asp:TextBox>
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
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Nombre del Articulo:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblnomart" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Clave:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblclave" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Precio Original:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblpreorig" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Precio con Descuento:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblpredesc" runat="server"></asp:Label>
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
