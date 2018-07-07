using System;
using System.Data.SqlClient;
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
			int count = 0;
			SqlConnection con =
				new SqlConnection(
					@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Development\OpenSource\WOQ\Aptitude\WOQ\woq\App_Data\QuizDB.mdf;Integrated Security=True");
			con.Open();
			string str = "select * from [user] where username = '" + username.Text + "';";
			SqlDataReader reader = null;
			SqlCommand cmd = new SqlCommand()
			{
				CommandText = str,
				Connection = con
			};

			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				count++;
				Data.username = reader["username"].ToString();
				Data.name = reader["name"].ToString();
			}
			reader.Close();
			con.Close();

			if (string.IsNullOrEmpty(Data.username) || string.IsNullOrEmpty(Data.name))
			{
				username.Text = "Invalid User";
			}
			else
			{
				username.Text = "Exit";
			}

			password.Text = count.ToString();
		}
	}
}