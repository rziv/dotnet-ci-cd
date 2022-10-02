<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DayInWeek.ascx.cs" Inherits="calendar_matrix.DayInWeek" %>
<div>
    <asp:TextBox ID="number1" runat="server" />
     <asp:TextBox ID="number2" runat="server" />
    <asp:Button ID="calc" Text="Add" runat="server" OnClick="Calc_Click"/>
    <div>
    <asp:Label ID="result" Text="" runat="server" />
    </div>
</div>
