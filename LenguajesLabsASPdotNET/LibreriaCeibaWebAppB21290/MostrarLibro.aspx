<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarLibro.aspx.cs" Inherits="LibreriaCeibaWebAppB21290.MostrarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
    <div>
    
        Titulo :&nbsp;&nbsp;
        <asp:Label ID="lbTitulo" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Codigo :&nbsp;
        <asp:Label ID="lbCodigo" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Año de Publicación&nbsp;
        <asp:Label ID="lbAnio" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        ISBN :&nbsp;
        <asp:Label ID="lbIsbn" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Publicador :&nbsp;
        <asp:Label ID="lbPublicador" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Precio :&nbsp;
        <asp:Label ID="lbPrecio" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:GridView ID="gvAutores" runat="server">
        </asp:GridView>
    
    </div>
    </form>
    </center>
</body>
</html>
