<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeAssociado.aspx.cs" Inherits="Paginas_HomeAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/LinkButton.css" rel="stylesheet" />
    <title>Home Associado</title>
       <style>
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
         #link1,#link2,#link3{

            
            margin-top:50px;
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
     <br />
     <div id="top" class="form-style-8 " >
        <h2><asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label></h2>
        
    <form id="form1" runat="server">
        <div>
            
        
            <div id="link1">
            <asp:HyperLink class="buttonformat" ID="hlPendencia" NavigateUrl="~/Paginas/ListarPendenciaAssociado.aspx" runat="server">Consultar Pendências</asp:HyperLink>
                <br />
                <br />
                <br />
               <br />
                <asp:HyperLink class="buttonformat" ID="hlAlterarSenha" NavigateUrl="~/Paginas/AlterarSenhaAssociado.aspx" runat="server">Alterar Senha</asp:HyperLink>
               
                </div>
             <div id="link2">
            <asp:HyperLink class="buttonformat" ID="HyperLink1" NavigateUrl="~/Paginas/ListarServico.aspx" runat="server">Consultar Serviços</asp:HyperLink>
                </div>
            <div id="link3">
             <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
                </div>
        </div>
       
    </form>
         </div>
</body>
</html>
