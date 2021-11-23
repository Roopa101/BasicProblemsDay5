using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class HarmonicNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the last harmonic number");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicSum = 0;
            for (double i = 1; i <= num; i++)
            {
                Console.WriteLine("1/" + i + "=" + (1 / i));
                harmonicSum += (1 / i);
            }
            Console.WriteLine("The Sum of harmonic number is :" + harmonicSum);
            Console.ReadLine(); 
        }

    }
}
