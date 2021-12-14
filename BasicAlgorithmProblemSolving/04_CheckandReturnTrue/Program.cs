using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CheckandReturnTrue
{
    class Program
    {

        public static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Enter  Number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result :  "+ Check(x));
            }
               
             
        }

        public static bool Check(int n)
        
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
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
