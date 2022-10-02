<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="calendarMatrix._Default" %>

<%@ Register Src="~/CalendarActivity.ascx" TagPrefix="uc1" TagName="CalendarActivity" %>
<%@ Register Src="~/MatrixWeeklyActivityHeaderTemplate.ascx" TagPrefix="uc1" TagName="MatrixWeeklyActivityHeaderTemplate" %>
<%@ Register Src="~/DailyRoomsActivitiesHeader.ascx" TagPrefix="uc1" TagName="DailyRoomsActivitiesHeader" %>
<%@ Register Src="~/DayInWeek.ascx" TagPrefix="uc1" TagName="DayInWeek" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit"%>
<%@ Register Src="~/DailyRoomsActivitiesMatrix.ascx" TagPrefix="uc1" TagName="DailyRoomsActivitiesMatrix" %>





<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Hello World!</h2>
    <uc1:DailyRoomsActivitiesHeader runat="server" ID="DailyRoomsActivitiesHeader" />
    <uc1:DailyRoomsActivitiesMatrix runat="server" ID="DailyRoomsActivitiesMatrix" />
    
</asp:Content>
