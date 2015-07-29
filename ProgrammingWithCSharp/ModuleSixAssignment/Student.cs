using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Student : Person
    {
        public Student(string firstName, string lastName, string birthdate, 
            string city, string province, string country, string studentId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthdate;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.StudentId = studentId;
            numEnrolled++;
        }

        private static int numEnrolled = 0;

        public static int NumEnrolled
        {
            get { return Student.numEnrolled; }
            set { Student.numEnrolled = value; }
        }

        private string studentId;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public void TakeTest() 
        {
            
        }
    }
}
