<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarPesquisar.aspx.cs" Inherits="Paginas_ListarPesquisar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <script src="../Content/js/bootstrap.min.js"></script>
    <link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
    <title>Lista Associados</title>
    <style type="text/css">
        #form1 {
            height: 231px;
        }
         
        #top{
            margin-left: 150px;
            margin-right: 150px;
        }
        #hlCadastrar,#hlVoltar,#lbBuscar{
            
            background-color:cornflowerblue;
            text-decoration: none;
            color: snow;
            padding: 1em 1.5em;
            text-transform: uppercase;
        }
        body {
            background-image: url(http://localhost:54428/Content/HomePub/Imagem/photo-1486312338219-ce68d2c6f44d.jpg)
        }
   </style>
</head>
<body>
    <br />
    <div id="top" class="form-style-8 ">
        <h2>Lista de Associados</h2>
    <form id="form1" runat="server">
        <div>
            
       
        <asp:HyperLink ID="hlCadastrar" runat="server" NavigateUrl="~/Paginas/CadastrarAssociado.aspx">Cadastrar novo associado</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <br />


            <div style="float:left;">
            <asp:TextBox ID="txtTermo" runat="server" style="background-color:white; border-color:black; margin-top: 0px;"  Height="45px" Width="340px"></asp:TextBox>
                </div>

            <div style="float:left; margin-left:0px; padding-top:15px; height: 32px;">
            <asp:LinkButton ID="lbBuscar" runat="server"  OnClick="lbBuscar_Click">Buscar</asp:LinkButton>
                </div>


            <br />
        <asp:GridView ID="grvAssociados" runat="server" AutoGenerateColumns="False"  OnRowCommand="grvAssociados_RowCommand" Width="1580px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" Height="16px">
            <Columns>
                <asp:BoundField DataField="pes_codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="pes_nome" HeaderText="Nome" />
                <asp:BoundField DataField="pes_cpf" HeaderText="CPF" />
                <asp:BoundField DataField="pes_nascimento" HeaderText="Data de nascimento" />
                <asp:BoundField DataField="pes_dataadm" HeaderText="Data de admissão" />
                <asp:BoundField DataField="pes_endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="pes_email" HeaderText="Email" />
                <asp:BoundField DataField="pes_contato" HeaderText="Celular" />
                <asp:BoundField DataField="pes_cnpj" HeaderText="CNPJ" />
                <asp:BoundField DataField="pes_ie" HeaderText="IE" />
                <asp:BoundField DataField="pes_caepf" HeaderText="CAEPF" />
                <asp:BoundField DataField="sin_razao_social" HeaderText="Sindicato" />
                <asp:TemplateField>
                <ItemTemplate>
                <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar" CommandArgument='<%# Bind("pes_codigo")%>'>Alterar</asp:LinkButton>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                <ItemTemplate>
                <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Bind("pes_codigo")%>'>Excluir</asp:LinkButton>
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>
                </asp:GridView>

            <br />

        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hlVoltar" runat="server" NavigateUrl="~/Paginas/HomeFuncionario.aspx">Voltar</asp:HyperLink>
            
            </div>
        </form>
        </div>
    </body>
    </html>
