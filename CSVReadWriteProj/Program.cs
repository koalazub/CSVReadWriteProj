using System;
using System.Collections.Generic;

namespace CSVReadWriteProj
{
    internal static class Program
    {
        private static string _filePath;
        private static string _inputString;
        private static List<string> _dataInput = new List<string>(2);

        public static void Main(string[] args)
        {
            Console.WriteLine("this is a CSV Reader and Writer Program");
            _filePath = WriteCsv.GetFilePath();
            ReadOrWriteDecision();
            FileFunctions.LaunchAssociatedFile(_filePath);
        }

        private static void LoopDataEntry(bool isDone)
        {
            while (isDone)
            {
                Console.WriteLine("Enter name");
                var inputName = Console.ReadLine();
                Console.WriteLine("Enter Age");
                var inputAge = Console.ReadLine();
                WriteCsv.AddRecord(WriteCsv.AppendToRecordIDList(), inputName, inputAge, _filePath);

                Console.WriteLine("Would you like to add more data?");
                Console.WriteLine("'n' or 'no to discontinue");
                var continueInput = Console.ReadLine();
                if (continueInput == "n" || continueInput == "no")
                    isDone = false;
                else
                    Console.WriteLine("Continuing Input");
            }
        }

        private static void ReadOrWriteDecision()
        {
            Console.WriteLine("Press 1 to search for a field");
            Console.WriteLine("Press 2 to input data");
            var valueEntered = Console.ReadLine();
            var decisionMade = int.TryParse(valueEntered, out var decision);
            if (!decisionMade) return;

            Console.WriteLine(decision);
            switch (decision)
            {
                case 1:
                    Console.WriteLine("reading CSV");
                    _inputString = Console.ReadLine();
                    Console.WriteLine(string.Join("", ReadCsv.ReadRecord(_inputString, _filePath, 2)));
                    break;
                case 2:
                    LoopDataEntry(true);
                    break;

                default:
                    Console.WriteLine("enter the values listed");
                    break;
            }
        }
    }
}