using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using NPOI.OpenXmlFormats.Dml.Chart;
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
	public partial class Progress : Form
	{
		public Progress()
		{
			InitializeComponent();
		}

		private void Progress_Load(object sender, EventArgs e)
		{
			dataGridView.Hide();
			DBController db_controller = new DBController();
			string path = db_controller.get_value_from_db("CurrentFile");

			FileManager fileManager = new FileManager(path);
			fileManager.read_file(dataGridView, "", "", "");

			double mark = 0; int amount = 0;

			// Перебор строк и столбцов DataGridView
			for (int row = 0; row < dataGridView.Rows.Count; row++)
			{
				for (int col = 0; col < dataGridView.Columns.Count; col++)
				{
					int dateIndex = col + 3;
					// Проверка на null перед получением значения
					if (dataGridView.Rows[row].Cells[col].Value != null)
					{
						string value = dataGridView.Rows[row].Cells[col].Value.ToString(); // значение
						if (value != "н")
						{
							mark++;
							amount++;
						}
					}
				}
				mark = Math.Round(mark/amount, 2);
			}

			// Перебор и удаление лишних столбцов DataGridView
			/*int end = dataGridView.Columns.Count;
			for (int i = 3; i < end; i++)
			{
				dataGridView.Columns.RemoveAt(3);
			}*/

			// Добавляем столбец "Количество пропусков"
			dataGridView.Columns.Add("Количество пропусков", "Количество пропусков");

			// Заполняем столбец данными
			MessageBox.Show(mark.ToString());
		}
	}
}
