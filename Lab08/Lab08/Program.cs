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
            string[] Months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string value1 = Months.Aggregate((a, b) => a.Length < b.Length ? a : b);
            string value2 = Array.Find(Months, element => element.Length > 10);
            string[] value3 = Array.FindAll(Months,element=>element.StartsWith(Months[0][0].ToString(),StringComparison.Ordinal));

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(String.Join(",",value3));
            Console.ReadKey();
        }
    }
}
