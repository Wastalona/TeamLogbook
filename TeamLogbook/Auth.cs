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
		private string local_password;
		private Form main;

		public Auth(string local_password, Form main)
		{
			InitializeComponent();
			this.local_password = local_password;
			this.main = main;
		}

		private void btn_auth_Click(object sender, EventArgs e)
		{
			if (password_box.Text == local_password)
			{
				this.Close();
				main.Show();
			}
			else
			{
				MessageBox.Show("Неверный пароль!", "Ошибка авторизации",
								 MessageBoxButtons.OK,
								 MessageBoxIcon.Error);
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Auth_Load(object sender, EventArgs e)
		{
			main.Hide();
		}
	}
}
