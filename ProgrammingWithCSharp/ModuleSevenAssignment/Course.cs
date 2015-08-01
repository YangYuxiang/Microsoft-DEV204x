using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSevenAssignment
{
    class Course
    {
        public Course(string courseName, string credits, string durationInWeeks)
        {
            this.CourseName = courseName;
            this.Credits = credits;
            this.DurationInWeeks = durationInWeeks;
            this.EnrolledStudent = new ArrayList();
            this.Teacher = new Teacher[3];
        }
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private string credits;

        public string Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        private string durationInWeeks;

        public string DurationInWeeks
        {
            get { return durationInWeeks; }
            set { durationInWeeks = value; }
        }
        private ArrayList enrolledStudent;

        public ArrayList EnrolledStudent
        {
            get { return enrolledStudent; }
            set { enrolledStudent = value; }
        }

        
        private Teacher[] teacher;

        internal Teacher[] Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public void ListStudents()
        {
            foreach (Student student in EnrolledStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);

            }
        }
    }
}
