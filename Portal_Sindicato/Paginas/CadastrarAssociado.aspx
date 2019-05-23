<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarAssociado.aspx.cs" Inherits="Paginas_CadastrarAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitulo" runat="server" Text="Cadastar Associado"></asp:Label>
        <br />
        <br />
        <asp:Label ID="nome" runat="server" Text="Nome:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="senha" runat="server" Text="Senha:"></asp:Label>
        <br />
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="cpf" runat="server" Text="CPF:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="nascimento" runat="server" Text="Nascimento:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNascimento" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="dataadm" runat="server" Text="Data de Admissão"></asp:Label>
        <br />
        <asp:TextBox ID="txtDataadm" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="endereco" runat="server" Text="Endereço:"></asp:Label>
        <br />
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="email" runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="contato" runat="server" Text="Celular:"></asp:Label>
        <br />
        <asp:TextBox ID="txtContato" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="cnpj" runat="server" Text="CNPJ:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCnpj" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="ie" runat="server" Text="Inscrição Estadual:"></asp:Label>
        <br />
        <asp:TextBox ID="txtIe" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="caepf" runat="server" Text="CAEPF:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCaepf" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSindicato" runat="server" Text="Sindicato"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlSindicato" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>

        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/ListarAssociados.aspx">Lista</asp:HyperLink>

    </form>
</body>
</html>
