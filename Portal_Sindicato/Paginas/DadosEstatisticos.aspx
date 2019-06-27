<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DadosEstatisticos.aspx.cs" Inherits="Paginas_DadosEstatisticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="../Content/Cadastro%20CSS/Cadastro.css" rel="stylesheet" />
<script src="../Scripts/bootstrap.bundle.min.js"></script>
<link href="../Content/Site.css" rel="stylesheet" />
<script src="../Content/js/bootstrap.min.js"></script>


    <title>Dados Estatisticos</title>
  
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
        h3{

            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
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
     <div id="top" class="form-style-8 ">
         <h2>Dados Estatisticos</h2>
    <form id="form1" runat="server">
        

        <h3>Logins Diarios</h3>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="Logon" Width="927px" BackColor="LightGray" BackHatchStyle="BackwardDiagonal" BackImageTransparentColor="White" BorderlineColor="Silver" CssClass="form-style-8"   >
            <Series>
                <asp:Series Name="Series1" XValueMember="day(log_hora)" YValueMembers="count(distinct log_codigo)" YValuesPerPoint="2" ChartType="Line">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
            <BorderSkin BackSecondaryColor="Transparent" />
        </asp:Chart>
        <asp:ObjectDataSource ID="Logon" runat="server" OnSelecting="Logon_Selecting" SelectMethod="SelectCountLogin" TypeName="persistencia.LogonBD"></asp:ObjectDataSource>
        <br />
        <br />
       
     <h3>Número de Associados Admitidos</h3>
        <asp:Chart ID="Chart2" runat="server" DataSourceID="ADM" Width="932px" BackColor="LightGray" BackHatchStyle="BackwardDiagonal">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="pes_dataadm" YValueMembers="count(distinct pes_codigo)">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:ObjectDataSource ID="ADM" runat="server" SelectMethod="CountAdm" TypeName="persistencia.AssociadoBD"></asp:ObjectDataSource>
        <br />
        <br />

        <h3>Número de Associados Demitidos</h3>
        <asp:Chart ID="Chart3" runat="server" DataSourceID="DEM" Width="940px" BackColor="LightGray" BackHatchStyle="BackwardDiagonal">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="pes_datadem" YValueMembers="count(distinct pes_codigo)">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        
        <asp:ObjectDataSource ID="DEM" runat="server" SelectMethod="CountDem" TypeName="persistencia.AssociadoBD"></asp:ObjectDataSource>
        <br />

        <h3>Pendências Resolvidas</h3>
        <asp:Chart ID="Chart4" runat="server" DataSourceID="Ter" Width="948px" BackColor="LightGray" BackHatchStyle="BackwardDiagonal">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="pen_datatermino" YValueMembers="count(distinct pen_codigo)">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <br />
        <br />
        <br />
 
        <asp:ObjectDataSource ID="Ter" runat="server" SelectMethod="CountTer" TypeName="PendenciaBD"></asp:ObjectDataSource>
        <br />

        <h3>Número de Pendências Ativas</h3>
        <asp:Chart ID="Chart5" runat="server" DataSourceID="Aberto" Width="949px" BackColor="LightGray" BackHatchStyle="BackwardDiagonal">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="atv_data" YValueMembers="atv_quantidade">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <br />
        <br />
        <br />
        
        <asp:ObjectDataSource ID="Aberto" runat="server" SelectMethod="SelectAll" TypeName="persistencia.PendenciaAtivaBD"></asp:ObjectDataSource>

        <h3>Acessos Diarios</h3>
        <asp:Chart ID="Chart6" runat="server" DataSourceID="IpAcesso" Width="959px" BackColor="LightGray" BackHatchStyle="BackwardDiagonal">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="ip_data" YValueMembers="count(distinct ip_codigo)">
                </asp:Series>
            </Series>
            <ChartAreas>

                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:ObjectDataSource ID="IpAcesso" runat="server" SelectMethod="SelectAll" TypeName="persistencia.IpBD"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:HyperLink ID="lbSair" NavigateUrl="~/Paginas/HomeFuncionario.aspx"  runat="server">Voltar</asp:HyperLink>
        <br />
    </form>
         </div>
</body>
</html>
