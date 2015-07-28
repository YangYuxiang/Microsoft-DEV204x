using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Degree
    {
        public Degree(string degreeName, string creditsRequired, Course course)
        {
            this.DegreeName = degreeName;
            this.creditsRequired = creditsRequired;
            this.Course = course;
        }
        private string degreeName;

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }
        private string creditsRequired;

        public string CreditsRequired
        {
            get { return creditsRequired; }
            set { creditsRequired = value; }
        }
        private Course course;

        internal Course Course
        {
            get { return course; }
            set { course = value; }
        }



    }
}
