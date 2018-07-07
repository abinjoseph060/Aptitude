using System;
using System.Web.UI;

namespace woq
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			dob.Visible = false;
		}

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			dob.Visible = true;
		}

		protected void dob_SelectionChanged(object sender, EventArgs e)
		{
			password.Text = dob.SelectedDate.ToShortDateString();
		}

		protected void b_login_Click(object sender, EventArgs e)
		{

		}
	}
}