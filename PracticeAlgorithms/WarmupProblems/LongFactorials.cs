using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WarmupProblems
{
    public class LongFactorials
    {
        public static void Solve(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            BigInteger bigNumber = number;
            BigInteger factorial = CalculateFactorial(bigNumber);

            Console.WriteLine(factorial);
        }

        public static BigInteger CalculateFactorial(BigInteger num)
        {
            if (num == 1) 
            {
                return num;
            }

            BigInteger nextNum = num - 1;
            return num * CalculateFactorial(nextNum);
        }
        
    }
}
