using System;
using System.Collections.Generic;

namespace CollectionsSwitchEnums.Collections
{
    public class ForeachBasics
    {
        public static void DemonstrateForeachBasics()
        {
            List<string> words = new List<string>()
            {
                "First",
                "Second",
                "Third",
                "Fourth",
                "Fifth"
            };

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                Console.WriteLine(word);
            }

            int[] numbers = new int[] { 1, 2, 3 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // NOTE! You cannot change collection while iterating through it
            foreach (string word in words)
            {
                words.Add(word);
            }
        }
    }
}
