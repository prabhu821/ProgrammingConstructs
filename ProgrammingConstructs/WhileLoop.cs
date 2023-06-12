using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class WhileLoop
    {
        public void FlipCoin()
        {
            int headsCount = 0;
            int tailsCount = 0;

            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                int flip = random.Next(2);

                if (flip == 0)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }

            if (headsCount >= 20)
            {
                Console.WriteLine("\nHeads wins!");
                Console.WriteLine(headsCount);
            }
            else
            {

                Console.WriteLine("\nTails wins!");
                Console.WriteLine(tailsCount);
            }
        }

        public void ReverseWord()
        {
            Console.Write("\nEnter a word: ");
            string word = Console.ReadLine();

            string reversedWord = ReverseWord(word);

            Console.WriteLine("Reversed word: " + reversedWord);

            static string ReverseWord(string word)
            {
                string reversed = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }
                return reversed;
            }
        }

        public void SumOfNaturalNumbers()
        {
            int n = 5;  // Number of natural numbers to sum
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("\nThe sum of the first " + n + " natural numbers is: " + sum);
        }
    }
}
