using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureThird
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("I wanna calculate something for you, please input the first digit: ");
            bool res = int.TryParse(Console.ReadLine(), out a);
            if (res == false)
            {
                Console.WriteLine("I don't know now to multiply chars");
                Console.ReadKey();
            }

            Console.WriteLine("Thank’s and another digit please!");
            res = int.TryParse(Console.ReadLine(), out b);

            if (res == false)
            {
                Console.WriteLine("I don't know now to multiply chars");
                Console.ReadKey();

            }

            else if ((a > 10 || a < 0) || (b > 10 || b < 0))
            {
                Console.WriteLine("I support only 0 to 10");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Here you are: {0}", a * b);
                Console.ReadKey();
            }
        }
    }
}
