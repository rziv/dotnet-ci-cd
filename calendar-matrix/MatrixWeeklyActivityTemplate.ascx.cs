using calendarMatrix;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calendar_matrix
{
    public partial class MatrixWeeklyActivityTemplate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(this.AppRelativeVirtualPath);
        }

        public void SetRoomName(string roomName)
        {
            lblRoomName.Text = roomName;
        }


        public void AddWeeklyActivityToRoom(ScheduledRoom room, DateTime selectedDate)
        {
            int daysFromRequestedDate = (int)(DateTime.Parse(room.Date) - selectedDate).TotalDays;
            if (daysFromRequestedDate >= 0 && daysFromRequestedDate < 7)
            {
                var dayIndex = daysFromRequestedDate + 1;
                this.FindControl("matrixDay" + dayIndex.ToString())?.Controls?.Add(createCalendarActivity(room));
            }
        }

        private Control createCalendarActivity(ScheduledRoom room, bool showHours = true)
        {
            CalendarActivity calendarActivity = (CalendarActivity)LoadControl("CalendarActivity.ascx");
            calendarActivity.SetCalendarActivity(new CalendarActivityModel() { Hours = showHours ? room.Hours : "", Title = room.ActivityName });
            return calendarActivity;
        }

        public static MatrixWeeklyActivityTemplate GetRoomWeeklyRow(ScheduledRoom room, Control Container, Func<string, Control> LoadControl)
        {
            MatrixWeeklyActivityTemplate roomWeeklyRow = (MatrixWeeklyActivityTemplate)Container.FindControl("matrixRow_" + room.RoomName);

            if (roomWeeklyRow == null)
            {
                roomWeeklyRow = (MatrixWeeklyActivityTemplate)LoadControl("MatrixWeeklyActivityTemplate.ascx");
                roomWeeklyRow.ID = "matrixRow_" + room.RoomName;
                roomWeeklyRow.SetRoomName(room.RoomName);
                Label roomCapacity = (Label)roomWeeklyRow.FindControl("matrixRoomCapacity");
                roomCapacity.Text = room.Capacity != 0 ? room.Capacity.ToString() : "";
                Container.Controls.Add(roomWeeklyRow);
            }

            return roomWeeklyRow;
        }

    }
}