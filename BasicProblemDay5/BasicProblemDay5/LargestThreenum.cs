using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class LargestThreeNumbers
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number 1 is greater" +num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number 2 is greater" +num2);
            }
            else
            {
                Console.WriteLine("Number 3 is greater" +num3);
            }

            Console.ReadLine();
        }
    }
}