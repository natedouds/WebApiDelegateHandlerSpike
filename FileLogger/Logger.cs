using System.Configuration;
using System.IO;

namespace FileLogger
{
    public class Logger
    {
        //Method to create file
        public void CreateFile(string directory, string file)
        {
            //Create directory (only creates if doesn't exist)
            var di = new DirectoryInfo(directory);
            di.Create();

            //Create a file to write to
            using (StreamWriter sw = File.AppendText(directory + file))
            {
                sw.WriteLine("Hello World!");
            }
        }
    }
}
