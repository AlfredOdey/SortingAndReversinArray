using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndReversingArray
{
    internal class Program
    {
        /*
        Question 6: Sorting and Reversing an Array
        Create an array of integers with the values
        {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5}.
        Sort the array.
        Reverse the array.
        Print all elements in the array.
        */
        static void Main(string[] args)
        {
            int[] integers = { 3, 1, 4, 5, 9, 2, 6, 5, 3, 5 };

            Console.WriteLine("Sorted in FORWARD order.\n");
            Array.Sort(integers);

            foreach (int integer in integers)
            {
                Console.Write(integer);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Sorted in REVERSE order.\n");
            Array.Reverse(integers);

            foreach (int integer in integers)
            {
                Console.Write(integer);
            }
        }
    }
}
