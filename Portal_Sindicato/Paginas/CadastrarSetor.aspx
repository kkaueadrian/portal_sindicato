<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarSetor.aspx.cs" Inherits="Paginas_CadastrarSetor" %>
<script src="../Scripts/bootstrap.min.js"></script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 148px" class ="container-fluid">
            <asp:Label ID="lblTitulo" runat="server" Text="Cadastro de setor"></asp:Label>
            <br />
            <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
            <br />
            <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
