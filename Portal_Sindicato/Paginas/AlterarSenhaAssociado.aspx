<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarSenhaAssociado.aspx.cs" Inherits="Paginas_AlterarSenhaAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <title>Alterar Senha</title>
    <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
         #hlLista{
            
            background-color:cornflowerblue;
            text-decoration: none;
            color: snow;
            padding: 1em 1.5em;
            text-transform: uppercase;
        }
          #lbSair{
            
            background-color:dimgray;
            text-decoration: none;
            color: snow;
            padding: 1em 1.5em;
            text-transform: uppercase;
        }

    </style>
</head>
<body>
     <div id="top" class="form-style-8 ">
        <h2>Alterar Senha</h2>
         
    <form id="form1" runat="server">
        
           
            <br />
            <br />
            <asp:Label ID="lblSenha" runat="server" Text=" Nova Senha"></asp:Label>
            <br />
        
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="lbSair" NavigateUrl="~/Paginas/HomeAssociado.aspx" runat="server">Voltar</asp:HyperLink>
        </form>
    </div>
            
    
    
</body>
</html>
