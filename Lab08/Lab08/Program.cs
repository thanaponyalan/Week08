using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            Student[] student = new Student[31];
            Console.WriteLine(data.Length);
            Console.WriteLine(student.Length);
            Console.ReadLine();
        }
        class Student     // nested class
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

    }
}
