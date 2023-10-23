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
	public partial class Log : Form
	{
		private static bool isOpen = true;
		public Log(bool open)
		{
			InitializeComponent();
			isOpen = open;
		}

		private void Log_Load(object sender, EventArgs e)
		{
			DBController db_controller = new DBController();
			string path = db_controller.get_value_from_db("CurrentFile");

			if (path.Length > 0)
			{
				FileManager fileManager = new FileManager(path);
				dataGridView.Show();
				fileManager.read_file(dataGridView);
			}
			else dataGridView.Hide();
		}
	}
}
