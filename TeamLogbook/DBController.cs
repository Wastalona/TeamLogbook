using MySqlX.XDevAPI.Common;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
				string query = "INSERT INTO Marks ([Student], [Lesson], [MarkDate], [Mark], [Miss], [Group]) VALUES (@Student, @Lesson, @MarkDate, @Mark, @Miss, @Group);";
				OleDbCommand dbCmd = new OleDbCommand(query, myConnection);
				dbCmd.Parameters.AddWithValue("@Student", record.Name);
				dbCmd.Parameters.AddWithValue("@Lesson", record.Lesson);
				dbCmd.Parameters.AddWithValue("@MarkDate", record.Date);
				dbCmd.Parameters.AddWithValue("@Mark", record.Mark);
				dbCmd.Parameters.AddWithValue("@Miss", record.Miss);
				dbCmd.Parameters.AddWithValue("@Group", record.Group);

				dbCmd.ExecuteNonQuery();
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
						db_str.Group = sheet.GetRow(rowIdx).GetCell(0)?.ToString() ?? "";
						db_str.Lesson = sheet.GetRow(rowIdx).GetCell(1)?.ToString() ?? "";
						db_str.Name = sheet.GetRow(rowIdx).GetCell(2)?.ToString() ?? "";
						IRow row = sheet.GetRow(rowIdx);
						int rows = Int32.Parse(sheet.GetRow(rowIdx).PhysicalNumberOfCells.ToString());
						if (row != null)
						{
							// Создаем строку для DataGridView
							DataGridViewRow dataGridViewRow = new DataGridViewRow();

							for (int i = 3; i < rows; i++)
							{
								db_str.Date = sheet.GetRow(0).Cells[i].ToString();
								if (row.Cells[i].ToString() == "н")
									db_str.Miss = 1;
								else
									db_str.Mark = int.TryParse(row.Cells[i].ToString(), out int mark) ? mark : 0; ;
								insert_mark(db_str);
							}
						}
					}
				}
			}
		}
	}
}
