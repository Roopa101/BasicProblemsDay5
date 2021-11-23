using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Year is a Leap Year", +year);
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year", +year);
            }
            Console.ReadLine();
        }
    }
}
    
