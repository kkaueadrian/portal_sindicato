<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarAssociados.aspx.cs" Inherits="Paginas_ListarAssociados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 231px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Lista de Associados"></asp:Label>
        
            <br />
        
        <asp:HyperLink ID="hlCadastroSin" runat="server" NavigateUrl="~/Paginas/CadastrarAssociado.aspx">Cadastrar novo associado</asp:HyperLink>
            <br />
        <asp:GridView ID="grvAssociados" runat="server" AutoGenerateColumns="False"  OnRowCommand="grvAssociados_RowCommand">
            <Columns>
                <asp:BoundField DataField="pes_codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="pes_nome" HeaderText="Nome" />
                <asp:BoundField DataField="pes_cpf" HeaderText="CPF" />
                <asp:BoundField DataField="pes_nascimento" HeaderText="Data de nascimento" />
                <asp:BoundField DataField="pes_dataadm" HeaderText="Data de admissão" />
                <asp:BoundField DataField="pes_endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="pes_email" HeaderText="Email" />
                <asp:BoundField DataField="pes_contato" HeaderText="Celular" />
                <asp:BoundField DataField="pes_cnpj" HeaderText="CNPJ" />
                <asp:BoundField DataField="pes_ie" HeaderText="IE" />
                <asp:BoundField DataField="pes_caepf" HeaderText="CAEPF" />
                <asp:BoundField DataField="sin_razao_social" HeaderText="Sindicato" />
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
            </div>
        </form>
    </body>

        