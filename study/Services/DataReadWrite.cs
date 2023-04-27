using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace study
{
	public class DataRepository
	{
		private string filePath;

		public DataRepository(string filePath)
		{
			this.filePath = filePath;
		}

		public void Save(string data)
        {
			//get current data from file
			List<string> currentData = ReadDataFromFile();

			//Add to current data new data

			currentData.Add(data);
			var fullData = currentData;

			//save full data

			var fullDataOneString = FromListToString(fullData);

            SaveToFile(fullDataOneString);
        }

        private void SaveToFile(string data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(data);
            }
        }

		private string FromListToString(List<string> list)
        {
            var oneString = "";

			var coollection = list.Where(el => el != "");
            foreach (var element in coollection)
            {
                oneString += "\n";
                oneString += element;
            }

            return oneString;
        }

        public List<string> ReadDataFromFile()
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				string content = sr.ReadToEnd();

				return content.Split().ToList();
			}
		}
	}
}

