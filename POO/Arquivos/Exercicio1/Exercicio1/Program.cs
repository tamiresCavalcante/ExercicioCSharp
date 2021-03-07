using System;
using System.IO;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"";
            string targetPath = @"";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
