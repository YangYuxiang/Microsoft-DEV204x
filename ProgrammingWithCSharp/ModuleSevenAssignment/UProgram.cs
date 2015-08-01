using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSevenAssignment
{
    class UProgram
    {
        public UProgram(string uprogramName, string departmentHead, Degree degrees)
        {
            this.UprogramName = uprogramName;
            this.DepartmentHead = departmentHead;
            this.Degrees = degrees;
        }
        
        private string uprogramName;

        public string UprogramName
        {
            get { return uprogramName; }
            set { uprogramName = value; }
        }
        private string departmentHead;

        public string DepartmentHead
        {
            get { return departmentHead; }
            set { departmentHead = value; }
        }
        private Degree degrees;

        internal Degree Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }

        
    }
}
