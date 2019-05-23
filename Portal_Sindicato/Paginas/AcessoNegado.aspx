<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcessoNegado.aspx.cs" Inherits="Paginas_AcessoNegado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Você não tem permissão para acessar esta página! "></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" navigateUrl="~/Paginas/Login.aspx" runat="server">Retornar ao home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
