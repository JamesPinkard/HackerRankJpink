using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    public static class ConsoleHelper
    {
        public static int ReadInt()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            return t;
        }

        public static string[] ReadNextLines(int number)
        {
            string[] result = new string[number];
            for (int i = 0; i < number; i++)
            {
                result[i] = Console.ReadLine();
            }
            return result;
        }
    }
}
