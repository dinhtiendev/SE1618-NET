using System;
using System.IO;

namespace DemoFileIO
{
    internal class Department
    {
        
        public string Position { get; set; }
        public string ID { get; set; }

        public int Password { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }

        public string Time { get; set; }

        public string Role { get; set; }

        public Department()
        {
        }

        public Department(string position, string iD, int password)
        {
            Position = position;
            ID = iD;
            Password = password;
        }

        public Department(string position, string iD, int password, string name, DateTime doB) : this(position, iD, password)
        {
            Name = name;
            DoB = doB;
        }

        public Department(string position, string iD, int password, string time, string role) : this(position, iD, password)
        {
            Time = time;
            Role = role;
        }

        public void ReadFromFile(string FileName)
        {
            if (File.Exists(FileName))
            {
                string[] a = File.ReadAllLines(FileName);
                
            }
            else
            {
                Console.WriteLine("Can't find this file: " + FileName);

            }


        }
        public void WriteFromFile(string FileName)
        {

        }
    }
}
