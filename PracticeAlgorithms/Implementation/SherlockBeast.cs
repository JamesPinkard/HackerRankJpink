using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class SherlockBeast
    {
        static void SolveInput(String[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int digits = Convert.ToInt32(Console.ReadLine());
                string result = Solve(digits);
                Console.WriteLine(result);
            }
        }
        public static string Solve(int num)
        {
            StringBuilder result =new StringBuilder();

            int runningNumber = num;
            while (runningNumber > 0)
            {
                if (runningNumber % 15 == 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        result.Append("555");
                    }
                    runningNumber -= 15;
                    continue;
                }
                else if (runningNumber == 5 || runningNumber == 10)
                {
                    result.Append("33333");
                    runningNumber -= 5;
                    continue;
                }
                else if (runningNumber >= 3)
                {
                    result.Append("555");
                    runningNumber -= 3;
                    continue;
                }
                else
                {
                    result.Clear();
                    result.Append("-1");
                    runningNumber = 0;
                }
            }            
            
            return result.ToString();
        }
    }
}
