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

				int[] miss = new int[dataGridView.Rows.Count];

				// Перебор строк и столбцов DataGridView
				for (int row = 0; row < dataGridView.Rows.Count; row++)
				{
					int miss_amount = 0;
					for (int col = 0; col < dataGridView.Columns.Count; col++)
					{
						int dateIndex = col + 3;
						// Проверка на null перед получением значения
						if (dataGridView.Rows[row].Cells[col].Value != null)
						{
							string value = dataGridView.Rows[row].Cells[col].Value.ToString(); // значение
							if (value == "н.а") miss_amount++;
						}
					}
					miss[row] = miss_amount;
				}

				// Перебор и удаление лишних столбцов DataGridView
				int end = dataGridView.Columns.Count;
				for (int i = 3; i < end; i++)
				{
					dataGridView.Columns.RemoveAt(3);
				}

				// Добавляем столбец "Количество пропусков"
				dataGridView.Columns.Add("Количество пропусков", "Количество пропусков");

				// Заполняем столбец данными
				for (int row = 0; row < dataGridView.Rows.Count; row++)
				{
					dataGridView.Rows[row].Cells["Количество пропусков"].Value = miss[row];
				}


				
			}
			else dataGridView.Hide();
		}
	}
}
