<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomeFuncionario.aspx.cs" Inherits="Paginas_HomeFuncionario" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/LinkButton.css" rel="stylesheet" />
    <title>Home Funcionario</title>
    
         <style>
        #top{
            margin-left: 130px;
            margin-right: 130px;
        }

        #link1,#link2,#link3,#link4,#link5,#link6,#link7{

            
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
            
            <div id="link1" class="col-md-2">
            <asp:HyperLink class="buttonformat" ID="hlFuncionario" NavigateUrl="~/Paginas/ListarFuncionario.aspx" runat="server">Lista de Funcionarios</asp:HyperLink>
                <asp:Label runat="server" Text=" "/>
            </div>
            
           <div id="link2"  class="col-md-2">
            <asp:HyperLink class="buttonformat" ID="hlAssociado" NavigateUrl="~/Paginas/ListarAssociados.aspx" runat="server">Lista de Associados</asp:HyperLink>
               <asp:Label runat="server" Text=" "/>
            </div>
           
           <div id="link3"  class="col-md-2">
            <asp:HyperLink class="buttonformat" ID="hlPendencia"  runat="server" NavigateUrl="~/Paginas/ListarPendenciaFuncionario.aspx">Lista de Pêndencias</asp:HyperLink>
               <asp:Label runat="server" Text=" "/>
           </div>
            
           <div id="link4"  class="col-md-2">
            <asp:HyperLink class="buttonformat" ID="hlServico" runat="server" NavigateUrl="~/Paginas/ListarServico.aspx">Lista de Serviços</asp:HyperLink>
               <asp:Label runat="server" Text=" "/>
            </div>
           
            <div id="link5" class="col-md-2">
            <asp:HyperLink class="buttonformat" ID="hlPublicacoes" runat="server" NavigateUrl="~/Paginas/ListarPublicacao.aspx">Lista de Publicações</asp:HyperLink>
                <asp:Label runat="server" Text=" "/>
             </div>
           <div id="link6" class="col-md-2">
            <asp:HyperLink class="buttonformat" ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/CadastrarSindicato.aspx">Cadastrar Sindicatos</asp:HyperLink>
                <asp:Label runat="server" Text=" "/>
             </div>
           <div id="link7" class="row" >
          <asp:LinkButton  ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
               </div>
            </div>
        </form>
   
         </div>
    <p>
        &nbsp;</p>
</body>
</html>
