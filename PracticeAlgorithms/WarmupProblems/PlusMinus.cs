using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    public static class PlusMinus
    {
        public static void Solve(string[] args)
        {
            int numberCount = ConsoleHelper.ReadInt();
            string numberInput = Console.ReadLine();
            int[] myNumbers = ConsoleHelper.ReadStringIntoNumArray(numberInput);

            int negatives = getNegatives(myNumbers);
            int zeroes = getZeroes(myNumbers);
            int positivies = getPositives(myNumbers);

            double negFrac = Math.Round((double)negatives / numberCount, 3);
            double zeroFrac = Math.Round((double)zeroes / numberCount, 3);
            double posFrac = Math.Round((double)positivies / numberCount, 3);

            Console.WriteLine(posFrac);
            Console.WriteLine(negFrac);
            Console.WriteLine(zeroFrac);
        }

        private static int getNegatives(int[] myNumbers)
        {
            int count = 0;
            foreach (var num in myNumbers)
            {
                if (num<0)
                {
                    count += 1;
                }
            }
            return count;
        }

        private static int getZeroes(int[] myNumbers)
        {
            int count = 0;
            foreach (var num in myNumbers)
            {
                if (num == 0)
                {
                    count += 1;
                }
            }
            return count;
        }

        private static int getPositives(int[] myNumbers)
        {
            int count = 0;
            foreach (var num in myNumbers)
            {
                if (num > 0)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
