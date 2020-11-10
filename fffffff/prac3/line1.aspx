<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="line1.aspx.cs" Inherits="prac3.line1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="common/css/Chart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:intouch_dbConnectionString %>" SelectCommand="SELECT * FROM [LINELOGTbl]"></asp:SqlDataSource>
    
    <div class="container-fluid">
        <div class="row">
                <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource1" OnLoad="Chart2_Load" Width="1406px">
                    <Series>
                        <asp:Series ChartType="Line" Name="Series1" XValueMember="TIME" YValueMembers="VOLT">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </div>
            <div class="row">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="LINE_NO" HeaderText="LINE_NO" SortExpression="LINE_NO" />
                        <asp:BoundField DataField="PRODUCT_CODE" HeaderText="PRODUCT_CODE" SortExpression="PRODUCT_CODE" />
                        <asp:BoundField DataField="CURRENTkA" HeaderText="CURRENTkA" SortExpression="CURRENTkA" />
                        <asp:BoundField DataField="VOLT" HeaderText="VOLT" SortExpression="VOLT" />
                        <asp:BoundField DataField="TIME" HeaderText="TIME" SortExpression="TIME" />
                        <asp:BoundField DataField="COOLANT_TEMP" HeaderText="COOLANT_TEMP" SortExpression="COOLANT_TEMP" />
                        <asp:BoundField DataField="PNEUMATIC" HeaderText="PNEUMATIC" SortExpression="PNEUMATIC" />
                        <asp:BoundField DataField="HEAT" HeaderText="HEAT" SortExpression="HEAT" />
                        <asp:BoundField DataField="ENERGI_COUNT" HeaderText="ENERGI_COUNT" SortExpression="ENERGI_COUNT" />
                        <asp:BoundField DataField="WELD_SPOT" HeaderText="WELD_SPOT" SortExpression="WELD_SPOT" />
                        <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" />
                        <asp:BoundField DataField="UPTIME" HeaderText="UPTIME" SortExpression="UPTIME" />
                        <asp:BoundField DataField="PROD_QUANTITY" HeaderText="PROD_QUANTITY" SortExpression="PROD_QUANTITY" />
                        <asp:BoundField DataField="DEFECTIVE_PROD" HeaderText="DEFECTIVE_PROD" SortExpression="DEFECTIVE_PROD" />
                        <asp:BoundField DataField="DRESSING_COUNT" HeaderText="DRESSING_COUNT" SortExpression="DRESSING_COUNT" />
                        <asp:BoundField DataField="REPLACE_COUNT" HeaderText="REPLACE_COUNT" SortExpression="REPLACE_COUNT" />
                        <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    

    <script src="https://code.highcharts.com/highcharts.js"></script>
<script src="https://code.highcharts.com/modules/data.js"></script>

<figure class="highcharts-figure">
    <div id="container"></div>
    <p class="highcharts-description">
        This demo shows how related charts can be synchronized. Hover
        over one chart to see the effect in the other charts as well.
        This is a technique that is commonly seen in dashboards, 
        where multiple charts are often used to visualize related
        information.
    </p>
</figure>


</asp:Content>


