using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp.InterviewPrograms
{
    public static class MIssingNumber
    {
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

    }
}
