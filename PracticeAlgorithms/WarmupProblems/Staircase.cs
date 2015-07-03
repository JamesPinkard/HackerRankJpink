using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    public class Staircase
    {
        static void Solve(string[] args)
        {
            int numStairs = ConsoleHelper.ReadInt();

            string stairs = WriteStairs(numStairs);

            Console.Write(stairs);
        }

        public static string WriteStairs(int numStairs)
        {
            StringBuilder sb = new StringBuilder();
            char space = ' ';
            char pound = '#';

            for (int i = 0; i < numStairs; i++)
            {
                int numPound = i + 1;
                int numSpace = numStairs - numPound;

                for (int k = 0; k < numSpace; k++)
                {
                    sb.Append(space);
                }

                for (int j = 0; j < numPound; j++)
                {
                    sb.Append(pound);
                }

                if (i < numStairs - 1)
                {                    
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
