using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
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
	public partial class Report : Form
	{
		private DataTable table;

		public Report()
		{
			InitializeComponent();
		}

		private void Report_Load(object sender, EventArgs e)
		{
			DBController db_controller = new DBController();
			DataSet average_ds = new DataSet();

			using (OleDbConnection connection = new OleDbConnection(db_controller.connectionString))
			{
				connection.Open();
				string query = "SELECT [Student], [Lesson], [Group], ROUND(AVG([Mark]), 2) AS AverageMark, COUNT([Mark]) AS Miss FROM Marks GROUP BY [Student], [Lesson], [Group]";
				using (OleDbCommand cmd = new OleDbCommand(query, connection))
				{
					using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd))
					{
						dataAdapter.Fill(average_ds);
						//dataGridView.DataSource = average_ds.Tables[0];
						table = average_ds.Tables[0];
					}
				}
			}

			var uniqueGroups = table.AsEnumerable().Select(row => row.Field<string>("Group")).Distinct().ToList();
			var uniqueSubjects = table.AsEnumerable().Select(row => row.Field<string>("Lesson")).Distinct().ToList();
			
			ChartValues<double> values = new ChartValues<double>(); // все средние баллы по группам

			// Пройдитесь по всем уникальным группам и предметам
			foreach (string gr in uniqueGroups)
			{
				double all_sum = 0;
				foreach (string sj in uniqueSubjects)
				{
					double sum = table.AsEnumerable().Where(row => row.Field<string>("Lesson") == sj && row.Field<string>("Group") == gr).Sum(row => row.Field<double>("AverageMark"));
					all_sum += sum;
				}
				values.Add(Math.Round(all_sum/ uniqueSubjects.Count, 2));
			}

			// найтройка и загрузка данных в pieChart 
			pieChart.LegendLocation = LegendLocation.Bottom;

			SeriesCollection collections = new SeriesCollection();

			for (int i = 0; i < uniqueGroups.Count; i++)
			{
				PieSeries pie = new PieSeries
				{
					Title = uniqueGroups[i],
					Values = new ChartValues<double> { values[i] },
					DataLabels = true,
				};
				collections.Add(pie);
			}
			
			pieChart.Series = collections;
		}

	}
}
