using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calendarMatrix
{
    public partial class CalendarActivity : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetCalendarActivity(CalendarActivityModel calendarActivity)
        {
            lblHourse.Text = calendarActivity.Hours;
            lblTitle.Text = calendarActivity.Title;
        }
    }
}