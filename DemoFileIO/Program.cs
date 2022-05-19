using System;
using System.Collections.Generic;

namespace DemoFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> list = new List<Department>();
            list.Add(new Department("Account", "trungnb", 123456));
            list.Add(new Department("Employee", "hangnt", 123456, "12s00", "admin"));
            list.Add(new Department("Account", "annb", 123456));
            list.Add(new Department("Account", "vuongvt", 123456));
            list.Add(new Department("Customer", "thaonh", 1234, "Nguyen Huong Thao", new DateTime(12, 8, 2000)));
            list.Add(new Department("Employee", "thangtt", 123456, "1400", "mod"));

        }
    }
}
