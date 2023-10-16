using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamLogbook
{
	public partial class Auth : Form
	{
		string local_password;

		public Auth(string local_password)
		{
			InitializeComponent();
			this.local_password = local_password;
		}

		private void btn_auth_Click(object sender, EventArgs e)
		{
			if (password_box.Text == local_password)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("Неверный пароль!");
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
