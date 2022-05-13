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
            throw new NotImplementedException();
        }

        
    }
}
