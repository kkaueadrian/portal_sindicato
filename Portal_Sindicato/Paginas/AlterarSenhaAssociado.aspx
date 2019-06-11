<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarSenhaAssociado.aspx.cs" Inherits="Paginas_AlterarSenhaAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Alterar Senha"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
            <br />
        
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="hlVoltar" NavigateUrl="~/Paginas/HomeAssociado.aspx" runat="server">Voltar</asp:HyperLink>
    </div>
            </form>
</body>
</html>
