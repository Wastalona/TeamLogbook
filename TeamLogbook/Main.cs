using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TeamLogbook
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			DBController db_controller = new DBController();
			string path = db_controller.get_value_from_db("CurrentFile");
			if (path.Length > 0)
			{
				FileManager file_manager = new FileManager(path);
				string[] fileinfo= file_manager.getFileInfo();
				lb_curr_file.Text = "Текущий файл: " + fileinfo[0];
				lb_last_edit.Text = "Последнее изменение: " + fileinfo[1];
				lb_last_edit.Show();
				lb_curr_file.Show();
				info_lb.Hide();
			}
			else
			{
				info_lb.Show();
				lb_last_edit.Hide();
				lb_curr_file.Hide();
			}
		}
	}
}
