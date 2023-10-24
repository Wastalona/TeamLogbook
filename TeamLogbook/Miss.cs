using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Functions;

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
			string path = db_controller.get_value_from_db("CurrentFile");

			if (path.Length > 0)
			{
				FileManager fileManager = new FileManager(path);
				dataGridView.Show();
				fileManager.read_file(dataGridView, "", "", "");

				int miss_amount = 0; string value = ""; 
				
				int currentMonth = DateTime.Now.Month;

				// Перебор строк и столбцов DataGridView
				for (int row = 0; row < dataGridView.Rows.Count; row++)
				{
					for (int col = 0; col < dataGridView.Columns.Count; col++)
					{
						int dateIndex = col+3;
						// Проверка на null перед получением значения
						if (dataGridView.Rows[row].Cells[col].Value != null)
						{
							value = dataGridView.Rows[row].Cells[col].Value.ToString(); // значение
							string fDate = Regex.Replace(dataGridView.Rows[0].Cells[col].Value.ToString(), @"(\d+)\.(\d+)\.(\d+)", "$3.$2.$1");
							MessageBox.Show(dataGridView.Rows[0].Cells[col].Value.ToString());
							DateTime date = new DateTime(fDate[0]+ fDate[1] + fDate[2] + fDate[3], fDate[5] + fDate[6], fDate[8] + fDate[9]);
							int checkedMonth = date.Month;
							string dateString = dataGridView.Rows[0].Cells[col].Value.ToString();
							if (value == "н.а" && currentMonth == checkedMonth) miss_amount++;
						}
					}
				}


				// Перебор и удаление лишних столбцов DataGridView
				int end = dataGridView.Columns.Count;
				for (int i = 3; i < end; i++)
				{
					dataGridView.Columns.RemoveAt(3);
				}

				MessageBox.Show("Missing Amount: " + miss_amount);
			}
			else dataGridView.Hide();
		}
	}
}
