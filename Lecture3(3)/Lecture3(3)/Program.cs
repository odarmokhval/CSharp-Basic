using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    a[i, j] = i;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
