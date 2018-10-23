using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Func;


namespace Lecture6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lenght of Fibonacci Series: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Class1.Fibonacci(len);

            Console.WriteLine("Accept number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Class1.PrimeNumber(num1);

            Console.ReadKey();           

        }
    }
}
