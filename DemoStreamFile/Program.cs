using System;
using System.IO;

namespace DemoStreamFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\Ky5\PRN211\Exercise\DemoStreamFile\MyTest.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is some text");
                    sw.WriteLine("to test");
                    sw.WriteLine("reading");
                }

                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
    }
}
