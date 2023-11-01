using System;
using System.Data;
using System.Data.OleDb;
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
		}

		private void btn_top_Click(object sender, EventArgs e)
		{
			if (dataGridView.RowCount > 0)
			{
				dataGridView.FirstDisplayedScrollingRowIndex = 0;
				dataGridView.Rows[0].Selected = true;
			}
		}

		private void btn_bottom_Click(object sender, EventArgs e)
		{
			if (dataGridView.RowCount > 0)
			{
				int lastIndex = dataGridView.RowCount - 1;
				dataGridView.FirstDisplayedScrollingRowIndex = lastIndex;
				dataGridView.Rows[lastIndex].Selected = true;
			}
		}
	}
}
