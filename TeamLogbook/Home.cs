using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TeamLogbook
{
    public partial class Home : Form
    {
		private bool use_local_password = true;
		private string local_password = "11110000"; // локальный пароль
		private Form form; // окно для различных форм

		public Home()
        {
            InitializeComponent();
        }

		public static string HashPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return Convert.ToBase64String(hashedBytes);
			}
		}

		private void PanelForm(Form fm)
		{
			if (form != null)
				form.Close();

			form = fm;
			fm.TopLevel = false;
			fm.FormBorderStyle = FormBorderStyle.None;
			fm.Dock = DockStyle.Fill;
			this.form_panel.Controls.Add(fm);
			this.form_panel.Tag = fm;
			fm.BringToFront();
			fm.Show();
		}

		private void Home_Load(object sender, EventArgs e)
		{
			if (use_local_password)
			{
				//hide_all();
				Auth auth_form = new Auth(local_password, this);
				this.Hide();
				auth_form.Show();
				PanelForm(new Auth(local_password, this));
			}
			PanelForm(new Main());
		}

		// Кнопки меню
		private void btn_main_Click(object sender, EventArgs e)
		{
			PanelForm(new Main());
		}

		private void btn_log_Click(object sender, EventArgs e)
		{
			PanelForm(new Log());
		}

		private void btn_progress_Click(object sender, EventArgs e)
		{
			PanelForm(new Progress());
		}

		private void btn_pass_Click(object sender, EventArgs e)
		{
			PanelForm(new Miss());
		}

		private void btn_report_Click(object sender, EventArgs e)
		{
			PanelForm(new Report());
		}

		// Функциональные кнопки
		private void btn_settings_Click(object sender, EventArgs e)
		{
			control_panel.Hide();
		}

		private void btn_load_Click_1(object sender, EventArgs e)
		{

		}

		private void btn_load_Click(object sender, EventArgs e)
		{

		}


		private void btn_change_format_Click(object sender, EventArgs e)
		{

		}

		private void btn_clear_all_Click(object sender, EventArgs e)
		{

		}
	}
}
