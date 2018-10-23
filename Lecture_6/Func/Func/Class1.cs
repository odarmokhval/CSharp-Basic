using System;

namespace Func
{
    public class Class1
    {
        //    public static int Fibo(int nno)
        //    {
        //        int num1 = 0;
        //        int num2 = 1;

        //        for (int i = 0; i < nno; i++)
        //        {
        //            int temp = num1;
        //            num1 = num2;
        //            num2 = temp + num2;
        //        }
        //        return num1;
        //    }

        //    public static void Main()
        //    {
        //        Console.Write("Input number of Fibonacci Series : ");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("The Fibonacci series of " + n + " numbers is :");

        //        for (int i = 0; i < n; i++)
        //        {
        //            Console.Write(Fibo(i) + "  ");
        //        }
        //        Console.WriteLine();
        //        Console.ReadKey();
        //    }
        //}

        public static void Fibonacci(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine(" {0}", c);
                a = b;
                b = c;
            }
            
        }

        public static void PrimeNumber(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return;
                    }

                }

                Console.WriteLine(num1 + " is a prime number");
                Console.ReadLine();
            }
        }
    }
}
