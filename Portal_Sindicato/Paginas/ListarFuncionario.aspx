<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarFuncionario.aspx.cs" Inherits="Paginas_ListarFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <title>Lista de Funcionario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Funcionarios Cadastrados"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hlCadastrar" runat="server" NavigateUrl="~/Paginas/CadastrarFuncionario.aspx">Novo Funcionario</asp:HyperLink>
            <br />
        </div>
        <asp:GridView ID="gvFuncionario" runat="server" AutoGenerateColumns="False" OnRowCommand="gvFuncionario_RowCommand1" >
            <Columns>
                <asp:BoundField DataField="pes_codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="pes_permissao_administrador" HeaderText="Pemissão de Administrador" />
                <asp:BoundField DataField="pes_nome" HeaderText="Nome" />
                <asp:BoundField DataField="pes_cpf" HeaderText="CPF" />
                <asp:BoundField DataField="pes_nascimento" HeaderText="Nascimento" />
                <%--<asp:BoundField DataField="pes_dataadm" HeaderText="Data de Admissão " />--%>
                <asp:BoundField DataField="pes_endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="pes_email" HeaderText="Email" />
                <asp:BoundField DataField="pes_contato" HeaderText="Contato" />
                <asp:BoundField DataField="sin_razao_social" HeaderText="Sindicato" />
                <asp:BoundField DataField="set_tipo" HeaderText="Setor" />
                <asp:TemplateField>
                <ItemTemplate>
                <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar" CommandArgument='<%# Bind("pes_codigo")%>'>Alterar</asp:LinkButton>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                <ItemTemplate>
                <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Bind("pes_codigo")%>'>Excluir</asp:LinkButton>
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
