using System;

namespace Practice
{
    internal class ArraySample
    {
        public ArraySample()
        {
        }

        internal void arrayTest()
        {
            //W.A.P to take inputs from the user and store in an array and print the array.
            int[] arr = new int[3];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}