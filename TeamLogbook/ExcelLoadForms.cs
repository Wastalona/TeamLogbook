using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamLogbook
{
	public partial class ExcelLoadForms : Form
	{
		public ExcelLoadForms()
		{
			InitializeComponent();
		}

		private void ExcelLoadForms_Load(object sender, EventArgs e)
		{
		}

		private void change_btn_state(Button activate, Button deactivate)
		{
			activate.Enabled = true;
			deactivate.Enabled = false;
			deactivate.Text = "Применяется";
			activate.Text = "Применить";
		}

		private void btn_apply_custom_Click(object sender, EventArgs e)
		{
			change_btn_state(btn_apply_standart, btn_apply_custom);
		}

		private void btn_apply_standart_Click(object sender, EventArgs e)
		{
			change_btn_state(btn_apply_custom, btn_apply_standart);
		}
	}
}
