using calendar_matrix;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calendarMatrix
{

    internal class ScheduledRoom
    {
        internal string Hours { get; set; }
        internal string RoomName { get; set; }

        internal string Date { get; set; }

        internal string ActivityName { get; set; }

        public int Capacity { get; set; }
    }

    public partial class _Default : Page
    {

        private List<ScheduledRoom> _rooms;
        protected void Page_Init(object sender, EventArgs e)
        {
            _rooms = new List<ScheduledRoom>();
            _rooms.Add(new ScheduledRoom() { Hours = "13:00 - 14:00", RoomName = "בויא 118", Date = "26/6/2022", ActivityName = "lesson1", Capacity = 15 });
            _rooms.Add(new ScheduledRoom() { Hours = "17:00 - 18:00", RoomName = "גולדשמיט 1", Date = "26/6/2022", ActivityName = "הרצאה 1", Capacity = 75 });
            _rooms.Add(new ScheduledRoom() { Hours = "13:00 - 14:00", RoomName = "בויא", Date = "26/6/2022", ActivityName = "lesson2" });
            _rooms.Add(new ScheduledRoom() { Hours = "07:00 - 08:00", RoomName = "גולדשמיט 1", Date = "26/6/2022", ActivityName = "lesson3" });
            _rooms.Add(new ScheduledRoom() { Hours = "08:00 - 09:00", RoomName = "בויא 118", Date = "27/6/2022", ActivityName = "lesson4" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 13:00", RoomName = "אודיטוריום", Date = "27/6/2022", ActivityName = "lesson5" });
            _rooms.Add(new ScheduledRoom() { Hours = "06:00 - 07:00", RoomName = "משפטים 300", Date = "29/6/2022", ActivityName = "lesson6" });
            _rooms.Add(new ScheduledRoom() { Hours = "22:00 - 23:00", RoomName = "גולדשמיט 1", Date = "30/6/2022", ActivityName = "lesson7" });
            _rooms.Add(new ScheduledRoom() { Hours = "11:30 - 12:00", RoomName = "בויא 118", Date = "27/6/2022", ActivityName = "lesson8" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "אודיטוריום", Date = "29/6/2022", ActivityName = "lesson9" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "30/6/2022", ActivityName = "lesson10" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "1/7/2022", ActivityName = "lesson11" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "2/7/2022", ActivityName = "lesson12" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "3/7/2022", ActivityName = "lesson13" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "3/7/2022", ActivityName = "lesson14" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "1/7/2022", ActivityName = "lesson11" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "2/7/2022", ActivityName = "lesson12" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "3/7/2022", ActivityName = "lesson13" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "3/7/2022", ActivityName = "lesson14" });
            _rooms.Add(new ScheduledRoom() { Hours = "13:00 - 14:00", RoomName = "בויא 118", Date = "1/6/2022", ActivityName = "lesson1", Capacity = 15 });
            _rooms.Add(new ScheduledRoom() { Hours = "17:00 - 18:00", RoomName = "גולדשמיט 1", Date = "1/6/2022", ActivityName = "הרצאה 1", Capacity = 75 });
            _rooms.Add(new ScheduledRoom() { Hours = "13:00 - 14:00", RoomName = "בויא", Date = "1/6/2022", ActivityName = "lesson2" });
            _rooms.Add(new ScheduledRoom() { Hours = "07:00 - 08:00", RoomName = "גולדשמיט 1", Date = "1/6/2022", ActivityName = "lesson3" });
            _rooms.Add(new ScheduledRoom() { Hours = "08:00 - 09:00", RoomName = "בויא 118", Date = "1/6/2022", ActivityName = "lesson4" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 13:00", RoomName = "אודיטוריום", Date = "1/6/2022", ActivityName = "lesson5" });
            _rooms.Add(new ScheduledRoom() { Hours = "06:00 - 07:00", RoomName = "משפטים 300", Date = "1/6/2022", ActivityName = "lesson6" });
            _rooms.Add(new ScheduledRoom() { Hours = "22:00 - 23:00", RoomName = "גולדשמיט 1", Date = "1/6/2022", ActivityName = "lesson7" });
            _rooms.Add(new ScheduledRoom() { Hours = "11:00 - 12:00", RoomName = "בויא 118", Date = "1/6/2022", ActivityName = "lesson8" });
            _rooms.Add(new ScheduledRoom() { Hours = "13:00 - 14:00", RoomName = "בויא 118", Date = "1/6/2022", ActivityName = "lesson10" });
            _rooms.Add(new ScheduledRoom() { Hours = "15:00 - 16:00", RoomName = "גולדשמיט 1", Date = "1/6/2022", ActivityName = "הרצאה 10" });
            _rooms.Add(new ScheduledRoom() { Hours = "19:00 - 20:00", RoomName = "בויא", Date = "1/6/2022", ActivityName = "lesson20" });
            _rooms.Add(new ScheduledRoom() { Hours = "08:00 - 09:00", RoomName = "גולדשמיט 1", Date = "1/6/2022", ActivityName = "lesson30" });
            _rooms.Add(new ScheduledRoom() { Hours = "10:00 - 11:00", RoomName = "בויא 118", Date = "1/6/2022", ActivityName = "lesson40" });
            _rooms.Add(new ScheduledRoom() { Hours = "14:00 - 15:00", RoomName = "אודיטוריום", Date = "1/6/2022", ActivityName = "lesson50" });
            _rooms.Add(new ScheduledRoom() { Hours = "18:00 - 19:00", RoomName = "משפטים 300", Date = "1/6/2022", ActivityName = "lesson60" });
            _rooms.Add(new ScheduledRoom() { Hours = "21:00 - 22:00", RoomName = "גולדשמיט 1", Date = "1/6/2022", ActivityName = "lesson70" });
            _rooms.Add(new ScheduledRoom() { Hours = "22:00 - 23:00", RoomName = "בויא 118", Date = "1/6/2022", ActivityName = "lesson80" });
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (_rooms == null || _rooms.Count == 0) return;

            addCalendarMatrixHeaders(Calendar1.SelectedDate);
            matrixColumnHeaders.Visible = true;

            _rooms.ForEach(room =>
            {
                var roomControl = phMatrixRows.FindControl("matrixRow_" + room.RoomName) ?? createEmptyRoom(room);
                int daysFromRequestedDate = (int)(DateTime.Parse(room.Date) - Calendar1.SelectedDate).TotalDays;
                if (daysFromRequestedDate >= 0 && daysFromRequestedDate < 7)
                {
                    addActivityToRoom(room, roomControl, daysFromRequestedDate);
                }
            });
        }

        private void addActivityToRoom(ScheduledRoom room, Control roomControl, int daysFromRequestedDate)
        {
            var matrixDayIndex = daysFromRequestedDate + 1;
            roomControl.FindControl("matrixDay" + (matrixDayIndex).ToString())?.Controls?.Add(createCalendarActivity(room));
        }

        private void addCalendarMatrixHeaders(DateTime selectedDate)
        {
            for (int i = 0; i < 7; i++)
            {
                var dayIndex = (i + 1).ToString();
                var columnHeader = (Label)matrixColumnHeaders.FindControl("matrixColumnHeaderDay" + dayIndex);
                var formattedDate = selectedDate.AddDays(i).ToString("dd/MM/yyyy");
                var culture = new System.Globalization.CultureInfo("he-IL");
                var dayOfWeek = culture.DateTimeFormat.GetDayName(selectedDate.AddDays(i).DayOfWeek);
                columnHeader.Text = formattedDate + " " + dayOfWeek;
            }
        }

        private Control createEmptyRoom(ScheduledRoom room)
        {
            MatrixWeeklyActivityTemplate WeeklyActivityRow = (MatrixWeeklyActivityTemplate)LoadControl("MatrixWeeklyActivityTemplate.ascx");
            WeeklyActivityRow.ID = "matrixRow_" + room.RoomName;
            WeeklyActivityRow.SetRoomName(room.RoomName);
            Label roomCapacity = (Label)WeeklyActivityRow.FindControl("matrixRoomCapacity");
            roomCapacity.Text = room.Capacity != 0 ? room.Capacity.ToString() : "";
            phMatrixRows.Controls.Add(WeeklyActivityRow);
            return WeeklyActivityRow;
        }

        private Control createCalendarActivity(ScheduledRoom room)
        {
            CalendarActivity calendarActivity = (CalendarActivity)LoadControl("CalendarActivity.ascx");
            calendarActivity.SetCalendarActivity(new CalendarActivityModel() { Hours = room.Hours, Title = room.ActivityName });
            return calendarActivity;
        }

    }
}