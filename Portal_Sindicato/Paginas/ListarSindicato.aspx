<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarSindicato.aspx.cs" Inherits="Paginas_ListarSindicato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <title>Listar Sindicato</title>
</head>
<body style="height: 178px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Lista de Sindicatos"></asp:Label>
        </div>
        <asp:HyperLink ID="hlCadastroSin" runat="server" NavigateUrl="~/Paginas/CadastrarSindicato.aspx">Cadastrar novo sindicato</asp:HyperLink>
        <asp:GridView ID="gvSindicato" runat="server" AutoGenerateColumns="False" OnRowCommand="gvSindicato_RowCommand1">
            <Columns>
                <asp:BoundField DataField="sin_codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="sin_cnpj" HeaderText="Cnpj" />
                <asp:BoundField DataField="sin_razao_social" HeaderText="Razão Social" />
                <asp:BoundField DataField="sin_endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="sin_contato" HeaderText="Contato" />
                <asp:BoundField DataField="sin_ativo" HeaderText="Ativo" />
                <asp:TemplateField>
                <ItemTemplate> <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar" CommandArgument='<%# Bind("sin_codigo")%>'>Alterar</asp:LinkButton> </ItemTemplate> </asp:TemplateField>
                <asp:TemplateField> <ItemTemplate> <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Bind("sin_codigo")%>'>Excluir</asp:LinkButton> </ItemTemplate> </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
