using System;
using System.Data.SqlClient;

namespace woq
{
	public partial class Add : System.Web.UI.Page
	{
		Data data = new Data();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void clear_Click(object sender, EventArgs e)
		{
			Data.count++;
			if (Data.count == 2)
			{
				clear.Text = "Finish";
			}

			if (Data.count == 3)
			{
				Response.Redirect("Login.aspx");
			}
			question.Text = string.Empty;
			a.Text = string.Empty;
			b.Text = string.Empty;
			c.Text = string.Empty;
			d.Text = string.Empty;
			DropDownList1.SelectedIndex = 0;
		}

		protected void add_q_Click(object sender, EventArgs e)
		{
			data.Count();
			clear.Text = "Clear";
			bool validate = true;
			if (string.IsNullOrEmpty(question.Text))
			{
				validate = false;
				Response.Write("<SCRIPT>alert('Question is Empty')</SCRIPT>");
			}
			if (string.IsNullOrEmpty(a.Text))
			{
				validate = false;
				Response.Write("<SCRIPT>alert('A is Empty')</SCRIPT>");
			}
			if (string.IsNullOrEmpty(b.Text))
			{
				validate = false;
				Response.Write("<SCRIPT>alert('B is Empty')</SCRIPT>");
			}
			if (string.IsNullOrEmpty(c.Text))
			{
				validate = false;
				Response.Write("<SCRIPT>alert('C is Empty')</SCRIPT>");
			}
			if (string.IsNullOrEmpty(d.Text))
			{
				validate = false;
				Response.Write("<SCRIPT>alert('D is Empty')</SCRIPT>");
			}

			if (DropDownList1.SelectedIndex == 0)
			{
				validate = false;
				Response.Write("<SCRIPT>alert('Select the answer')</SCRIPT>");
			}

			if (validate)
			{
				switch (DropDownList1.SelectedIndex)
				{
					case 1:
						a.Text += "@#$";
						break;
					case 2:
						b.Text += "@#$";
						break;
					case 3:
						c.Text += "@#$";
						break;
					case 4:
						d.Text += "@#$";
						break;

				}

				SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Development\OpenSource\WOQ\Aptitude\WOQ\woq\App_Data\QuizDB.mdf;Integrated Security=True");

				con.Open();
				string qry = "insert into question values('" + question.Text.ToString() + "','" + a.Text.ToString() + "','" +
							 b.Text.ToString() + "','" + c.Text.ToString() + "','" + d.Text.ToString() + "','" +
							 Data.category.ToString() + "','" + DateTime.Now.ToShortDateString() + "')";

				SqlCommand cmd = new SqlCommand(qry, con);
				cmd.ExecuteNonQuery();
				con.Close();
			}
		}
	}
}