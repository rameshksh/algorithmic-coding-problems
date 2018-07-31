using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    //Write an efficient program for printing k largest elements in an array. Elements in array can be in any order.
    public class LargestElementArray
    {
        int[] arr = new int[]{ 4,44,35,67,34,7,34,2,98,2};
        int k = 5;

        public void Find()
        {
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("kth largest - {0}", arr[i]);
            }
        }
    }
}
