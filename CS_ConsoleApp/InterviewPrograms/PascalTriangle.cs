using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp.InterviewPrograms
{
    public static class PascalTriangle
    {
        public static void PrintNormalPascalTriangle(int numberOfLines = 3)
        {
            int numberOfSpaces = numberOfLines - 1;
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = numberOfSpaces; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                    if (j - 1 != 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                numberOfSpaces -= 1;

            }
        }
    }
}
