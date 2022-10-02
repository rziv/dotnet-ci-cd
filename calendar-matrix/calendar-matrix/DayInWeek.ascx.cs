using System;

namespace calendar_matrix
{
    public partial class DayInWeek : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calc_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(number1.Text);
            int y = Convert.ToInt32(number2.Text);
            result.Text = (x + y).ToString();
        }
    }
}