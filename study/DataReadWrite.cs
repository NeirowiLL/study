using System;
namespace study
{
	public class DataReadWrite
	{
		private string filePath;

		public DataReadWrite(string filePath)
		{
			this.filePath = filePath;
		}

		public void SaveDataToFile(string data)
		{
			using (StreamWriter sw = new StreamWriter(filePath))
			{
				sw.Write(data);
			}
		}
		public string[] ReadDataFromFile()
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				string content = sr.ReadToEnd();

				return content.Split();
			}
		}
	}
}

