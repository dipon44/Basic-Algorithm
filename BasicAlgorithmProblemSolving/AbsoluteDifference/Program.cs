using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDifference
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter First Value : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(test(p));
            Console.Write("Enter Second Value : ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(test(q));
            Console.Write("Enter Third Value : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(test(r));
            Console.ReadLine();
        }

       public static int test(int n)
       {
           const int x = 51;

           if (n > x)
           {
               return (n - x) * 3;
           }
           else
           {
               return x - n;
           }
           
       }
    }
}
