<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarPublicacao.aspx.cs" Inherits="Paginas_ListarPublicacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Listar Publicacao</title>
    <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlPublicacao,#hlVoltar{
            
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
<body style="height: 289px">
    <br />
    <div id="top" class="form-style-8 ">
        <h2>Lista de Publicações</h2>
    <form id="form1" runat="server">
        <div>
            
        
       
        
        <asp:HyperLink ID="hlPublicacao" NavigateUrl="~/Paginas/CadastrarPublicacao.aspx" runat="server">Nova Publicação</asp:HyperLink>
            <br />
        <br />
        <asp:GridView ID="gvPublicacao" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPublicacao_RowDataBound" Width="600px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
            <Columns>
                <asp:BoundField HeaderText="Imagem" />
                <asp:BoundField DataField="pub_endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="pub_descricao" HeaderText="Descrição" />
                <asp:TemplateField HeaderText="Status" SortExpression="Status">
                    <ItemTemplate><%# (Boolean.Parse(Eval("pen_status").ToString())) ? "Ativa" : "Desativada" %></ItemTemplate>
                    </asp:TemplateField>
                <asp:BoundField DataField="pub_tipo" HeaderText="Tipo" />
                <asp:BoundField DataField="sin_razao_social" HeaderText="Sindicato" />
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
