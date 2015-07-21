using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace SearchProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            using (StreamWriter sw = new StreamWriter(@"S:\Projects\CHPRC_HAN_60\CP_Graded_Approach\Follow-on_Task_4_GUI_update\Database\access_test_11col.txt"))
            {
                sw.WriteLine(String.Join("\t", "Time", "Sim_Number", "Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7", "Value8", "Value9"));

                //6601
                for (int i = 3301; i < 6601; i++)
                {
                    int time = 0;
                    string sim = String.Format("case_{0}", i);
                    double value = 0;

                    for (int j = 0; j < 1045; j++)
                    {                
                        string entryValue = value.ToString("E");
                        string entry = String.Join("\t", time.ToString("E"), sim, entryValue,entryValue,entryValue,entryValue,entryValue,entryValue,entryValue,entryValue,entryValue);
                        sw.WriteLine(entry);

                        time++;
                        value = rnd.NextDouble() * 100;
                    }
                }
            }
        }
    }
}
