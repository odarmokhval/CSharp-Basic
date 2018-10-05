using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance(meters): ");
            float distarnceMeters = float.Parse(Console.ReadLine());

            Console.WriteLine("Input time Sec(hours): ");
            float timeHours = float.Parse(Console.ReadLine());

            Console.WriteLine("Input time Sec(minutes): ");
            float timeMinutes = float.Parse(Console.ReadLine());

            Console.WriteLine("Input time Sec(seconds): ");
            float timeSeconds = float.Parse(Console.ReadLine());

            float totalTimeSeconds = (timeHours * 3600) + (timeMinutes * 60) + timeSeconds;

            double distanceMiles = distarnceMeters / 1609.344;          


            Console.WriteLine("Your speed in meters/sec is: " + distarnceMeters / totalTimeSeconds);
            Console.WriteLine("Your speed in km / h is: " + (distarnceMeters / 1000) / (totalTimeSeconds / 3600));
            Console.WriteLine("Your speed in miles / h is: " + distanceMiles / (totalTimeSeconds / 3600));

            Console.ReadKey();


        }
    }
}
