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

		public void closeConnection() { 
			myConnection.Close();
		}

		public bool isLocalSecure()
		{
			openConnection();
			try
			{
				using (OleDbCommand command = new OleDbCommand("SELECT isActive FROM LocalSecure WHERE id=1", myConnection))
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

    }
}
