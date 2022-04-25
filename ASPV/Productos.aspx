<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ASPV.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="jumbotron">
                <asp:Panel runat="server" ID="pnlDatoaAlumno">
                    <asp:GridView ID="tablaProducto" runat="server" AutoGenerateColumns="true">                 
                    </asp:GridView>
                    <asp:Button ID="btnNuevo" Text="Nuevo Producto" runat="server" OnClick="BtnNuevo_Click"/>
                </asp:Panel>
                <asp:Panel ID="pnlAltaAlumno" runat="server" Visible="false">
                    <div>
                        <asp:Label ID="lblnombre" Text="Nombre" runat="server"></asp:Label>
                        <asp:TextBox ID="txtnombre" runat="server" />
                    </div>
                    <div>
                        <asp:Label ID="lblmarca" Text="Marca" runat="server"></asp:Label>
                        <asp:TextBox ID="txtmarca" runat="server" />
                    </div>
                    <div>
                        <asp:Label ID="lblcategoria" Text="Categoria" runat="server" />
                        <asp:TextBox ID="txtcategoria" runat="server" />
                    </div>
                    <div>
                        <asp:Label ID="lblcantidad" Text="cantidad" runat="server" />
                        <asp:TextBox ID="txtcantidad" runat="server" />
                    </div>
                    <br />
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar Alumno" OnClick="BtnGuardar_Click" />
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
