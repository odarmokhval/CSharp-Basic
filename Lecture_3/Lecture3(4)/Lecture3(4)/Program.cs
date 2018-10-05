using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_4_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter result of physics exam: ");
            int physics = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter result of chemistry exam: ");
            int chemistry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter result of math exam: ");
            int math = int.Parse(Console.ReadLine());
            int sum = math + physics + chemistry;

            bool isMathCorrect = math >= 65;
            bool isPhyscCorrect = physics >= 55;
            bool isChemCorrect = chemistry >= 50;
            bool isSumCorrect = sum >= 180;

            bool isMathSumCorrect = (math + chemistry) >= 140 || (math + physics) >= 140;

            bool isCorrect = (isMathCorrect && isPhyscCorrect && isChemCorrect && isSumCorrect) || isMathSumCorrect;

            if (isCorrect) {
                Console.WriteLine("Student is approved");
            }
            else
            {
                Console.WriteLine("Student is not approved");
            }
        }
    }
}
