using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TeamLogbook
{
	internal class DBController
	{
		private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database.mdb";
		private OleDbConnection myConnection = new OleDbConnection(connectString);

		public static string HashPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return Convert.ToBase64String(hashedBytes);
			}
		}

		public void openConnection()
		{
			myConnection.Open();
		}

		public void closeConnection()
		{
			myConnection.Close();
		}

		public bool isLocalSecure()
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
		{
			if (password.Length == 4)
			{
				string hashedInputPassword = HashPassword(password);

				openConnection();

				try
				{
					using (OleDbCommand dbCmd = new OleDbCommand("SELECT Password FROM Config WHERE id=1;", myConnection))
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

		public void SaveAutosavesSettings(bool isActive, string path)
		{
			if (string.IsNullOrEmpty(path))
				path = ".\\autosaves";

			openConnection();

			try
			{
				OleDbCommand dbCmd = new OleDbCommand("UPDATE Config SET Autosaves = @Autosaves, SavePath = @SavePath WHERE id=1", myConnection);
				dbCmd.Parameters.AddWithValue("@Autosaves", isActive);
				dbCmd.Parameters.AddWithValue("@SavePath", path);
				dbCmd.ExecuteNonQuery();
			}
			catch (Exception ex) { MessageBox.Show("Произошла ошибка при сохранении настроек: " + ex.Message); }
			finally { closeConnection(); }
		}
	}
}
