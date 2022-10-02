using System;

namespace calendar_matrix
{
    public partial class DailyRoomActivitiesMatrix : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetRoomName(string roomName)
        {
            lblRoomName.Text = roomName;
        }
    }
}