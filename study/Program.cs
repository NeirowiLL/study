using System;

namespace study
{
    public static class Program
    {
        public static void Main()
        {
            var service = new DataRepository("Data.txt");

            service.Save("Dima");
            service.Save("Andrey");

            //get data

            var names = service.ReadDataFromFile();

            //foreach print data

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}