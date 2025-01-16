using System;
using System.Collections.Generic;

namespace CollectionsSwitchEnums.Collections
{
    public class ListBasics
    {
        public static void DemonstrateArrayResizing()
        {
            int[] numbers = new int[3] { 1, 2, 3 };

            // Create bigger array
            int[] moreNumbers = new int[numbers.Length + 1];

            // Copy smaller array values into the bigger one
            numbers.CopyTo(moreNumbers, index: 0);

            // Add new number
            moreNumbers[moreNumbers.Length - 1] = 4;
        }

        // NOTE! We use System.Collections.Generic namespace instead of just System.Collections
        public static void DemonstrateListBasics()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };
            numbers.Add(4);

            // List.Count == Array.Length 
            for (int i = 0; i < numbers.Count; i++)
            {
                // Indexes!
                Console.WriteLine(numbers[i]);
            }

            // NOTE! Capacity property and the ctor parameter for it
            Console.WriteLine($"Number of elements in list: {numbers.Count}. Capacity: {numbers.Capacity}");
            numbers.Add(5);
            Console.WriteLine($"Number of elements in list: {numbers.Count}. Capacity: {numbers.Capacity}");

            // Insert in the middle of the list affects performance on a large scale
            // As all values after the inserted item have to be moved one element forward
            // For such cases better use LinkedList
            numbers.Insert(index: 2, item: 10);

            // The same applies to Remove and RemoveAt
            numbers.Remove(item: 10);
            numbers.RemoveAt(index: 2);

            // Uses quick sort
            numbers.Sort();

            // Removes all values. NOTE! Capacity doesn't change (inner array is not resized)
            numbers.Clear();
        }
    }
}
