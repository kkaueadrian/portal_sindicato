<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarServico.aspx.cs" Inherits="Paginas_ListarServico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
    <script src="../Content/js/bootstrap.min.js"></script>
    <title>Listar Servico</title>
    <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlServico,#hlVoltar{
            
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
        <h2>Lista de Serviços</h2>
    <form id="form1" runat="server">
        <div>
            
            
            <asp:HyperLink ID="hlServico" NavigateUrl="~/Paginas/CadastrarServico.aspx" runat="server">Novo serviço</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="gvServico" runat="server" AutoGenerateColumns="False" OnRowCommand="gvServico_RowCommand1"  Width="1572px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" Height="16px">
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
             <br />
            <br />
            <asp:HyperLink ID="hlVoltar" runat="server" NavigateUrl="~/Paginas/HomeFuncionario.aspx">Voltar</asp:HyperLink>
        </div>
    </form>
        </div>
</body>
</html>
