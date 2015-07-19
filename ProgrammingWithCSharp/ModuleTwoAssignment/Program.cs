using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 8;
            int col = 8;
            int isOX = 1;

            for (int i = 0; i < row; i++)
            {
                if (isOX == 1)
                {
                    for (int j = 0; j < col / 2; j++)
                    {
                        Console.Write("XO");
                    }
                    isOX = 0;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < col / 2; j++)
                    {
                        Console.Write("OX");
                    }
                    isOX = 1;
                    Console.WriteLine();
                }

            }
        }
    }
}
