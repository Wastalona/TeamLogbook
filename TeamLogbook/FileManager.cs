using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; // для формата XLSX
using System.IO;
using System.Windows.Forms;


namespace TeamLogbook
{
	internal class FileManager
	{
		private static string filePath;

		public FileManager(string path)
		{
			filePath = path;
		}

		public void read_file(DataGridView dataGridView)
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


		public static void write()
		{
			string contentToWrite = "This is the content to write to the file.";

			try
			{
				using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
				using (StreamWriter streamWriter = new StreamWriter(fileStream))
				{
					streamWriter.Write(contentToWrite);
					Console.WriteLine("File saved successfully.");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("An error occurred while saving the file: " + e.Message);
			}
		}
	}

}
