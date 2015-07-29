using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Student
    {
        public Student(string firstName, string lastName, string birthdate, string addressLine1,
               string addressLine2, string city, string province, string postal, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthdate;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.Province = province;
            this.Postal = postal;
            this.Country = country;
            numEnrolled++;
        }

        private static int numEnrolled = 0;

        public static int NumEnrolled
        {
            get { return Student.numEnrolled; }
            set { Student.numEnrolled = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private string addressLine1;

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        private string addressLine2;

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string province;

        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        private string postal;

        public string Postal
        {
            get { return postal; }
            set { postal = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
