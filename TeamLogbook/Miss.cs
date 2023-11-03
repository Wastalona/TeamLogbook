using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using MathNet.Numerics.Distributions;

namespace TeamLogbook
{
	public partial class Miss : Form
	{
		public Miss()
		{
			InitializeComponent();
		}

		private void Miss_Load(object sender, EventArgs e)
		{
			DBController db_controller = new DBController();
			DataSet ds = new DataSet();

			using (OleDbConnection connection = new OleDbConnection(db_controller.connectionString))
			{
				connection.Open();
				string query = "SELECT DISTINCT [Student], [Lesson], [Group], COUNT([Mark]) AS Miss FROM Marks WHERE [Mark] = -1 GROUP BY [Student], [Lesson], [Group]";
				using (OleDbCommand cmd = new OleDbCommand(query, connection))
				{
					using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd))
					{
						dataAdapter.Fill(ds);
						dataGridView.DataSource = ds.Tables[0];
					}
				}
			}
		}
	}
}
