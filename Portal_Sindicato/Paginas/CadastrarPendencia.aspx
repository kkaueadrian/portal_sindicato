<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarPendencia.aspx.cs" Inherits="Paginas_CadastrarPendencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Cadastro de Pendências "></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblSelecionar" runat="server" Text="Selecionar Associado"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlAssociado" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        </div>
        <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
        <br />
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDocumento" runat="server" Text="Documento"></asp:Label>
        <br />
        <asp:FileUpload ID="fuDocumento" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
