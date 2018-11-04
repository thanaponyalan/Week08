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
            int[] firstDateofMonth = new int[12] {1,4,4,0,2,5,0,3,6,1,4,6};
            string[] dayInWeek = new string[7] {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

            int Day;
            int Month;

            Console.Write("Enter month of day [1-12] : ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Enter date of day : ");
            Day = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/{1}/2018 is "+dayInWeek[((Day+firstDateofMonth[Month-1])-1)%7],Day,Month);
            Console.ReadKey();
        }
    }
}
