using System;
using System.Collections.Generic;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Account a = new Account("chilp", "123456");
            Console.WriteLine("Account: ");
            Console.WriteLine(a);
            Console.WriteLine();

            Employee e1 = new Employee("trungnb", "123457", 1200.4, "Admin");
            Employee e2 = new Employee();
            Console.WriteLine("Input Employee's info:");
            e2.Input();
            Console.WriteLine($"Employee: {e1}");
            Console.WriteLine($"Employee: {e2}");
            Console.WriteLine();

            Customer c1 = new Customer("trungnb", "123457", "Bao Trung", new DateTime(1987, 12, 1));
            Customer c2 = new Customer();
            Console.WriteLine("Input Customer's info:");
            c2.Input();
            Console.WriteLine($"Customer: {c1}");
            Console.WriteLine($"Customer: {c2}");
            Console.ReadLine();
            */
            
            Department department = new Department();
            department.AddAccount(new Account("12", "23"));
            department.AddAccount(new Account("1234", "2345"));
            department.AddAccount(new Account("12345", "23456"));
            department.AddAccount(new Account("123", "234"));
            department.Display();
            department.RemoveAccount(new Account("1234", "2345"));
            department.Display();
            department.Sort();
            department.Display();
            department.SortByDescUsername();
            department.Display();
        }

    }
}
