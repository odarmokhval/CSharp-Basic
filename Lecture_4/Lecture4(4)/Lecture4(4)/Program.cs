using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_4
{
    enum Weekday
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix = 
                {                
                    new string[] {"John and Mary have a discussion","1"},
                    new string[] {"John and Mary interview","3"},
                    new string[] {"F2F","2"},
                    new string[] {"General meeting","1"}
                };
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string myEvent = matrix[i][0];

                if (myEvent.Length > 10)
                {
                    myEvent = myEvent.Substring(0, 10) + "...";
                }

                int date = int.Parse(matrix[i][1]);
                Weekday weekday = (Weekday)date;
                
                string message = $"{myEvent} on {weekday}".ToLower();

                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}
