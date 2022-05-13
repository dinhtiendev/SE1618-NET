using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Employee : Account
    {
        public string Role { get; set; }

        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string username, string password, double salary, string role)
            : base(password, username)
        {
            Role = role;
            Salary = salary;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"Employee: {base.ToString()} - {Salary} - {Role}";
        }

        public override void Input()
        {
            Console.WriteLine("Input Employee's info:");
            base.Input();
            Console.WriteLine("Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Role:");
            Role = Console.ReadLine();
        }
    }
}
