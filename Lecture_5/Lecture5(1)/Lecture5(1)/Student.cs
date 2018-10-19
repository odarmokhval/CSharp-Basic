using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string entryDate;
        private StudentAddress studentAddress;

        public Student()
        {
        }

        Student(string firstname, string lastName, string entryDate, StudentAddress studentAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.entryDate = entryDate;
            this.studentAddress = studentAddress;
        }


        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string EntryDate
        {
            get
            {
                return entryDate;
            }

            set
            {
                entryDate = value;
            }
        }

        public StudentAddress StudentAddress
        {
            get
            {
                return studentAddress;
            }

            set
            {
                studentAddress = value;
            }
        }

        public string GetStudentInfo()
        {
            return $"{FirstName}, {LastName}, {EntryDate}, {StudentAddress}";
        }

    }
}
