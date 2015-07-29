using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string birthdate, 
            string city, string province, string country, string teacherId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthdate;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.TeacherId = teacherId;
            
        }
        
        private string teacherId;

        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        public void GradeTest()
        { 
            
        }
    }
}
