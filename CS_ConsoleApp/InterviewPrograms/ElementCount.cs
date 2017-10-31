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
            int[] arr = {1,1,1,2,3,3,4,5,6,6,6,6,6 };
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

        public static void ReturnArrayElementsCount()
        {
            int[] arr = { 1, 1, 1, 2, 3, 3, 4, 5, 6, 6, 6, 6, 6 };
            int[] arrNew = new int[arr.Length];
            int arrayIndex = 0;
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
                    if(count>1)
                    {
                        arrNew[arrayIndex] = arr[i];
                        arrayIndex += 1;
                    }
                }
            }
            for (int i = 0; i < arrNew.Length; i++)
            {
                if(!(arrNew[i]==0))
                Console.WriteLine(arrNew[i]);
            }
        }



    }
}
