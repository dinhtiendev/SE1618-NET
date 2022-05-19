using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Account : IComparable<Account>
    {
        public string password { get; set; }
        public string username { get; set; }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public override bool Equals(object obj)
        {
            return obj is Account account && password.Equals(account.password) && username.Equals(account.username);
        }

        public override string ToString()
        {
            return $"Account: {username} - {password}";
        }

        public virtual void Input()
        {
            Console.WriteLine("Username");
            password = Console.ReadLine();
            Console.WriteLine("Password");
            username = Console.ReadLine();
        }

        public int CompareTo(Account other)
        {
            return username.CompareTo(other.username);
        }
    }
}
