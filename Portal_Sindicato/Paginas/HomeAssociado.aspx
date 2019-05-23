<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeAssociado.aspx.cs" Inherits="Paginas_HomeAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblPendencia" runat="server" Text="Consulte suas pêndencias "></asp:Label>
            <asp:HyperLink ID="hlPendencia" runat="server">Aqui</asp:HyperLink>
            <br />
        </div>
        <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
    </form>
</body>
</html>
