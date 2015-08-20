using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


public class Solution
{
    static void Main(String[] args)
    {
        int tests = ReadInt();

        int[] studentNumbers;
        for (int i = 0; i < tests; i++)
        {
            string parameters = Console.ReadLine();
            studentNumbers = ReadStringIntoNumArray(parameters);
            int numberOfStudents = studentNumbers[0];
            int classCancelledCriteria = studentNumbers[1];

            string timeString = Console.ReadLine();
            int[] times = ReadStringIntoNumArray(timeString);
            List<int> onTimeStudents = times.Where(time => time <= 0).ToList<int>();

            int studentCount = onTimeStudents.Count;
            if (studentCount < classCancelledCriteria)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    private static int ReadInt()
    {
        int t = Convert.ToInt32(Console.ReadLine());
        return t;
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

