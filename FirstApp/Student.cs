using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Student
    {
        //field
        private int id;
        private string name;

        //property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime dob { get; set; }

        public string address { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, DateTime dob, string address)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.address = address;
        }

        public virtual void Display()
        {
            //Console.WriteLine(string.Format("Student: {0}-{1}-{2}-{3}"), id, name, dob, address);
            Console.WriteLine($"Student:{id}-{name}-{dob}-{address}");
        }
    }

    class ForeignStudent : Student
    {
        public string Country { get; set; }

        public ForeignStudent()
        {
        }

        public ForeignStudent(int id, string name, DateTime dob, string address, string country) 
            : base(id, name, dob, address)
        {
            Country = country;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"-{Country}");
        }
    }
}
