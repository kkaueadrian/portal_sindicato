<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarFuncionario.aspx.cs" Inherits="Paginas_AlterarFuncionario" %>

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
        <asp:Label ID="lblTitulo" runat="server" Text="Cadastar Funcionario"></asp:Label>
        <br />
         <br />
        <asp:Label ID="permissaoAdministrador" runat="server" Text="Permissão Administrador:"></asp:Label>

        <br />
        <asp:CheckBox ID="ckdPermissaoAdministrador" runat="server" />
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
        <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="contato" runat="server" Text="Celular:"></asp:Label>
        <br />
        <asp:TextBox ID="txtContato" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="txtSindicato" runat="server" Text="Selecionar Sindicato:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlSindicato" runat="server">
        </asp:DropDownList>
         <br />
        <br />
        <asp:Label ID="txtSetor" runat="server" Text="Selecionar Setor:"></asp:Label>
        <br />
         <asp:DropDownList ID="ddlSetor" runat="server" >
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/ListarFuncionario.aspx">Lista</asp:HyperLink>
        <br />
    </form>
</body>
</html>
