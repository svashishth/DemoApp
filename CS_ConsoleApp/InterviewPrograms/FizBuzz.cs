using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp.InterviewPrograms
{
    public static class FizBuzz
    {
        public static void CapitalIQ_Q1()
        {
            int N = 105;
            string printValue = null;
            int number;
            if (Int32.TryParse(N.ToString(), out number))
            {
                for (int counter = 1; counter <= N; counter++)
                {
                    printValue = counter.ToString();

                    if (counter % 3 == 0)
                    {
                        printValue = "Fizz";
                    }

                    if (counter % 5 == 0)
                    {
                        if (printValue == counter.ToString())
                        {
                            printValue = "Buzz";
                        }
                        else
                            printValue += "Buzz";
                    }

                    if (counter % 7 == 0)
                    {
                        if (printValue == counter.ToString())
                        {
                            printValue = "Woof";
                        }
                        else
                        {
                            printValue += "Woof";
                        }
                    }
                    Console.WriteLine(printValue);
                }

            }

        }

        /// <summary>
        /// Write a logic
        /// if the number is even then devide the number by 2
        /// if the number is odd subtract by 1
        /// </summary>
        public static void CapitalIQ_Q2(int x)
        {
            x = 28;     //assuming the value
            while (x > 0)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                    Console.WriteLine("Value of x after devide = " + x);
                }
                else
                {
                    x = x - 1;
                    Console.WriteLine("Value of x after substracting = " + x);
                }
            }
            Console.ReadKey();
        }

    }
}
