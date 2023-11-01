using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TeamLogbook
{
	public partial class Progress : Form
	{
		public Progress()
		{
			InitializeComponent();
		}

		private void Progress_Load(object sender, EventArgs e)
		{
			DBController db_controller = new DBController();
			DataSet ds = new DataSet();

			db_controller.openConnection();

			using (OleDbConnection connection = new OleDbConnection(db_controller.connectionString))
			{
				connection.Open();
				string query = "SELECT [Student], [Lesson], [Group], AVG([Mark]) AS AverageMark FROM Marks GROUP BY [Student], [Lesson], [Group]";
				using (OleDbCommand cmd = new OleDbCommand(query, connection))
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
	}
}
