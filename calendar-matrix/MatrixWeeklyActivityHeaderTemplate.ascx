﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MatrixWeeklyActivityHeaderTemplate.ascx.cs" Inherits="calendar_matrix.MatrixWeeklyActivityHeaderTemplate" %>
 <div id="matrixColumnHeaders" runat="server" style="display: flex;">
                <div class="calendar-grid-cell column-header room-header">
                    אולם           
                </div>
                <div class="calendar-grid-cell calendar-grid-cell-small column-header">קיבולת</div>
                <div class ="calendar-grid-cell column-header">
                    <asp:Label id="matrixColumnHeaderDay1" runat="server" />
                </div>
                <div  class="calendar-grid-cell column-header">
                     <asp:Label id="matrixColumnHeaderDay2" runat="server" />
                </div>
                <div  class="calendar-grid-cell column-header">
                     <asp:Label id="matrixColumnHeaderDay3" runat="server" />
                </div>
                <div  class="calendar-grid-cell column-header">
                     <asp:Label id="matrixColumnHeaderDay4" runat="server" />
                </div>
                <div  class="calendar-grid-cell column-header">
                     <asp:Label id="matrixColumnHeaderDay5" runat="server" />
                </div>
                <div  class="calendar-grid-cell column-header">
                     <asp:Label id="matrixColumnHeaderDay6" runat="server" />
                </div>
                <div  class="calendar-grid-cell column-header">
                     <asp:Label id="matrixColumnHeaderDay7" runat="server" />
                </div>
</div>