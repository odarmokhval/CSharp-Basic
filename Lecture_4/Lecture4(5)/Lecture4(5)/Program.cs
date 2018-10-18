using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            string MyString = "Learn C# by stepping through the basics with Bob: get the tools, see how to write code, debug features, explore customizations, and much more ! Search for and focus on the information you need, in this C# for beginners course, which has topics separated out into individual videos. Get to know the grammar, create and use methods, manipulate strings, and see how to handle events. Plus, get a look at next steps as you learn to develop Windows and web applications."; ;
            string stringToFind = "et";

            //List<int> positions = new List<int>();
            //int pos = 0;
            //while ((pos < MyString.Length) && (pos = MyString.IndexOf(stringToFind, pos)) != -1)
            //{
            //    positions.Add(pos);
            //    pos += stringToFind.Length;
            //}

            //Console.WriteLine("{0} occurrences", positions.Count);


            //StringBuilder builder = new StringBuilder(MyString);
            //builder.Replace("cs", "c's");

            //string MyStringNew = builder.ToString();
            //Console.WriteLine("!" + MyStringNew);

            int count = 0;
            int index = 0;

            while ((index = MyString.IndexOf(stringToFind, index + 1)) > 0)
            {
                count++;
            }
            Console.WriteLine("{0} occurrences", count);

            string MyStringNew = MyString.Replace("cs", "c's");
            Console.WriteLine("!" + MyStringNew);

            Console.ReadKey();
        }
    }
}
