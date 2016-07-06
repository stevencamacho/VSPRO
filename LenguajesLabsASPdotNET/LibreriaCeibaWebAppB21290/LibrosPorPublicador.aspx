<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibrosPorPublicador.aspx.cs" Inherits="LibreriaCeibaWebAppB21290.LibrosPorPublicador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
    <form id="form1" runat="server">
    <div>
 
        <asp:Label ID="labelPublicador" runat="server" Text="Publicador: "></asp:Label>
&nbsp;&nbsp;&nbsp;
 
        <asp:DropDownList ID="ddlPublicadores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPublicadores_SelectedIndexChanged">
        </asp:DropDownList>
        
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lbPublicadores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbPublicadores_SelectedIndexChanged"></asp:ListBox>
        <br />
        <br />
        <asp:GridView ID="gvLibros" runat="server" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged">
            <Columns>
                <asp:CommandField SelectText="Ver" ShowSelectButton="True" />
            </Columns>
        
        </asp:GridView>
        
    
    </div>
    </form>
    </div>
</body>
</html>
