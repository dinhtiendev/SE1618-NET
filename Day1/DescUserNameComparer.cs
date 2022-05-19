using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class DescUserNameComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return -x.username.CompareTo(y.username);
        }
    }
}
