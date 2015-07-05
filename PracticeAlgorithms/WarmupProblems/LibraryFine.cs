using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    public class LibraryFine
    {
        public static void Solve(string[] args) {
            string returnedDate = Console.ReadLine();
            string dueDate = Console.ReadLine();

            DateTime retDate = GetDate_DMY_Format(returnedDate);
            DateTime expectedDate = GetDate_DMY_Format(dueDate);

            int yearsOverdue = retDate.Year - expectedDate.Year;
            int monthsOverdue = retDate.Month - expectedDate.Month;
            int daysOverdue = retDate.Day - expectedDate.Day;

            TimeSpan overdueTime = retDate - expectedDate;

            int fine=0;

            if (overdueTime.Days<=0)
            {
                fine = 0;
            }

            else if (yearsOverdue >= 1)
            {
                fine = 10000; 
            }

            else if (monthsOverdue >= 1)
            {
                fine = monthsOverdue * 500;
            }

            else if (daysOverdue >= 1)
            {
                fine = daysOverdue * 15;
            }

            Console.WriteLine(fine);
        }

        public static DateTime GetDate_DMY_Format(string date)
        {            
            string[] dateArray = date.TrimEnd().Split();

            int iday = Convert.ToInt32(dateArray[0]);
            int imonth = Convert.ToInt32(dateArray[1]);
            int iyear = Convert.ToInt32(dateArray[2]);

            DateTime dt = new DateTime(iyear, imonth, iday);
            return dt;
        }
    }
}
