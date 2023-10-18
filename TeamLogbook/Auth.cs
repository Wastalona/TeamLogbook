using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TeamLogbook
{
	public partial class Auth : Form
	{
		public event EventHandler Authenticated;
		public bool IsAuthenticated { get; private set; }
		DBController db_controller = new DBController();

		public Auth()
		{
			InitializeComponent();
		}

		private void OnAuthenticated()
		{
			Authenticated?.Invoke(this, EventArgs.Empty);
		}

		private void btn_auth_Click(object sender, EventArgs e)
		{
			if (db_controller.CheckPassword(password_box.Text))
			{
				IsAuthenticated = true;
				OnAuthenticated();
				this.Close();
			}
			password_box.Text = "";
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
