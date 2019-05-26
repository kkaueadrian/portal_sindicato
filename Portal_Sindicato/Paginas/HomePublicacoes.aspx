<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePublicacoes.aspx.cs" Inherits="Paginas_HomePublicacoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
   
            <asp:Label ID="lblTitulo" runat="server" Text="Lista de Publicações"></asp:Label>
   
        
        
            <asp:GridView ID="gvPublicacao" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPublicacao_RowDataBound" >
                <Columns>
                    <asp:BoundField HeaderText="Imagem" />
                    <asp:BoundField DataField="pub_endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="pub_descricao" HeaderText="Descrição" />
                    <asp:BoundField DataField="pub_tipo" HeaderText="Tipo" />
                </Columns>
            </asp:GridView>
       
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        
            </div>
        
           
        <div>

            <asp:Repeater ID="rptPublicacoes" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <ItemTemplate>
                    <div>
                         <p>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"../Upload/" + Eval("pub_imagem") %>' style='width:400px' />
                         </p>
                         <p>
                             <asp:Label ID="lblDescricao" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "pub_descricao")%>'></asp:Label>
                         </p>
                         </div>
                         </ItemTemplate>
            </asp:Repeater>

        
        
       
        <asp:Label ID="lblMensagem2" runat="server" Text="Label"></asp:Label>
        
       </div>
    </form>
</body>
</html>
