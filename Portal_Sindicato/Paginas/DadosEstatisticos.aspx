<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DadosEstatisticos.aspx.cs" Inherits="Paginas_DadosEstatisticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="Logon">
            <Series>
                <asp:Series Name="Series1" XValueMember="day(log_hora)" YValueMembers="count(distinct log_codigo)" YValuesPerPoint="2" ChartType="Line">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>

        <asp:ObjectDataSource ID="Logon" runat="server" OnSelecting="Logon_Selecting" SelectMethod="SelectCountLogin" TypeName="persistencia.LogonBD"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:Chart ID="Chart2" runat="server" DataSourceID="ADM" Width="932px">
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
        <asp:Chart ID="Chart3" runat="server" DataSourceID="DEM" Width="940px">
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
        <asp:Chart ID="Chart4" runat="server" DataSourceID="Ter">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="pen_datatermino" YValueMembers="count(distinct pen_codigo)">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>


        <asp:ObjectDataSource ID="Ter" runat="server" SelectMethod="CountTer" TypeName="PendenciaBD"></asp:ObjectDataSource>
        <br />
        <asp:Chart ID="Chart5" runat="server" DataSourceID="Aberto" Width="949px">
            <Series>
                <asp:Series ChartType="Point" Name="Series1" XValueMember="atv_data" YValueMembers="atv_quantidade">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>


        <asp:ObjectDataSource ID="Aberto" runat="server" SelectMethod="SelectAll" TypeName="persistencia.PendenciaAtivaBD"></asp:ObjectDataSource>
        <br />
    </form>
</body>
</html>
