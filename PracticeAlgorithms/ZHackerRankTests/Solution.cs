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

