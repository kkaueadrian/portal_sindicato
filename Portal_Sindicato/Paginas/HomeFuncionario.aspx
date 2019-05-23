<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeFuncionario.aspx.cs" Inherits="Paginas_HomeFuncionario" %>

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
            <asp:HyperLink ID="hlFuncionario" NavigateUrl="~/Paginas/ListarFuncionario.aspx" runat="server">Lista de Funcionarios</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlAssociado" NavigateUrl="~/Paginas/ListarAssociados.aspx" runat="server">Lista de Associados</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlPendencia"  runat="server">Lista de Pêndencias</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlServico" runat="server">Lista de Serviços</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlPublicacoes" runat="server">Lista de Publicações</asp:HyperLink>
            <br />
            <br />
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
        </div>
    </form>
</body>
</html>
