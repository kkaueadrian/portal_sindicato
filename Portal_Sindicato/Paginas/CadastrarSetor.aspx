<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarSetor.aspx.cs" Inherits="Paginas_CadastrarSetor" %>
<script src="../Scripts/bootstrap.min.js"></script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Cadastrar Setor</title>
</head>
<body>
    <br />
     <div class="form-style-8 " >
        <h2>Cadastrar Setor</h2>
    <form id="form1" runat="server">
        <div>
            
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
         </div>
</body>
</html>
