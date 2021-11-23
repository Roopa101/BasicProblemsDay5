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
            
            int fact = 1;
            int i;
            Console.WriteLine("Enter the input number:");
            int number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of" + number + "is  " + fact );
            Console.ReadLine();
        }
    }
}
    