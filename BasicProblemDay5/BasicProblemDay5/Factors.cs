using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class Factors
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please Enter the number: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
           
            Console.ReadLine();
        }
    }
}
