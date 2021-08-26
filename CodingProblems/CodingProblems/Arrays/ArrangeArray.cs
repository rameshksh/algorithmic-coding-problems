using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    //Given an array, arrange the elements such that the number formed by concatenating the elements is highest.
    //E.g.: input = [9, 93, 24, 6],
    //the output should be: [9,93,6,24].
    //This is because if you concatenate all the numbers,
    //993624 is the highest number that can be formed.

    public class ArrangeArray
    {
        public void run() {
            List<int> inputList
                = new List<int>() { 54, 546, 548, 60 };
            LargestNumberClass.LargestNumberMethod(inputList);
        }        
    }

    public class LargestNumberClass
    {
        // Given a list of non-negative
        // integers,
        // arrange them such that they
        // form the largest number.
        // Note: The result may be very
        // large, so you need to
        // return a string instead
        // of an integer.
        public static void LargestNumberMethod(List<int> inputList)
        {
            string output = string.Empty;

            List<string> newList = inputList.ConvertAll<string>(delegate (int i) { return i.ToString(); });

            newList.Sort(MyCompare);

            for (int i = 0; i < inputList.Count; i++)
            {
                output = output + newList[i];
            }

            if (output[0] == '0' && output.Length > 1)
            {
                Console.Write("0");
            }
            Console.Write(output);
        }

        internal static int MyCompare(string X, string Y)
        {
            // first append Y at the end of X
            string XY = X + Y;

            // then append X at the end of Y
            string YX = Y + X;

            // Now see which of the two
            // formed numbers is greater
            return XY.CompareTo(YX) > 0 ? -1 : 1;
        }
    }
}
