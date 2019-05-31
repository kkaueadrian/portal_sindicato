<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarSindicato.aspx.cs" Inherits="Paginas_ListarSindicato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Listar Sindicato</title>
    <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlCadastroSin{
            
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
<body style="height: 178px">
    <br />
    <div id="top" class="form-style-8 ">
        <h2>Lista de Sindicatos</h2>

    <form id="form1" runat="server">
       
        <asp:HyperLink ID="hlCadastroSin" runat="server" NavigateUrl="~/Paginas/CadastrarSindicato.aspx">Cadastrar novo sindicato</asp:HyperLink>
         <br />
        <br />
        
        <asp:GridView ID="gvSindicato" runat="server" AutoGenerateColumns="False" OnRowCommand="gvSindicato_RowCommand1" Width="600px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" >
            

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
        </div>
</body>
</html>
