using MySqlX.XDevAPI.Common;
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


		public void SaveNewPassword(string password)
		{
			if (!string.IsNullOrEmpty(password))
			{
				openConnection();

				try
				{
					OleDbCommand dbCmd = new OleDbCommand("UPDATE Config SET PasswordHash = ? WHERE id=1", myConnection);
					dbCmd.Parameters.AddWithValue("@Password", password);
					dbCmd.ExecuteNonQuery();
					MessageBox.Show("Настройки сохранены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Произошла ошибка при сохранении нового пароля: " + ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					closeConnection();
				}
			}
			else
				MessageBox.Show("Ошибка при записи пароля", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
