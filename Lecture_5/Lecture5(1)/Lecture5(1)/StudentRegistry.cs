using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    public static class StudentRegistry
    {
        static List<Student> registry = new List<Student>();

        static StudentRegistry()
        {

        }

        public static void AddStudent(Student st)
        {
            registry.Add(st);
        }

        public static void RemoveStudent(Student st)
        {
            registry.Remove(st);
        }

        public static string GetAllInfo()
        {
            string output = string.Empty;
            int counter = 1;

            foreach (var student in registry)
            {
                output += counter.ToString() + "." + student.GetStudentInfo() + "\n";
                counter++;
            }

            return output;
        }
    }
}
