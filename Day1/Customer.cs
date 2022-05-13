using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Customer : Account
    {
        public DateTime DOB { get; set; }

        public string Name { get; set; }

        public Customer()
        {
        }

        public Customer(string username, string password, string name, DateTime dOB)
            : base(password, username)
        {
            DOB = dOB;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"Employee: {base.ToString()} - {Name} - {DOB.ToShortDateString()}";
        }

        public override void Input()
        {
            Console.WriteLine("Input Customer's info:");
            base.Input();
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("DOB:");
            DOB = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
