using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class ForLoop
    {
        public void PowerOfTwo()
        {
            Console.Write("\nEnter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Powers of 2 less than or equal to 2^" + n + ":");
            Console.WriteLine("Power\tValue");

            for (int i = 0; i <= n; i++)
            {
                int power = i;
                int value = (int)Math.Pow(2, i);
                Console.WriteLine(power + "\t" + value);
            }
        }

        public void SumOfSquares()
        {
            Console.Write("\nEnter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sumOfSquares = 0;

            for (int i = 1; i <= N; i++)
            {
                sumOfSquares += i * i;
            }

            Console.WriteLine("The sum of squares of the first " + N + " numbers is: " + sumOfSquares);
        }

        public void Factorial()
        {
            Console.Write("\nEnter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = ComputeFactorial(number);

            Console.WriteLine("The factorial of " + number + " is: " + factorial);

            static long ComputeFactorial(int n)
            {

                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    long result = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                    return result;
                }
            }
        }
    }
}
    