using System;

namespace woq
{
	public partial class Quiz : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Name.Text = Data.name;
			/*score.Text = "0";

			SqlConnection con =
				new SqlConnection(
					@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Development\OpenSource\WOQ\Aptitude\WOQ\woq\App_Data\QuizDB.mdf;Integrated Security=True");

			con.Open();

			string qry = "select * from category where status = 1 ";
			SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataReader sdr = cmd.ExecuteReader();

			while (sdr.Read())
			{

			}

			if (string.IsNullOrEmpty(Data.username))
			{
				Response.Write("<SCRIPT>alert('Check Username or DOB')</SCRIPT>");
			}
			else
			{
				Response.Redirect("Quiz.aspx");
			}
			con.Close();*/
		}

		protected void next_Click(object sender, EventArgs e)
		{

		}
	}
}