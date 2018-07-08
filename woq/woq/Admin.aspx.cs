using System;
using System.Data.SqlClient;

namespace woq
{
	public partial class Admin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void add_q_Click(object sender, EventArgs e)
		{
			Response.Redirect("Add.aspx");
		}

		protected void q_cat_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void Set_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Development\OpenSource\WOQ\Aptitude\WOQ\woq\App_Data\QuizDB.mdf;Integrated Security=True");
			con.Open();
			string qry = "update category set status = 0 ;";
			SqlCommand cmd = new SqlCommand(qry, con);
			cmd.ExecuteNonQuery();

			qry = "update category set status = 1 where Id = " + q_cat.SelectedIndex + " ;";
			cmd = new SqlCommand(qry, con);
			cmd.ExecuteNonQuery();
			con.Close();
			Response.Write("<SCRIPT>alert('Changed')</SCRIPT>");
		}

		protected void Exit_Click(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}
	}
}