using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 5, 67, 88, 11, 45};
            int lenght = arr.Length;

            for (int i = 0; i < lenght; i++)
            {
                for (int k = 0; k < lenght - 1; k++)
                {

                    if (arr[k] >= arr[k + 1])
                    {
                        int j = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = j;
                    }
                }
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
