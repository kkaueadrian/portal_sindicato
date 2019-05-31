<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarServico.aspx.cs" Inherits="Paginas_ListarServico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <title>Listar Servico</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Serviços oferecidos"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hlServico" NavigateUrl="~/Paginas/CadastrarServico.aspx" runat="server">Novo serviço</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="gvServico" runat="server" AutoGenerateColumns="False" OnRowCommand="gvServico_RowCommand1" >
                <Columns>
                    <asp:BoundField DataField="ser_codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="ser_descricao" HeaderText="Descrição" />
                    <asp:BoundField DataField="ser_status" HeaderText="Ativo" />
                    <asp:BoundField DataField="ser_tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="set_tipo" HeaderText="Setor" />
                    
                    <asp:TemplateField>
                    <ItemTemplate>
                    <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Bind("ser_codigo")%>'>Excluir</asp:LinkButton>
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
           </asp:GridView>
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
