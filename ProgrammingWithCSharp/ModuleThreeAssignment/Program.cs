using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFirstName;
            string studentLastName;
            string studentBirthday;
            
            string teacherFirstName;
            string teacherLastName;
            string teacherBirthday;

            string courseName;
            string courseCredits;
            string teacherName;

            string uprogramName;
            string deptHead;
            string degrees;

            string degreeName;
            string credits4degree;

            GetStudentInformation(out studentFirstName, out studentLastName, out studentBirthday);
            GetTeacherInformation(out teacherFirstName, out teacherLastName, out teacherBirthday);
            GetCourseInformation(out courseName, out courseCredits, out teacherName);
            GetUProgramInformation(out uprogramName, out deptHead, out degrees);
            GetDegreeInformation(out degreeName, out credits4degree);

            PrintStudentDetails(studentFirstName, studentLastName, studentBirthday);
            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherBirthday);
            PrintCourseDetails(courseName, courseCredits, teacherName);
            PrintUprogramDetails(uprogramName, deptHead, degrees);
            PrintDegreeDetails(degreeName, credits4degree);

            ValidateStudentBirthday(studentBirthday);
                       
        }

        static void GetStudentInformation(out string firstName, out string lastName, out string birthday)
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's bithday: ");
            birthday = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation(out string firstName, out string lastName, out string birthday)
        {
            Console.WriteLine("Enter the teacher's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's bithday: ");
            birthday = Console.ReadLine();

        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetCourseInformation(out string courseName, out string courseCredits, out string teacherName)
        {
            Console.WriteLine("Enter the name of the course: ");
            courseName = Console.ReadLine();
            Console.WriteLine("Enter the credits of the course: ");
            courseCredits = Console.ReadLine();
            Console.WriteLine("Enter the teacher's name for the course: ");
            teacherName = Console.ReadLine();

        }

        static void PrintCourseDetails(string courseName, string courseCredits, string teacherName)
        {
            Console.WriteLine("{0} {1} {2}", courseName, courseCredits, teacherName);
        }

        static void GetUProgramInformation(out string uprogramName, out string deptHead, out string degrees)
        {
            Console.WriteLine("Enter the name for the Uprogram: ");
            uprogramName = Console.ReadLine();
            Console.WriteLine("Enter the department head for the Uprogram: ");
            deptHead = Console.ReadLine();
            Console.WriteLine("Enter the degrees for the Uprogram: ");
            degrees = Console.ReadLine();

        }

        static void PrintUprogramDetails(string uprogramName, string deptHead, string degrees)
        {
            Console.WriteLine("{0} {1} {2}", uprogramName, deptHead, degrees);
        }

        static void GetDegreeInformation(out string degreeName, out string credits4degree)
        {
            Console.WriteLine("Enter the name for the degree: ");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the credits required for the degree: ");
            credits4degree = Console.ReadLine();

        }

        static void PrintDegreeDetails(string degreeName, string credits4degree)
        {
            Console.WriteLine("{0} {1}", degreeName, credits4degree);
        }

        static void ValidateStudentBirthday(string birthday)
        {
            try
            {
                DateTime.Parse(birthday);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
