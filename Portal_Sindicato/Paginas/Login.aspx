<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Paginas_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        label{
             color:white; 
             text-align:center;

        }
        #form1{
            border:1px solid black;
            float:left;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="col-md-4" ></div>
        <div class="col-md-4 ">
            <asp:Label ID="lblTitulo" runat="server" Text="Login"></asp:Label>
            
            <br />
            <br />
            <asp:Label ID="lblCpf" runat="server" Text="CPF:"></asp:Label>
            <br />
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
            <br />
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" class="btn-primary" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
