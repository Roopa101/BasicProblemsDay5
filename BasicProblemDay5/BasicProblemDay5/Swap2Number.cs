﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblemDay5
{
    class Swapping2Num
    {
        public static void Main(string[] args) 
        {
            
            Console.WriteLine("Enter the First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
       
            Console.WriteLine("Enter the Second number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
           
            firstNumber  = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber  = firstNumber - secondNumber;
            
            Console.WriteLine("After Swapping these Two Numbers : First number is =" + firstNumber + " and Second number is =" + secondNumber);
            Console.ReadLine();
        }
    }
}
    
