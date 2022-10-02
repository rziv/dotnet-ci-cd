<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="calendarMatrix._Default" %>

<%@ Register Src="~/CalendarActivity.ascx" TagPrefix="uc1" TagName="CalendarActivity" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
  
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

    <asp:Button ID="btnSearch" runat="server" Text="חפש" OnClick="btnSearch_Click" />

    <asp:Panel runat="server" ID="pnlMatrix">
        <div>
            <div id="matrixColumnHeaders" visible="False" runat="server" style="display: flex;">
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
        </div>
        <asp:PlaceHolder runat="server" ID="phMatrixRows"/>
    </asp:Panel>


</asp:Content>
