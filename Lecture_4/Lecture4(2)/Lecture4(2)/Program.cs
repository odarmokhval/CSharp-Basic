using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = { -4, -3, 0, 1, 2, -2, -1, 3, 4 };


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > 0)
                {
                    Console.Write(arr[i] + " ");
                }

            } 
            Console.ReadKey();
        }
    }
}
