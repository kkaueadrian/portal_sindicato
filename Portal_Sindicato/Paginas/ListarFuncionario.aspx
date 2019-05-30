<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarFuncionario.aspx.cs" Inherits="Paginas_ListarFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
    <title>Lista de Funcionario</title>
      <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlCadastrar,#hlVoltar{
            
            background-color:cornflowerblue;
            text-decoration: none;
            color: snow;
            padding: 1em 1.5em;
            text-transform: uppercase;
        }
        body {
            background-image: url(http://localhost:54428/Content/HomePub/Imagem/photo-1486312338219-ce68d2c6f44d.jpg)
        }
    </style>
</head>
<body>
    <br />
    <div id="top" class="form-style-8 ">
        <h2>Lista de Funcionários</h2>
    <form id="form1" runat="server">
        <div>
            
            
            <asp:HyperLink ID="hlCadastrar" runat="server" NavigateUrl="~/Paginas/CadastrarFuncionario.aspx">Novo Funcionário</asp:HyperLink>
            <br />
            <br />
        </div>
        <asp:GridView ID="gvFuncionario" runat="server" AutoGenerateColumns="False" OnRowCommand="gvFuncionario_RowCommand1" Width="600px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" >
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
         <br />
            <br />
            <asp:HyperLink ID="hlVoltar" runat="server" NavigateUrl="~/Paginas/HomeFuncionario.aspx">Voltar</asp:HyperLink>
    </form>
        </div>
</body>
</html>
