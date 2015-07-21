using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Implementation
{
    public class CutTheSticks
    {
        static void Solve(String[] args)
        {
            Console.ReadLine();
            int[] input = ReadStringIntoNumArray(Console.ReadLine());

            List<int> cuts = GetCuts(input.ToList<int>());

            cuts.ForEach(x => Console.WriteLine(x));
        }

        public static List<int> GetCuts(List<int> input)
        {
            List<int> cuts = new List<int>();
            while (input.Count > 0)
            {
                cuts.Add(input.Count);
                int min = input.Min();
                input.RemoveAll(x => x == min);
                input.ForEach(x => x -= min);
            }
            return cuts;            
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
    }
}
