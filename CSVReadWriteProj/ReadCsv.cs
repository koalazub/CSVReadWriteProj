using System;
using System.IO;

namespace CSVReadWriteProj
{
    public static class ReadCsv
    {
        // ReSharper disable once InconsistentNaming
        private const string _getFilePath =
            "C:\\Users\\elali\\RiderProjects\\CSVReadWriteProj\\CSVReadWriteProj\\koala.txt";

        public static string GetFilePath => _getFilePath;


        public static string[] ReadRecord(string searchTerm, string filePath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = {"Record not found"};

            try
            {
                var lineOfFile = File.ReadAllLines(_getFilePath);
                foreach (var line in lineOfFile)
                {
                    var fields = line.Split(',');
                    if (RecordMatch(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Found the record!!");
                        return fields;
                    }
                }

                return recordNotFound;
            }
            catch
            {
                Console.WriteLine("Program fucked out");
                return recordNotFound;
            }
        }

        public static bool RecordMatch(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm)) return true;

            return false;
        }
    }
}