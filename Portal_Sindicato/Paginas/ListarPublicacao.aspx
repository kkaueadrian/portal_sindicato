<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarPublicacao.aspx.cs" Inherits="Paginas_ListarPublicacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <title>Listar Publicacao</title>
</head>
<body style="height: 289px">
    <form id="form1" runat="server">
        <div>
            
        
        <asp:Label ID="lblTitulo" runat="server" Text="Lista de Publicações"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="hlPublicacao" NavigateUrl="~/Paginas/CadastrarPublicacao.aspx" runat="server">Nova Publicação</asp:HyperLink>
            <br />
        <br />
        <asp:GridView ID="gvPublicacao" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPublicacao_RowDataBound">
            <Columns>
                <asp:BoundField HeaderText="Imagem" />
                <asp:BoundField DataField="pub_endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="pub_descricao" HeaderText="Descrição" />
                <asp:BoundField DataField="pub_status" HeaderText="Status" />
                <asp:BoundField DataField="pub_tipo" HeaderText="Tipo" />
                <asp:BoundField DataField="sin_razao_social" HeaderText="Sindicato" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>
    </form>
</body>
</html>
