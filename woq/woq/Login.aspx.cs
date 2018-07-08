using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace woq
{
	public partial class Login : System.Web.UI.Page
	{
		Data data = new Data();
		protected void Page_Load(object sender, EventArgs e)
		{
			data.Clear();
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

			if (username.Text == "admin" && password.Text == "41744")
			{

				Response.Redirect("Admin.aspx");
			}
			else
			{

				try
				{
					SqlConnection con =
						new SqlConnection(
							@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Development\OpenSource\WOQ\Aptitude\WOQ\woq\App_Data\QuizDB.mdf;Integrated Security=True");

					string uid = username.Text;
					string pass = password.Text;
					con.Open();
					string qry = "select * from [user] where username ='" + uid + "' and dob ='" + pass + "'";
					SqlCommand cmd = new SqlCommand(qry, con);
					SqlDataReader sdr = cmd.ExecuteReader();

					while (sdr.Read())
					{
						Data.username = sdr["username"].ToString();
						Data.name = sdr["name"].ToString();
					}

					if (string.IsNullOrEmpty(Data.username))
					{
						Response.Write("<SCRIPT>alert('Check Username or DOB')</SCRIPT>");
					}
					else
					{
						Response.Redirect("Quiz.aspx");
					}
					con.Close();

					Response.Redirect("Quiz.aspx");

				}
				catch (Exception ex)
				{
					Response.Write("<SCRIPT>alert('" + ex.Message + "')</SCRIPT>");
				}
			}
		}
	}
}