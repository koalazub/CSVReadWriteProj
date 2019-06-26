using System;
using System.Diagnostics;

namespace CSVReadWriteProj
{
    public static class FileFunctions
    {
        public static void LaunchAssociatedFile(string fileName)
        {
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));

            fileName = ReadCsv.GetFilePath;
            var processStartInfo = new ProcessStartInfo(fileName);
            var fileProcess = new Process();
            processStartInfo.UseShellExecute = true;
            fileProcess.StartInfo = processStartInfo;
            try
            {
                fileProcess.Start();
                Console.WriteLine("File executed");
            }
            catch
            {
                Console.WriteLine("failed to launch file");
            }
        }
    }
}