using System;
using System.IO;    

namespace Slot5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string dir = @Console.ReadLine();
            string dir = @"H:\Book4";
            if (!Directory.Exists(dir)) 
            {
                Console.WriteLine("Diratory don't exist. Create diratory!");
                Directory.CreateDirectory(dir);
            }
            try
            {
                using StreamWriter sw = File.CreateText(dir + "\\data.txt");
                sw.WriteLine(Console.ReadLine());
                sw.Close();
                Console.WriteLine("Do you want to copy file in D: (No = 0)");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    var txtFiles = Directory.EnumerateFiles(dir, "data.txt");

                    foreach (string s in txtFiles)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        var fileName = Path.GetFileName(s);
                        var destFile = Path.Combine(@"H:\Book1", fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
