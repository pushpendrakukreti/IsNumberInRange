using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRangeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = InRange(10, 20, 18);
            Console.WriteLine(x);
            Console.ReadLine();

            bool InRange(int high, int low, int num)
            {
                //works for negative numbers also.
                return ((num - high) * (num - low) <= 0);
            }
        }
    }
}
