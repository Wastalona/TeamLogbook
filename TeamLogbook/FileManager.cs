using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TeamLogbook
{
	internal class FileManager
	{
		private static string filePath;

		public FileManager(string path)
		{
			filePath = path;
		}
	
		public static void read()
		{
			try
			{
				using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				using (StreamReader streamReader = new StreamReader(fileStream))
				{
					string content = streamReader.ReadToEnd();
					Console.WriteLine("File content:");
					Console.WriteLine(content);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("An error occurred while reading the file: " + e.Message);
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
