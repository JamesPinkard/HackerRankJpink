using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytesAndBits
{
    class MaxXOR
    {
        static void Solve(string[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }

        static int maxXor(int l, int r)
        {
            int max = 0;

            for (int i = l; i < r + 1; i++)
            {
                for (int j = i; j < r + 1; j++)
                {
                    int num = i ^ j;
                    max = Math.Max(max, num);
                }
            }
            return max;

        }
    }
}
