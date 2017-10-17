using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using CS_ConsoleApp.DesignPatterns_AbstractFactory;
using CS_ConsoleApp.DesignPatterns_Factory;

namespace CS_ConsoleApp
{
    class Program
    {
        static void Main()
        {
            TestMathods.PrintPascleTriangle();
        }

    }

    public static class TestMathods
    {
        public static void PrintPascleTriangle(int numberOfLines = 3)
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

        public static void Boa_FindQuarterOfTheGivenMonth(int startMonthOfTheYear = 5, int quarterOfTheMonth = 5)
        {
            int[] YearCalender = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] FinacialYear = new int[12];
            int temp = 0;

            for (int i = 0; i <= YearCalender.Length - startMonthOfTheYear; i++)
            {
                FinacialYear[i] = YearCalender[i + startMonthOfTheYear - 1];
            }

            for (int i = YearCalender.Length - startMonthOfTheYear + 1; i < FinacialYear.Length; i++)
            {
                FinacialYear[i] = YearCalender[temp];
                temp = temp + 1;
            }

            for (int i = 0; i < FinacialYear.Length; i++)
            {
                if (FinacialYear[i] == quarterOfTheMonth)
                {
                    switch (i)
                    {
                        case 0:
                        case 1:
                        case 2:
                            Console.WriteLine("Q1");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Q2");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Q1");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Q4");
                            break;
                    }
                }

            }

            Console.ReadKey();
        }

        //Coplexity should be "n"
        public static void Boa_FindMissingNumberInUnsortedArray()
        {
            int[] arr = { 4, 7, 2, 6, 1, 5 };
            int totalNumberOfElements = arr.Length + 1;  //array elements + one missing number
            int missingNumber; int sum = 0; int SumOfArray = 0;
            sum = totalNumberOfElements * (totalNumberOfElements + 1) / 2;    //formula to find the sum of n natural numbers
            for (int i = 0; i < arr.Length; i++)
            {
                SumOfArray += arr[i];
            }
            missingNumber = sum - SumOfArray;
            Console.WriteLine("Missing Number is : " + missingNumber.ToString());
            Console.ReadKey();
        }

        public static void Ggk_ArrayElementsCount()
        {
            int[] arr = { 4, 5, 5, 2, 4, 7, 2 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {

                        if (arr[i] == arr[j])
                        {
                            arr[j] = -1;
                            count += 1;
                        }
                    }
                    Console.WriteLine(arr[i] + " count is : " + count);
                }
            }
        }

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


