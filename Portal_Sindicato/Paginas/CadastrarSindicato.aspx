<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarSindicato.aspx.cs" Inherits="Paginas_CadastrarSindicato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Cadastrar Sindicato</title>
    
    <script type="text/javascript">
//auto expand textarea
function adjust_textarea(h) {
    h.style.height = "20px";
    h.style.height = (h.scrollHeight)+"px";
}
</script>
   
</head>
<body>
    <br />
    <div class="form-style-8 " >
        <h2>Cadastrar Sindicato</h2>
    <form id="form1" runat="server" dir="auto">
        

        <asp:Label ID="cnpj" runat="server" Text="CNPJ"></asp:Label>
        <br />
        <asp:TextBox ID="txtCnpj" runat="server" Width="279px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="razaoSocial" runat="server" Text="Razão Social"></asp:Label>
        <br />
        <asp:TextBox ID="txtRazaoSocial" runat="server" OnTextChanged="TextBox2_TextChanged" Width="237px"></asp:TextBox>
        <br />
        <asp:Label ID="endereco" runat="server" Text="Endereço"></asp:Label>
        <br />
        <asp:TextBox ID="txtEndereco" runat="server" Width="257px"></asp:TextBox>
        <br />
        <asp:Label ID="contato" runat="server" Text="Contato"></asp:Label>
        <br />
        <asp:TextBox ID="txtContato" runat="server" Width="263px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkAtivo" runat="server" Text="Ativo" />
        <br />
        <br />
        <asp:Button ID="salvar" runat="server" OnClick="Button1_Click" Text="Salvar" />
        <br />
        
        <asp:Label ID="lblMensagem" runat="server" Text="" ></asp:Label>
    </form>

        </div>
</body>
</html>