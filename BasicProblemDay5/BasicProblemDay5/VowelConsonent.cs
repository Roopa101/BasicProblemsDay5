using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class VowelConsonent
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Letter");
            char letter = Convert.ToChar(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("Letter is a Vowel" +letter);
            }
            else
            {
                Console.WriteLine("Letter is a Consonent" +letter);
            }
            Console.ReadLine();
        }
    }
}
