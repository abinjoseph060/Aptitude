using System;
using System.Data.SqlClient;
using System.Web.UI;
using MySql.Data.MySqlClient;

namespace woq
{
	public partial class Login : System.Web.UI.Page
	{
		MySql.Data.MySqlClient.MySqlConnection conn;
		string myConnectionString;
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

					MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
					builder.Server = "localhost";
					builder.UserID = "root";
					builder.Password = "winz10";
					builder.Database = "a";
					MySqlConnection connection = new MySqlConnection(builder.ToString());
					connection.Open();


					string uid = username.Text;
					string pass = password.Text;



					//string newuser_sql = "INSERT INTO user (uname, pass) VALUES (@uid, @pass)";
					//MySqlCommand newuser = new MySqlCommand(newuser_sql, connection);
					//newuser.CommandText = newuser_sql;
					//newuser.Parameters.AddWithValue("@uid", uid);
					//newuser.Parameters.AddWithValue("@pass", pass);

					string qry = "select * from user where uname = @uid and pass = @pass";
					MySqlCommand newuser = new MySqlCommand(qry, connection);
					newuser.CommandText = qry;
					newuser.Parameters.AddWithValue("@uid", uid);
					newuser.Parameters.AddWithValue("@pass", pass);

					MySqlDataReader sdr = newuser.ExecuteReader();					

					/* string qry = "select * from [user] where username ='" + uid + "' and dob ='" + pass + "'";
					SqlCommand cmd = new SqlCommand(qry, connection);
					SqlDataReader sdr = cmd.ExecuteReader(); */

					while (sdr.Read())
					{
						Data.username = sdr["uname"].ToString();
						//Data.name = sdr["name"].ToString();
					}

					if (string.IsNullOrEmpty(Data.username))
					{
						Response.Write("<SCRIPT>alert('Check Username or DOB')</SCRIPT>");
					}
					else
					{
						Response.Redirect("Quiz.aspx");
					}
					connection.Close();

					

				
				}
				catch (Exception ex)
				{
					Response.Write("<SCRIPT>alert('" + ex.Message + "')</SCRIPT>");
				} 
				
			}
		}
	}
}