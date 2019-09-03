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
            int ch,i,xx=0,y=0,z=0;
            for(i=1;i>0;i++)
            {
                Console.WriteLine("0. Check Range of Number");
                Console.WriteLine("1. Exit");

                Console.Write("Enter Your Choice = ");
                ch=int.Parse(Console.ReadLine());
                if(ch==1)
                {
                    break;
                }
                switch(ch)
                {
                    case 0:
                        Console.Write("\nValue of X = ");
                        xx=int.Parse(Console.ReadLine());

                        Console.Write("Value of Y = ");
                        y=int.Parse(Console.ReadLine());

                        Console.Write("Value of Z = ");
                        z=int.Parse(Console.ReadLine());

                        bool x = InRange(xx,y,z);
                        Console.WriteLine(x);
                        Console.WriteLine("Enter to Try Again!!\n\n");
                        Console.ReadKey();

                        break;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
            }

            bool InRange(int high, int low, int num)
            {
                //works for negative numbers also.
                return ((num - high) * (num - low) <= 0);
            }
        }
    }
}
