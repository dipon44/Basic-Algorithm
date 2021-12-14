using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CheckIntegerTrue_False
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Enter First Number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Check(x, y));
            }
                
        }

        public static bool Check(int n, int p)
        {
            if(n == 30||p==30||n+p==30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
