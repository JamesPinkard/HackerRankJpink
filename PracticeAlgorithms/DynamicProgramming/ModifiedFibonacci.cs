using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

namespace DynamicProgramming
{
    public class ModifiedFibonacci
    {
        static void Solve(string[] args)
        {
            string input = Console.ReadLine();
            int[] intInput = ReadStringIntoNumArray(input);

            BigInteger first = intInput[0];
            BigInteger second = intInput[1];
            int nTerm = intInput[2];

            BigInteger resultTerm = GetFibonacciTerm(first, second, nTerm);
            WriteBigInteger(resultTerm);
        }

        private static void WriteBigInteger(BigInteger resultTerm)
        {
            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, 100);
            while (resultTerm != 0)
            {
                ans.Add(resultTerm % p10);
                resultTerm /= p10;
            }
            Console.Write(ans[ans.Count - 1]);
            var fmt = new string('0', 100);
            for (var i = ans.Count - 2; i >= 0; i--)
            {
                var str = ans[i].ToString();
                Console.Write("{0}{1}", fmt.Substring(0, 100 - str.Length), str);
            }
            Console.WriteLine();            
        }

        public static int[] ReadStringIntoNumArray(string numString)
        {
            string[] mySplit = numString.TrimEnd().Split();
            int[] numArray = new int[mySplit.Length];
            for (int j = 0; j < mySplit.Length; j++)
            {
                int num = Convert.ToInt32(mySplit[j]);
                numArray[j] = num;
            }
            return numArray;
        }

        public static BigInteger GetFibonacciTerm(BigInteger first, BigInteger second, int nTerm)
        {
            BigInteger myFirst = first;
            BigInteger mySecond = second;

            for (int i = 0; i < nTerm-2; i++)
            {
                BigInteger oldSecond = mySecond;
                mySecond = BigInteger.Multiply(mySecond, mySecond);
                mySecond = BigInteger.Add(mySecond,myFirst);
                myFirst = oldSecond;
            }

            return mySecond;
        }

        public static BigInteger OldGetFibonacciTerm(BigInteger first, BigInteger second, int nTerm)
        {
            if (nTerm == 2)
            {
                return second;
            }
            else
            {
                BigInteger newSecond = (second * second) + first;
                BigInteger newFirst = second;
                int newTerm = nTerm - 1;
                return GetFibonacciTerm(newFirst, newSecond, newTerm);
            }
        }
    }
}
