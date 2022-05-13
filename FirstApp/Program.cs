using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 12;//setter
            Console.WriteLine(student.Id);//getter

            Student foreignStudent = new ForeignStudent(12, "Tien", new DateTime(2001, 1, 12), "ninhbinh", "vietnam");
            foreignStudent.Display();
        }
    }
}
