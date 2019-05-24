<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarPublicacao.aspx.cs" Inherits="Paginas_CadastrarPublicacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Cadastrar Publições"></asp:Label>
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
            <asp:FileUpload ID="fuImagem" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblSindicato" runat="server" Text="Sindicato"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSindicato" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="lblSalvar" runat="server" Text="Salvar" OnClick="lblSalvar_Click" style="height: 26px" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
