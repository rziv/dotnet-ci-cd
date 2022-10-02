<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MatrixWeeklyActivityTemplate.ascx.cs" Inherits="calendar_matrix.MatrixWeeklyActivityTemplate" %>
<div style="display: flex;">
    <div class="calendar-grid-cell column-header ">
        <asp:Label Text="" runat="server" id="lblRoomName"/>
    </div>
    <div class="calendar-grid-cell calendar-grid-cell-small">
        <asp:Label Text="" runat="server" ID="matrixRoomCapacity" /></div>
    <div id="matrixDay1" runat="server" class="calendar-grid-cell"></div>
    <div id="matrixDay2" runat="server" class="calendar-grid-cell"></div>
    <div id="matrixDay3" runat="server" class="calendar-grid-cell"></div>
    <div id="matrixDay4" runat="server" class="calendar-grid-cell"></div>
    <div id="matrixDay5" runat="server" class="calendar-grid-cell"></div>
    <div id="matrixDay6" runat="server" class="calendar-grid-cell"></div>
    <div id="matrixDay7" runat="server" class="calendar-grid-cell"></div>
</div>
