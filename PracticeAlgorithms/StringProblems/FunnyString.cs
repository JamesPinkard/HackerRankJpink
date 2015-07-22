using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public  class FunnyString
    {
        static void Solve(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                string words = Console.ReadLine();
                Console.WriteLine(IsFunny(words));
            }
        }

        public static string IsFunny(string funnyString)
        {
            char[] funnyChars = funnyString.ToCharArray();
            char[] reverse = funnyChars.Reverse<char>().ToArray<char>() ;

            int strLength = funnyString.Length;

            //Console.WriteLine(funnyString);
            //Console.WriteLine(reverse);


            for (int i = 1; i < strLength; i++)
            {                
                int stringDifference = Math.Abs(funnyString[i] - funnyString[i - 1]);
                int reverseDifference = Math.Abs(reverse[i] - reverse[i - 1]);

                //Console.WriteLine("sdif:{0} rdif{1}",stringDifference,reverseDifference);

                if (stringDifference != reverseDifference)
                {
                    return "Not Funny";
                }
            }

            return "Funny";
        }
    }
}
