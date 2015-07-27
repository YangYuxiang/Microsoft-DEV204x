using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string province;
            string postal;
            string country;

            Student[] studentArray = new Student[5];
            //studentArray[0] = new Student("Gordon", "Yang", "19890118", "Nanyao Road 88", "Songmin Road 868", 
            //    "Nanjing", "Jiangsu", "030024", "China");

            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.Write("First Name: ");
                firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                lastName = Console.ReadLine();
                Console.Write("Birth Date: ");
                birthDate = Console.ReadLine();
                Console.Write("Address Line 1: ");
                addressLine1 = Console.ReadLine();
                Console.Write("Address Line 2: ");
                addressLine2 = Console.ReadLine();
                Console.Write("City: ");
                city = Console.ReadLine();
                Console.Write("Province: ");
                province = Console.ReadLine();
                Console.Write("Postal: ");
                postal = Console.ReadLine();
                Console.Write("Country: ");
                country = Console.ReadLine();
                studentArray[i] = new Student(firstName, lastName, birthDate, addressLine1, addressLine2, city, province, postal, country);
            }


            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine(studentArray[i].FirstName);
                Console.WriteLine(studentArray[i].LastName);
                Console.WriteLine(studentArray[i].Birthdate);
                Console.WriteLine(studentArray[i].AddressLine1);
                Console.WriteLine(studentArray[i].AddressLine2);
                Console.WriteLine(studentArray[i].City);
                Console.WriteLine(studentArray[i].Province);
                Console.WriteLine(studentArray[i].Postal);
                Console.WriteLine(studentArray[i].Country);
            }
        }
        public struct Student
        {
            public Student(string firstName, string lastName, string birthdate, string addressLine1,
                string addressLine2, string city, string province, string postal, string country)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Birthdate = birthdate;
                this.AddressLine1 = addressLine1;
                this.AddressLine2 = addressLine2;
                this.City = city;
                this.Province = province;
                this.Postal = postal;
                this.Country = country;
            }

            public string FirstName;
            public string LastName;
            public string Birthdate;
            public string AddressLine1;
            public string AddressLine2;
            public string City;
            public string Province;
            public string Postal;
            public string Country;
        }

        public struct Teacher
        {
            public Teacher(string firstName, string lastName, string birthdate, string addressLine1,
                string addressLine2, string city, string province, string postal, string country)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Birthdate = birthdate;
                this.AddressLine1 = addressLine1;
                this.AddressLine2 = addressLine2;
                this.City = city;
                this.Province = province;
                this.Postal = postal;
                this.Country = country;
            }

            public string FirstName;
            public string LastName;
            public string Birthdate;
            public string AddressLine1;
            public string AddressLine2;
            public string City;
            public string Province;
            public string Postal;
            public string Country;
        }

        public struct UProgram
        {
            public UProgram(string programName, string departmentHead, string degrees)
            {
                this.ProgramName = programName;
                this.DepartmentHead = departmentHead;
                this.Degrees = degrees;
            }
            public string ProgramName;
            public string DepartmentHead;
            public string Degrees;
        }

        public struct Course
        {
            public Course(string courseName, string credits, string durationInWeeks, string teacher)
            {
                this.CourseName = courseName;
                this.Credits = credits;
                this.DurationInWeeks = durationInWeeks;
                this.Teacher = teacher;
            }

            public string CourseName;
            public string Credits;
            public string DurationInWeeks;
            public string Teacher;
        }
    }
}


