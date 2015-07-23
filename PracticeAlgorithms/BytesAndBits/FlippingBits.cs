using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytesAndBits
{
    public class FlippingBits
    {
        static void Solve(string[] args)
        {
            FlippingBits fb = new FlippingBits();
            int nums = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nums; i++)
            {
                uint integer = Convert.ToUInt32(Console.ReadLine());
                uint flipped = fb.FlipInteger(integer);
                Console.WriteLine(flipped);
            }
        }

        public uint FlipInteger(uint integer)
        {
            uint myInteger = integer;            
            byte[] bytes = new byte[32];

            uint flipped=0;
            double temp;
            for (int i = 0; i < 32; i++)
            {
                bytes[i] = AssignBit(myInteger);

                if (bytes[i] == 0)
                {
                    temp = Math.Pow(2, i);
                    flipped += (uint)temp;
                }
                
                myInteger = myInteger / 2;
            }
            return flipped;
          
        }

        private byte AssignBit(uint myInteger)
        {
            if (myInteger % 2 == 1)
                return 1;
            else
                return 0;
        }
    }
}
