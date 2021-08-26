using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    //Given an array which is first strictly increasing and then strictly decreasing. Find an element in this array.
    class ArraySearching
    {

        public void run() {
            int[] arr = { 1, 30, 40, 50, 60, 70, 23, 20 };
            int n = arr.Length;
            Console.Write("The maximum element is " +
                            findMaximum(arr, 0, n - 1));
        }

        //We can traverse the array and keep track of maximum and element. And finally return the maximum element. 
        // function to find the
        // maximum element
        static int findMaximum(int[] arr, int low, int high)
        {
            int max = arr[low];
            int i;
            for (i = low; i <= high; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
    }

    
}
