<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarPendenciaFuncionario.aspx.cs" Inherits="Paginas_ListarPendenciaFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
    <title>Listar Pendencia Funcionario</title>
    <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlCadastro{
            
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
        <h2>Lista de Pedências</h2>
    <form id="form1" runat="server">
        <div>
            
            <asp:HyperLink ID="hlCadastro" NavigateUrl="~/Paginas/CadastrarPendencia.aspx" runat="server">Nova Pendência</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="gvPendencias" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPendencias_RowDataBound" Width="600px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                <Columns>
                    <asp:BoundField DataField="pen_tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="pes_nome" HeaderText="Associado" />
                    <asp:BoundField HeaderText="Documento" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </form>
        </div>
</body>
</html>
