using System;
using System.Windows.Forms;
using System.Threading;

namespace TeamLogbook
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DBController db_controller = new DBController();
			Auth authForm = new Auth();
			bool is_yeap = false;

			authForm.Authenticated += (sender, e) =>
			{
				if (authForm.IsAuthenticated) is_yeap = true;
			};

			if (db_controller.isLocalSecure())
			{
				authForm.ShowDialog();
				if (is_yeap)
				{
					Application.Run(new Home());
				}
			}
			else
			{
				Application.Run(new Home());
			}
		}
	}
}
