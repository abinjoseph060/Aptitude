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

			if (username.Text == "admin" && password.Text == "41744")
			{

				Response.Redirect("Cat.aspx");
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
					if (sdr.Read())
					{
						Response.Redirect("Quiz.aspx");
					}
					else
					{
						Response.Write("<SCRIPT>alert('This is a message')</SCRIPT>");


						//ScriptManager.RegisterStartupScript(this.UP, typeof(string), "Alert", "alert('Message here');", true);
						//Label4.Text = "UserId & Password Is not correct Try again..!!";

					}

					con.Close();

				}
				catch (Exception ex)
				{
					Response.Write("<SCRIPT>alert('" + ex.Message + "')</SCRIPT>");
				}
			}
		}
	}
}