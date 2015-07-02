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
        }
    }
}
