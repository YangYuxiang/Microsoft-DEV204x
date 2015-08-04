using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEightAssignment
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

            student1.Grades.Push(90);
            student1.Grades.Push(92);
            student1.Grades.Push(89);
            student1.Grades.Push(87);
            student1.Grades.Push(96);

            student2.Grades.Push(80);
            student2.Grades.Push(92);
            student2.Grades.Push(89);
            student2.Grades.Push(86);
            student2.Grades.Push(96);

            student3.Grades.Push(98);
            student3.Grades.Push(92);
            student3.Grades.Push(89);
            student3.Grades.Push(81);
            student3.Grades.Push(96);

            course.EnrolledStudent.Add(student1);
            course.EnrolledStudent.Add(student2);
            course.EnrolledStudent.Add(student3);
            
            course.ListStudents();
     
        }
    }

    
}
