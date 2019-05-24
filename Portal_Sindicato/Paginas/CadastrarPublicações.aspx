<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarPublicações.aspx.cs" Inherits="Paginas_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitulo" runat="server" Text="Cadastrar Publicações"></asp:Label>
    
        :<p>
         <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
            
            :</p>
        <p>
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEndereco" runat="server" Text="Endereco"></asp:Label>
            :</p>
        <p>
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
            :</p>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="CheckBox" runat="server" />
        </p>
        <p>
            <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
            :</p>
        <p>
            <asp:TextBox ID="textTipo" runat="server"></asp:TextBox>
        </p>
        <p>
         
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Publicar" />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
