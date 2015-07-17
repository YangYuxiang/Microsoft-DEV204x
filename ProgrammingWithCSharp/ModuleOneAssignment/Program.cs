using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string province;
            string postal;
            string country;
                        
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            // date input example: 2015-07-17
            Console.Write("Birth Date: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());
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

            Console.WriteLine();
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate.ToShortDateString());
            Console.WriteLine(addressLine1);
            Console.WriteLine(addressLine2);
            Console.WriteLine(city);
            Console.WriteLine(province);
            Console.WriteLine(postal);
            Console.WriteLine(country);
            
        }
    }
}
