﻿using System;

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
	}
}