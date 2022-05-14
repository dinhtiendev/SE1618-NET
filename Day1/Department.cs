using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Department : IDisplay
    {
        
        public string Name { get; set; }

        List<Account> accounts;

        public Department()
        {
            accounts = new List<Account>();
        }

        public Department(string name)
        {
            Name = name;
            accounts = new List<Account>();
        }

        public void AddAccount(Account c)
        {
            accounts.Add(c);
        }

        public void Display()
        {
            Console.WriteLine("Deoartment Name: " + Name);
            foreach (Account c in accounts)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public int GetNumberOfAccount()
        {
            return accounts.Count;
        }

        public void Input()
        {
            Console.WriteLine("Enter Department Name: ");
            Name = Console.ReadLine();
            int choice = 0;
            do
            {
                Console.WriteLine("Enter Account Username:");
                String Username = Console.ReadLine();
                Console.WriteLine("Enter Account Password:");
                String Password = Console.ReadLine();
                AddAccount(new Account(Username, Password));

                Console.WriteLine("Do you want to add more account(0: false):");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice == 0);
        }

        public void RemoveAccount(Account c)
        {
            accounts.Remove(c);
        }

        public void Sort()
        {
            accounts.Sort();
        }

        public void SortByType()
        {
            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
