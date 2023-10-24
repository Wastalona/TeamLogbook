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
				try
				{
					fileManager.read_file(dataGridView);
				}
				catch (System.IO.IOException){
					MessageBox.Show("Убедитесь, что файл не открыт в другой программе", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				} 
			}
			else dataGridView.Hide();
		}

		private void btn_add_col_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			string date = now.Day.ToString() + "." + now.Month.ToString() + "." + now.Year.ToString();
			dataGridView.Columns.Add(date, date);
		}

		private void btn_delete_col_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Вы действительно хотите удалить столбец", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.OK)
			{
				if (dataGridView.Columns.Count > 0)
					dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
				else
					MessageBox.Show("Больше удалять нечего", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			}
		}
	}
}
