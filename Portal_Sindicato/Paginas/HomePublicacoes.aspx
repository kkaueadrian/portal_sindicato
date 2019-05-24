<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePublicacoes.aspx.cs" Inherits="Paginas_HomePublicacoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
   
            <asp:Label ID="lblTitulo" runat="server" Text="Lista de Publicações"></asp:Label>
   
        </div>
        <p>
            <asp:GridView ID="gvPublicacao" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPublicacao_RowDataBound" >
                <Columns>
                    <asp:BoundField HeaderText="Imagem" />
                    <asp:BoundField DataField="pub_endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="pub_descricao" HeaderText="Descrição" />
                    <asp:BoundField DataField="pub_tipo" HeaderText="Tipo" />
                </Columns>
            </asp:GridView>
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
