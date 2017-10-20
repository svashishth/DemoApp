using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleApp.InterviewPrograms
{
    public static class ElementCount
    {
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

    }
}
