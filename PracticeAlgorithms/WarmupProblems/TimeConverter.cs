using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarmupProblems
{
    class TimeConverter
    {
        static void Solve(string[] args){
            string dateString = Console.ReadLine();

            DateTime dt = DateTime.Parse(dateString);
            string formattedDate = String.Format("{0:HH:mm:ss}", dt);
            Console.WriteLine(formattedDate);
            
            
        }

        //public DateTime ConvertTime(DateTime dt){        

        //}

        
    }
}
