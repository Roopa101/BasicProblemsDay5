using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class PowerOf2
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. between 1 to 31");
            int Number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("2^" + i + "=" + Math.Pow(2, i));
            }
            Console.ReadLine();
        }
    }
}
    