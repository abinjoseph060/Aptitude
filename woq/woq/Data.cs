namespace woq
{
	public class Data
	{
		public static string username { get; set; }

		public static string name { get; set; }

		public static int category { get; set; } // category page

		public static int count { get; set; }

		public static int questionNo { get; set; }

		public static int question { get; set; }

		public static int quizcategory { get; set; } // quiz page

		public static int Score { get; set; }

		public void Count()
		{
			count = 0;
		}

		public void Clear()
		{
			username = string.Empty;
			name = string.Empty;
		}
	}
}