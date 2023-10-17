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
			if (password_box.Text == "1111")
			{
				IsAuthenticated = true;
				OnAuthenticated();
				this.Close();
			}
			else
				MessageBox.Show("Неверный пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
