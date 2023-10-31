using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using NPOI.OpenXmlFormats.Dml.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
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
				using (OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT [Student], [Lesson], [MarkDate], [Mark], [Miss], [Group] FROM Marks", connection))
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
	}
}
