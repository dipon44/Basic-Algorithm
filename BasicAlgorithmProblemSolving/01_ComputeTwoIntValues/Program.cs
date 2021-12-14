using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ComputeTwoIntValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give First Int Value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Second Int Value : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Third Int Value : ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Fourth  Int Value : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Fifth Int Value : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Sixth Int Value : ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n\n");
            Console.Write("First Pair :   {0}   {1} ", x, y+"\n");
            Console.Write("Second Pair : {0}   {1} ", z, x1+"\n");
            Console.Write("Third Pair :  {0}   {1} ", y1, z1+"\n");

            if(x==y||z==x1||y1==z1)
            {
                Console.Write("Sum of First Pair : ", x + y);
                Console.Write("Sum of Second Pair : ", z + x1);
                Console.Write("Sum of Third Pair : ", (3*(y1 + z1)));
            }

            else
            {
                Console.Write("Sum of First Pair : ", x + y);
                Console.Write("Sum of Second Pair : ", z + x1);
                Console.Write("Sum of Third Pair : ",  y1 + z1);
            }
            Console.ReadKey();


        }
    }
}
