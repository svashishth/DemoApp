using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp.InterviewPrograms
{
    public static class FinancialMonth
    {
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

        public static void Boa_FindQuarterOfTheGivenMonth_Method2(int startMonthOfTheYear = 5, int quarterOfTheMonth = 5)
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

            Console.WriteLine("Given month comes in Quarter: " + ((Array.IndexOf(FinacialYear, quarterOfTheMonth) / 3) + 1));

            Console.ReadKey();
        }


    }


}
