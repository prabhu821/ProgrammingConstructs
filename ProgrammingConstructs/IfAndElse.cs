using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class IfAndElse
    {
        public void TwoNumAreEqual()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("The two integers are equal.");
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
            }
        }

        public void IsEvenOrOdd()
        {
            Console.Write("\nEnter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        public void IsEligible()
        {
            Console.Write("\nEnter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to cast your vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to cast your vote.");
            }
        }
    }
}
