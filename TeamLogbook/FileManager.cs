using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; // для формата XLSX
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Reflection;
using DocumentFormat.OpenXml.Spreadsheet;


namespace TeamLogbook
{
	internal class FileManager
	{
		private static string filePath;
		DBController dbController = new DBController();

		public FileManager(string path)
		{
			filePath = path;
		}

		public void read_file(DataGridView dataGridView, string group="", string subject="", string name="")
		{
			// Очищаем dataGridView
			dataGridView.Rows.Clear();
			dataGridView.Columns.Clear();

			// Открываем файл
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				IWorkbook workbook = new XSSFWorkbook(fileStream);

				ISheet sheet = workbook.GetSheetAt(0);

				IRow firstRow = sheet.GetRow(0);
				if (firstRow != null)
				{
					// Проходимся по ячейкам первой строки и добавляем их в DataGridView как столбцы
					foreach (ICell cell in firstRow.Cells)
					{
						string cellValue = cell.ToString();
						dataGridView.Columns.Add(cellValue, cellValue);
					}

					// Проходимся по остальным строкам (начиная со второй)
					for (int rowIdx = 1; rowIdx <= sheet.LastRowNum; rowIdx++)
					{
						IRow row = sheet.GetRow(rowIdx);
						if (row != null)
						{
							// Создаем строку для DataGridView
							DataGridViewRow dataGridViewRow = new DataGridViewRow();
							// Проходимся по ячейкам в строке и добавляем их в DataGridView как значения в столбцах
							foreach (ICell cell in row.Cells)
							{
								string cellValue = cell.ToString();
								dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell { Value = cellValue });
							}
							// Добавляем созданную строку в DataGridView
							dataGridView.Rows.Add(dataGridViewRow);
							
						}
					}
				}
			}
		}


		public string[] getFileInfo()
		{
			if (File.Exists(filePath))
			{

				FileInfo fileInfo = new FileInfo(filePath);

				string fileName = fileInfo.Name; // Название файла
				DateTime lastModified = fileInfo.LastWriteTime; // Последняя дата редактирования файла
				return new string[2] { fileName, lastModified.ToString() };
			}
			else
			{
				return new string[2];
			}
		}

		public void ExportToExcel(DataGridView dataGridView)
		{
			using (var workbook = new XLWorkbook())
			{
				var worksheet = workbook.Worksheets.Add("Sheet1");

				// Добававление заголовков столбцов в первую строку
				for (int col = 1; col <= dataGridView.Columns.Count; col++)
				{
					worksheet.Cell(1, col).Value = dataGridView.Columns[col - 1].HeaderText;
				}

				// Заполнение данными из DataGridView
				for (int row = 0; row < dataGridView.Rows.Count; row++)
				{
					for (int col = 0; col < dataGridView.Columns.Count; col++)
					{
						if (dataGridView.Rows[row].Cells[col].Value != null)
							worksheet.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value.ToString();
					}
				}

				// Сохранение книги в файл
				workbook.SaveAs(filePath);
			}
		}
	}
}
