using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Account
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
            return base.Equals(obj);
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
    }
}
