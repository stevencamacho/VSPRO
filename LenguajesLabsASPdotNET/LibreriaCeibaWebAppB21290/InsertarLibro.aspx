<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarLibro.aspx.cs" Inherits="LibreriaCeibaWebAppB21290.InsertarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Insertar un nuevo libro</title>
    <style type="text/css">
        #TextArea1 {
            height: 98px;
        }
    </style>
</head>
<body>
    
    <center>
    <h1>Insertar un nuevo libro</h1>
    <form id="form1" runat="server">
        <div id="lbPublicadores">
            Título:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            Año:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            ISBN:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            Publicador:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
            Precio:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <h4>Seleccione 1 o más autores:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h4>
            <div>
            <asp:ListBox ID="lbAutoresDisponibles" runat="server" AutoPostBack="True" Height="69px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="bnQuitar" runat="server" Text="<<" OnClick="bnQuitar_Click"/>            
            &nbsp;&nbsp;&nbsp;            
            <asp:Button ID="bnAgregar" runat="server" Text=">>" OnClick="bnAgregar_Click"/>            
            &nbsp;&nbsp;&nbsp;            
            <asp:ListBox ID="lbAutoresSeleccionados" runat="server" AutoPostBack="True"></asp:ListBox>
            </div>
            <br />
            <asp:Button ID="bnInsertar" runat="server" Text="Insertar Libro" OnClick="bnInsertar_Click"/>
    </div>
    </form>
    </center>
        
    
</body>
</html>
