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
            var sortAscending = from month in Months
                                orderby month
                                select month;
            var sortDescending = from month in Months orderby month descending select month;
            Console.WriteLine("*****Ascending*****");
            foreach (var c in sortAscending)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\n*****Descending*****");
            foreach (var c in sortDescending)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
