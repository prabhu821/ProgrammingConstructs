using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SwitchCase
    {
        public void WeekDayName()
        {
            Console.Write("\nEnter a weekday number (1-7): ");
            int weekdayNumber = Convert.ToInt32(Console.ReadLine());

            string weekdayName = GetWeekdayName(weekdayNumber);

            Console.WriteLine("The weekday name is: " + weekdayName);
            static string GetWeekdayName(int weekdayNumber)
            {
                switch (weekdayNumber)
                {
                    case 1:
                        return "Monday";
                    case 2:
                        return "Tuesday";
                    case 3:
                        return "Wednesday";
                    case 4:
                        return "Thursday";
                    case 5:
                        return "Friday";
                    case 6:
                        return "Saturday";
                    case 7:
                        return "Sunday";
                    default:
                        return "Invalid weekday number";
                }
            }
        }

        public void Calculator()
        {
            Console.Write("\nEnter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operation: \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("The result of addition is: " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("The result of subtraction is: " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("The result of multiplication is: " + result);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("The result of division is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
