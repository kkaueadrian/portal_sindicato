<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarPendenciaFuncionario.aspx.cs" Inherits="Paginas_ListarPendenciaFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <title>Listar Pendencia Funcionario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Lista de Pendências"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hlCadastro" NavigateUrl="~/Paginas/CadastrarPendencia.aspx" runat="server">Nova Pendência</asp:HyperLink>
            <br />
            <br />
            <asp:GridView ID="gvPendencias" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPendencias_RowDataBound">
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
</body>
</html>
