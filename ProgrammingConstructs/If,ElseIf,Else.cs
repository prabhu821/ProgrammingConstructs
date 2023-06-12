using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class If_ElseIf_Else
    {
        public void LargestOfThree()
        {
            Console.Write("\nEnter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            Console.WriteLine("The largest number is: " + largest);
        }

        public void EligibleForAdmission()
        {
            Console.Write("\nEnter marks in Maths: ");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Physics: ");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Chemistry: ");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = mathMarks + physicsMarks + chemistryMarks;

            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("Eligible for admission to the professional course.");
            }
            else if (mathMarks >= 65 && (physicsMarks >= 55 || chemistryMarks >= 55) && totalMarks >= 140)
            {
                Console.WriteLine("Eligible for admission to the professional course.");
            }
            else
            {
                Console.WriteLine("Not eligible for admission to the professional course.");
            }
        }
    }
}
