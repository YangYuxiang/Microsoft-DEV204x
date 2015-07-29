using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFiveAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Gordon", "Yang", "19890118", "Nanyao Road 88", "Songmin Road 868",
                "Nanjing", "Jiangsu", "030024", "China");

            Student student2 = new Student("Amy", "Wang", "19890118", "Nanyao Road 88", "Songmin Road 868",
                "Nanjing", "Jiangsu", "030024", "China");

            Student student3 = new Student("Tony", "Ma", "19890118", "Nanyao Road 88", "Songmin Road 868",
                "Nanjing", "Jiangsu", "030024", "China");

            Course course = new Course("Programming with C#", "4", "8");
            course.EnrolledStudent[0] = student1;
            course.EnrolledStudent[1] = student2;
            course.EnrolledStudent[2] = student3;

            Teacher teacher1 = new Teacher("Tom", "Xiao", "19890118", "Nanyao Road 88", "Songmin Road 868",
                "Nanjing", "Jiangsu", "030024", "China");
            course.Teacher[0] = teacher1;

            Degree degree = new Degree("Bachelor", "234", course);

            UProgram uprogram = new UProgram("Information Technology", "Cunhua Li", degree);

            Console.WriteLine("The {0} of {1} degree contains the course {2}", degree.DegreeName, uprogram.UprogramName, course.CourseName);
            Console.WriteLine("The {0} course contains {1} student(s)", course.CourseName, Student.NumEnrolled);
        }
    }
}
