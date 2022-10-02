using System;
using System.Web.UI.WebControls;

namespace calendar_matrix
{
    public partial class MatrixWeeklyActivityHeaderTemplate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void SetCalendarDays(DateTime selectedDate)
        {
            var culture = new System.Globalization.CultureInfo("he-IL");
            for (int i = 0; i < 7; i++)
            {
                var dayIndex = (i + 1).ToString();
                var columnHeader = (Label)matrixColumnHeaders.FindControl("matrixColumnHeaderDay" + dayIndex);

                var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
                var formattedDate = selectedDate.AddDays(i).ToString("dd/MM/yyyy");
                columnHeader.Text = formattedDate;
            }
        }
    }
}