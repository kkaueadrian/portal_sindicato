<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarPendenciaAssociado.aspx.cs" Inherits="Paginas_ListarPendenciaAssociado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Suas pendências"></asp:Label>
            <asp:GridView ID="grvPendencias" runat="server" AutoGenerateColumns="False"  OnRowDataBound="grvPendencias_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="pen_tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="" HeaderText="Donwload" />
                     
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>
