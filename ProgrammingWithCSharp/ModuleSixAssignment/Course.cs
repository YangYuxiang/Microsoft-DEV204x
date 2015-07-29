using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSixAssignment
{
    class Course
    {
        public Course(string courseName, string credits, string durationInWeeks)
        {
            this.CourseName = courseName;
            this.Credits = credits;
            this.DurationInWeeks = durationInWeeks;
            this.EnrolledStudent = new Student[3];
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
        private Student[] enrolledStudent;

        internal Student[] EnrolledStudent
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


    }
}
