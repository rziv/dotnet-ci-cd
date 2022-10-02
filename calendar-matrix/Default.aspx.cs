using calendar_matrix;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calendarMatrix
{

    public class ScheduledRoom
    {
        public string Hours { get; set; }
        public string RoomName { get; set; }

        public string Date { get; set; }

        public string ActivityName { get; set; }

        public int Capacity { get; set; }
    }

    public partial class _Default : Page
    {

        private List<ScheduledRoom> _rooms;
        protected void Page_Init(object sender, EventArgs e)
        {

            _rooms = new List<ScheduledRoom>();
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "בויא 118", Date = "26/6/2022", ActivityName = "lesson1" });
            _rooms.Add(new ScheduledRoom() { Hours = "16:00 - 18:00", RoomName = "גולדשמיט 1", Date = "26/6/2022", ActivityName = "הרצאה 1" });
            _rooms.Add(new ScheduledRoom() { Hours = "10:00 - 14:00", RoomName = "בויא", Date = "26/6/2022", ActivityName = "lesson2" });
            _rooms.Add(new ScheduledRoom() { Hours = "13:00 - 14:00", RoomName = "גולדשמיט 1", Date = "26/6/2022", ActivityName = "lesson3" });
            _rooms.Add(new ScheduledRoom() { Hours = "15:00 - 16:00", RoomName = "בויא 118", Date = "27/6/2022", ActivityName = "lesson4" });
            _rooms.Add(new ScheduledRoom() { Hours = "19:00 - 20:00", RoomName = "אודיטוריום", Date = "27/6/2022", ActivityName = "lesson5" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "29/6/2022", ActivityName = "lesson6" });
            _rooms.Add(new ScheduledRoom() { Hours = "21:00 - 22:00", RoomName = "גולדשמיט 1", Date = "30/6/2022", ActivityName = "lesson7" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:30 - 13:30", RoomName = "בויא 118", Date = "27/6/2022", ActivityName = "lesson8" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "אודיטוריום", Date = "29/6/2022", ActivityName = "lesson9" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "30/6/2022", ActivityName = "lesson10" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "1/7/2022", ActivityName = "lesson11" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "2/7/2022", ActivityName = "lesson12" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "3/7/2022", ActivityName = "lesson13" });
            _rooms.Add(new ScheduledRoom() { Hours = "12:00 - 14:00", RoomName = "משפטים 300", Date = "3/7/2022", ActivityName = "lesson14" });


        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnWeeklyActivities_Click(object sender, EventArgs e)
        {

        }

        protected void btnDailyActivities_Click(object sender, EventArgs e)
        {

        }


        private void addDailyActivityToRoom(ScheduledRoom room, Control roomControl, string hour)
        {
            var hourIndex = hour.Substring(0, 2);
            roomControl.FindControl("matrixHour" + hourIndex)?.Controls?.Add(createCalendarActivity(room, false));
        }



        private Control addRoomDailyRow(ScheduledRoom room)
        {
            DailyRoomActivitiesMatrix DailyRoomsActivity = (DailyRoomActivitiesMatrix)LoadControl("DailyRoomsActivitiesMatrix.ascx");
            DailyRoomsActivity.ID = "matrixRow_" + room.RoomName;
            DailyRoomsActivity.SetRoomName(room.RoomName);
            Label roomCapacity = (Label)DailyRoomsActivity.FindControl("matrixRoomCapacity");
            roomCapacity.Text = room.Capacity != 0 ? room.Capacity.ToString() : "";
            // phDailyActivitiesMatrix.Controls.Add(DailyRoomsActivity);
            return DailyRoomsActivity;
        }

        private Control createCalendarActivity(ScheduledRoom room, bool showHours = true)
        {
            CalendarActivity calendarActivity = (CalendarActivity)LoadControl("CalendarActivity.ascx");
            calendarActivity.SetCalendarActivity(new CalendarActivityModel() { Hours = showHours ? room.Hours : "", Title = room.ActivityName });
            return calendarActivity;
        }

    }
}