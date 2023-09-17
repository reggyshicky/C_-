﻿// C# program to illustrate creating an array
// of integers, puts some values in the array,
// and prints each value to standard output.
//Time Complexity of this program is O(n)
//space complexity for this program is O(n)
using System;
namespace geeksforgeeks
{

    class GFG
    {

        // Main Method
        public static void Main()
        {

            // declares an Array of integers.
            int[] intArray;

            // allocating memory for 5 integers.
            intArray = new int[5];

            // initialize the first elements
            // of the array
            intArray[0] = 10;

            // initialize the second elements
            // of the array
            intArray[1] = 20;

            // so on...
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements
            // using for loop
            Console.Write("For loop :");
            for (int i = 0; i < intArray.Length; i++)
                Console.Write(" " + intArray[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop
            foreach (int i in intArray)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop
            int j = 0;
            while (j < intArray.Length)
            {
                Console.Write(" " + intArray[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop
            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);
        }
    }
}
