using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamLogbook
{
	public partial class Options : Form
	{
		DBController db_controller = new DBController();

		public Options()
		{
			InitializeComponent();
		}

		private void change_enable(bool isActive)
		{
			if (isActive)
			{
				lb_range.Enabled = true;
				box_range.Enabled = true;
				lb_path.Enabled = true;
				box_save_path.Enabled = true;
				btn_browse.Enabled = true;
			}
			else 
			{
				lb_range.Enabled = false;
				box_range.Enabled = false;
				lb_path.Enabled = false;
				box_save_path.Enabled = false;
				btn_browse.Enabled = false;
			}
		}

		private void Options_Load(object sender, EventArgs e)
		{
			if (is_autosaves.Checked)
				change_enable(true);
			else 
				change_enable(false);
		}

		private void btn_browse_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();

			// Если пользователь выбрал путь, показываем выбранный путь
			if (result == DialogResult.OK)
			{
				string selectedPath = folderBrowserDialog1.SelectedPath;
				box_save_path.Text = selectedPath;
			}
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (is_autosaves.Checked)
				db_controller.SaveAutosavesSettings(true, box_save_path.Text);
			else
				db_controller.SaveAutosavesSettings(false, box_save_path.Text);
		}
	}
}
