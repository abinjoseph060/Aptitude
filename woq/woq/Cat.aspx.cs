﻿using System;

namespace woq
{
	public partial class Cat : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			Data.category = DropDownList1.SelectedIndex;
			Response.Redirect("Add.aspx");
		}
	}
}