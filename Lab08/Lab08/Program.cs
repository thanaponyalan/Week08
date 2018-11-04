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
            double[] GPS = new double[8];
            double[] tmpGPS = new double[8];
            double[] Weight = new double[8];

            for (int i=0;i<GPS.Length;i++)
            {
                Console.Write("Enter semester {0}'s GPS : ",i+1);
                GPS[i] = double.Parse(Console.ReadLine());
                Console.Write("Enter semester {0}'s Weight : ",i+1);
                Weight[i] = double.Parse(Console.ReadLine());
                tmpGPS[i] = GPS[i] * Weight[i];
            }
            double GPA = tmpGPS.Sum() / Weight.Sum();
            int j = 0;
            foreach (double g in GPS)
            {
                j++;
                Console.WriteLine("Semester {0} GPS is {1:F2}",j,g);
            }
            Console.WriteLine("GPA : {0:F2} ",GPA);
            Console.ReadKey();

        }
    }
}
