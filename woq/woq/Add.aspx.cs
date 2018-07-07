using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace woq
{
	public partial class Add : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OpenSource\Aptitude\woq\woq\App_Data\QuizDB.mdf;Integrated Security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			Qn.Text = "";
			OptionA.Text = "";
			OptionB.Text = "";
			OptionC.Text = "";
			OptionD.Text = "";

		}

		protected void add_q_Click(object sender, EventArgs e)
		{
			try
			{

			
			//string qn = Qn.Text;
			//string opA = OptionA.Text;
			//string opB = OptionB.Text;
			//string opC = OptionC.Text;
			//string opD = OptionD.Text;
			string catg = Catg.SelectedValue;
			string datee = DateTime.Now.ToShortDateString();
			con.Open();
			string qry = "insert into question (question,a1,a2,a3,a4,category_id,date) values ('" + Qn.Text + "','" + OptionA.Text + "','" + OptionB.Text + "','" + OptionC.Text + "','" + OptionD.Text + "',1,'" + datee + "')";
			   // string qry = "insert into question (question,a1,a2,a3,a4,category_id,date) values ('" + qn + "','" + opA + "','" + opB + "','" + opC + "','" + opD + "',1,'" + datee + "')";
				SqlCommand cmd = new SqlCommand(qry, con);
			SqlDataReader sdr = cmd.ExecuteReader();
			
			if (sdr.Read())
			{
				Response.Redirect("Add.aspx");

			}
			else
			{
				Response.Write("<SCRIPT>alert('Error')</SCRIPT>");


			}
			con.Close();

		}
			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}


}
	}
}