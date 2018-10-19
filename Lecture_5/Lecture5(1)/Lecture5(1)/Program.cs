using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Input data for student " + (i+1));

                Console.WriteLine("Input first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Input last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Input admission date");
                string date = Console.ReadLine();

                Console.WriteLine("Input country");
                string country = Console.ReadLine();

                Console.WriteLine("Input city");
                string city = Console.ReadLine();

                Console.WriteLine("Input address");
                string address = Console.ReadLine();

                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EntryDate = date,
                    StudentAddress = new StudentAddress(country, city, address)
                };

                StudentRegistry.AddStudent(student);
                Console.Clear();
            }

            Console.WriteLine(StudentRegistry.GetAllInfo());
           
        }
    }
}
