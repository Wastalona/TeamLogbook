using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TeamLogbook
{
	internal class DBController
	{
		private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database.mdb";
		private OleDbConnection myConnection = new OleDbConnection(connectString);

		public string HashPassword(string password)
		/*
			Хэширование пароля 
		*/
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return Convert.ToBase64String(hashedBytes);
			}
		}

		public string connectionString
		{
			get { return connectString; }
		}

		public void openConnection()
		/*
			Открытие соединения
		*/
		{
			myConnection.Open();
		}

		public void closeConnection()
		/*
			Закрытие соединения
		*/
		{
			myConnection.Close();
		}

		public bool isLocalSecure()
		/*
			Проверяет наличие локального пароля
		*/
		{
			openConnection();
			try
			{
				using (OleDbCommand command = new OleDbCommand("SELECT isActive FROM Config WHERE id=1", myConnection))
				{
					object result = command.ExecuteScalar();
					if (result != null && result != DBNull.Value)
					{
						return Convert.ToBoolean(result);
					}
					else
					{
						throw new InvalidOperationException("Невозможно получить действительный результат для локальной системы безопасности.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("При проверке локальной безопасности произошла ошибка: " + ex.Message);
				return false;
			}
			finally
			{
				closeConnection();
			}
		}

		public bool CheckPassword(string password)
		/*
			Проверка пароля
		*/
		{
			if (password.Length == 4)
			{
				string hashedInputPassword = HashPassword(password);

				openConnection();

				try
				{
					using (OleDbCommand dbCmd = new OleDbCommand("SELECT PasswordHash FROM Config WHERE id=1;", myConnection))
					{
						// Выполняем запрос
						object result = dbCmd.ExecuteScalar();

						// Если результат не null
						if (result != null && result != DBNull.Value)
						{
							string hashedDbPassword = result.ToString();

							// Сравниваем хеши паролей
							return hashedInputPassword.Equals(hashedDbPassword);
						}
						else
						{
							throw new InvalidOperationException("Невозможно получить действительный результат для пароля.");
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Произошла ошибка при проверке пароля: " + ex.Message, "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				finally
				{
					closeConnection();
				}
			}
			else
				MessageBox.Show("Неверный пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);


			return false;
		}

		public void SaveAutosavesSettings(bool isActive, string path, string interval)
		/*
			Сохранение данных об автосохранениях с формы "Настройки"
		*/
		{
			if (string.IsNullOrEmpty(path))
				path = "C:\\";

			if (string.IsNullOrEmpty(interval) || (Int32.Parse(interval) < 0 && Int32.Parse(interval) > 120))
				path = "15";

			openConnection();

			try
			{
				OleDbCommand dbCmd = new OleDbCommand("UPDATE Config SET Autosaves = ?, SavePath = ?, Range = ? WHERE id=1", myConnection);
				dbCmd.Parameters.AddWithValue("@Autosaves", isActive);
				dbCmd.Parameters.AddWithValue("@SavePath", path);
				dbCmd.Parameters.AddWithValue("@Range", interval);
				dbCmd.ExecuteNonQuery();
				MessageBox.Show("Настройки сохранены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Произошла ошибка при сохранении настроек: " + ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				closeConnection();
			}
		}

		public string[] GetConfigData()
		/*
			Получение всех данных из бд об автосохранениях и паролях
		*/
		{
			List<string> retrievedValues = new List<string>();

			openConnection();

			try
			{
				OleDbCommand dbCmd = new OleDbCommand("SELECT * FROM Config WHERE id=1", myConnection);
				OleDbDataReader reader = dbCmd.ExecuteReader();

				if (reader.Read())
				{
					// Обработка полученных значений
					for (int i = 0; i < reader.FieldCount; i++)
					{
						string value = reader[i].ToString();
						retrievedValues.Add(value);
					}
				}
				else
					MessageBox.Show("Нет данных", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);

				reader.Close();
			}
			catch (Exception ex){ MessageBox.Show("Произошла ошибка загрузке формы: " + ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);}
			finally{ closeConnection(); }

			return retrievedValues.ToArray();
		}

		public bool update_config_value(string value, string column)
		{
			openConnection();
			try
			{
				OleDbCommand dbCmd = new OleDbCommand("UPDATE Config SET "+column+" = ? WHERE id=1", myConnection);
				dbCmd.Parameters.AddWithValue("@Val", value);
				dbCmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				closeConnection();
			}
		}

		public void insert_mark(Record record)
		{
			openConnection();
			try
			{
				// Проверка на существующие записи с таким же учеником, предметом и датой
				string checkQuery = "SELECT COUNT(*) FROM Marks WHERE [Student] = @Student AND [Lesson] = @Lesson AND [MarkDate] = @MarkDate";
				OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConnection);
				checkCmd.Parameters.AddWithValue("@Student", record.Name);
				checkCmd.Parameters.AddWithValue("@Lesson", record.Lesson);
				checkCmd.Parameters.AddWithValue("@MarkDate", record.Date);
				int count = Convert.ToInt32(checkCmd.ExecuteScalar());

				if (count == 0)
				{
					// Если совпадающих записей нет, выполняем вставку
					string insertQuery = "INSERT INTO Marks ([Student], [Lesson], [Group], [MarkDate], [Mark]) VALUES (@Student, @Lesson, @Group, @MarkDate, @Mark);";
					OleDbCommand dbCmd = new OleDbCommand(insertQuery, myConnection);
					dbCmd.Parameters.AddWithValue("@Student", record.Name);
					dbCmd.Parameters.AddWithValue("@Lesson", record.Lesson);
					dbCmd.Parameters.AddWithValue("@Group", record.Group);
					dbCmd.Parameters.AddWithValue("@MarkDate", record.Date);
					dbCmd.Parameters.AddWithValue("@Mark", record.Mark);
					
					dbCmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Произошла ошибка при загрузке в базу данных: " + ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				closeConnection();
			}
		}

		public string get_value_from_db(string column)
		{
			openConnection();
			string result = "";
			try
			{
				OleDbCommand dbCmd = new OleDbCommand("SELECT "+column+" FROM Config WHERE id=1", myConnection);
				using (OleDbDataReader reader = dbCmd.ExecuteReader())
				{
					if (reader.Read())
						result = reader[column].ToString();
				}
				return result;
			}
			catch (Exception ex)
			{
				return "Не удалось получить данные, ошибка:\n" + ex;
			}
			finally
			{
				closeConnection();
			}
		}


		public string[] get_values_from_db(string column, string table)
		{
			openConnection();

			string[] result = null;
			try {
				OleDbCommand dbCmd = new OleDbCommand("SELECT DISTINCT [" + column + "] FROM [" + table + "]", myConnection);
				List<string> data = new List<string>();

				OleDbDataReader reader = dbCmd.ExecuteReader();
				while (reader.Read())
				{
					data.Add(reader[column].ToString());
				}

				result = data.ToArray();

				return result;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Произошла ошибка при загрузке фильтров: " + ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				closeConnection();
			}
			return result;
		}

		
		public void save()
		{
			string filePath=get_value_from_db("CurrentFile");
			// Открываем файл
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				IWorkbook workbook = new XSSFWorkbook(fileStream);

				ISheet sheet = workbook.GetSheetAt(0);

				IRow firstRow = sheet.GetRow(0);
				if (firstRow != null)
				{
					// Проходимся по остальным строкам (начиная со второй)
					for (int rowIdx = 1; rowIdx <= sheet.LastRowNum; rowIdx++)
					{
						Record db_str = new Record();
						db_str.Group = sheet.GetRow(rowIdx).GetCell(2)?.ToString() ?? "";
						db_str.Lesson = sheet.GetRow(rowIdx).GetCell(1)?.ToString() ?? "";
						db_str.Name = sheet.GetRow(rowIdx).GetCell(0)?.ToString() ?? "";
						//db_str.Date = sheet.GetRow(rowIdx).GetCell(3)?.ToString() ?? "";
						string dateStr = sheet.GetRow(rowIdx).GetCell(3)?.ToString() ?? "";
						DateTime parsedDate;

						if (DateTime.TryParseExact(dateStr, "dd-MMM-yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
							db_str.Date = parsedDate;
						db_str.Mark = Int32.Parse(sheet.GetRow(rowIdx).GetCell(4)?.ToString() ?? "");
						insert_mark(db_str);
					}
				}
			}
		}

		public void apply_filters(DataGridView dg, string query, List<OleDbParameter> parameters, bool ans)
		{
			dg.Rows.Clear();
			dg.Columns.Clear();

			// Добавляем столбцы для DataGridView
			dg.Columns.Add("Группа", "Группа");
			dg.Columns.Add("Предмет", "Предмет");
			dg.Columns.Add("Учащийся", "Учащийся");
			dg.Columns.Add("Дата", "Дата");
			dg.Columns.Add("Оценка", "Оценка");

			openConnection();

			//try
			//{
			OleDbCommand dbCmd = new OleDbCommand(query, myConnection);
			if (ans)
			{
				dbCmd.Parameters.Add(parameters[0]);
				dbCmd.Parameters.Add(parameters[1]);
				dbCmd.Parameters.Add(parameters[2]);
			}


			OleDbDataReader reader = dbCmd.ExecuteReader();
			while (reader.Read())
			{
				string student = reader["Student"].ToString();
				string lesson = reader["Lesson"].ToString();
				string group = reader["Group"].ToString();
				string date = reader["MarkDate"].ToString();
				string mark = reader["Mark"].ToString();

				DataGridViewRow existingRow = null;

				// Если строка не найдена, создаем новую
				if (existingRow == null)
				{
					DataGridViewRow newRow = new DataGridViewRow();
					newRow.CreateCells(dg);
					newRow.Cells[0].Value = student;
					newRow.Cells[1].Value = group;
					newRow.Cells[2].Value = lesson;
					newRow.Cells[3].Value = date;
					newRow.Cells[4].Value = mark;
					existingRow = newRow;
					dg.Rows.Add(existingRow);
				}

				// Обновляем ячейку с оценкой в соответствии с датой
				existingRow.Cells[date].Value = mark;
			}


			reader.Close();
		}

		/*catch (Exception ex)
		{
			MessageBox.Show("Произошла ошибка при применении фильтров: " + ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			closeConnection();
		}*/
	}

}
//}
