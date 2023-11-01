using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
			DataSet ds = new DataSet();

			db_controller.openConnection();

			using (OleDbConnection connection = new OleDbConnection(db_controller.connectionString))
			{
				connection.Open();
				using (OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT [Student], [Lesson], [Group], [MarkDate], [Mark]  FROM Marks", connection))
				{
					using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd))
					{
						dataAdapter.Fill(ds);
						dataGridView.DataSource = ds.Tables[0];
					}
				}
			}

			db_controller.closeConnection();

			string path = db_controller.get_value_from_db("CurrentFile");
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
