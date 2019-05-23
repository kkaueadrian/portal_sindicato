<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarServico.aspx.cs" Inherits="Paginas_CadastrarServico" %>

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
        <asp:Label ID="lblTitulo" runat="server" Text="Cadastrar Serviços"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição:"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStatus" runat="server" Text="Status do Serviço:"></asp:Label>
        <br />
        <asp:CheckBox ID="ckdStatus" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblTipo" runat="server" Text="Tipo de Serviço:"></asp:Label>
        <br />
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSetor" runat="server" Text="Setor:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlSetor" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblSindicato" runat="server" Text="Sindicato:"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlSindicato" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
