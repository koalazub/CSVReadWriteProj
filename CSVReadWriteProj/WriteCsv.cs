using System;
using System.IO;

namespace CSVReadWriteProj
{
    public static class WriteCsv
    {
        private static string _filePath;

        public static string GetFilePath()
        {
            _filePath = ReadCsv.GetFilePath;

            return _filePath;
        }

        public static void AddRecord(int iD, string name, string age, string filePath)
        {
            try
            {
                using (var file = new StreamWriter(filePath, true))
                {
                    //TODO sort through ID's and append to last in list
                    file.WriteLine(iD + "," + name + "," + age);
                }
            }
            catch
            {
                throw new ApplicationException("Something went wrong. Check what you've entered");
            }
        }

        // ReSharper disable once InconsistentNaming
        public static int AppendToRecordIDList()
        {
            Console.WriteLine("Incrementing record");
            try
            {
                var iDField = File.ReadAllLines(_filePath);
                var iDIndex = iDField.Length + 1;
                return iDIndex;
            }
            catch
            {
                Console.WriteLine("Wasn't able to increment ID field");
                return 0;
            }
        }
    }
}