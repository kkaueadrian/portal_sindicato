<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarPublicacao.aspx.cs" Inherits="Paginas_CadastrarPublicacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Cadastrar Publicacoes</title>
</head>
<body>
    <br />
     <div class="form-style-8 ">
        <h2>Cadastrar Publições</h2>
    <form id="form1" runat="server">
        
           
            <br />
            <br />
            <asp:Label ID="lblEndereco" runat="server" Text="Endereço"></asp:Label>
            <br />
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
            <br />
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblStatus" runat="server" Text="Ativo"></asp:Label>
            <br />
            <asp:CheckBox ID="ckdStatus" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlTipo" runat="server" >
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblImagem" runat="server" Text="Imagem"></asp:Label>
            <br />
            <br />
            <asp:FileUpload ID="fuImagem" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblSindicato" runat="server" Text="Sindicato"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSindicato" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="lblSalvar" runat="server" Text="Salvar" OnClick="lblSalvar_Click" style="height: 40px" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        
    </form>
        </div>
</body>
</html>
