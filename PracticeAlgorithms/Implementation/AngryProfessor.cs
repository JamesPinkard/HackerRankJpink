using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Implementation
{
    public class AngryProfessor
    {
        #region psuedocode
        /// N is the number of students in class
        /// If there is less than K students class is canceled
        /// Given the arrival time of each student is class cancelled?

        ///Input
        /// T: number of test cases
        /// Testcase_line1: N K
        /// Testcase_line2: int[]-Arrival time of each student

        ///Output
        /// "YES" Or "NO" for each test case

        ///Sample
        /// --- input ---
        /// 2
        /// 4 3
        /// -1 -3 4 2
        /// 4 2
        /// 0 -1 2 1
        /// --- output---
        /// YES
        /// NO

        ///Psuedocode
        /// tests = readline
        /// for i in tests:
        ///     studentNumbers = readline
        ///     numberOfStudents =studentNumbers[0]
        ///     classCancelledCriteria = studentNumbers[1]
        ///     times = readline
        ///     int studentsInClass = 0
        ///     for t in read line:
        ///         if t is less than 0
        ///             studentsInClass++
        ///     if studentsInClass < K
        ///         "Yes"
        ///     else
        ///         "No"
        /// 
        #endregion

        public static void Solve(String[] args)
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
}
