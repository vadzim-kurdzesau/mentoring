using System;
using System.Collections.Generic;

namespace CollectionsSwitchEnums.Collections
{
    public class DictionaryBasics
    {
        public static void DemonstrateDictionaryBasics()
        {
            Dictionary<int, string> digitNames = new Dictionary<int, string>()
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" }
            };

            string nameOf1 = digitNames[1];
            Console.WriteLine(nameOf1);

            Dictionary<string, int> digitsByNames = new Dictionary<string, int>()
            {
                { "One", 1 },
                { "Two", 2 },
                { "Three", 3 },
                { "Four", 4 },
                { "Five", 5 }
            };

            string userInput = Console.ReadLine();

            foreach (var pair in digitsByNames)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            //int inputNumber = digitsByNames[userInput]; // Possible error

            if (!digitsByNames.TryGetValue(key: userInput, out int inputNumber))
            {
                Console.WriteLine("Input is not a valid number.");
                return;
            }

            // [ 2, 15, 5, ..., 1000]

            // HashSet

            // 153
            // John Smith
            // Ivan Ivanov

            // John Smith => 153
            // Ivan Ivanov => 153

            LinkedList<string> digits = new LinkedList<string>();
            int index = 0;
            foreach (var digit in digits)
            {
                index++;
            }

            var a = new object();

            HashSet<string> set = new HashSet<string>();
            set.Add("Ivan Ivanov");

            Console.WriteLine(inputNumber);

            digitsByNames["Ten"] = 10;

            if (!digitsByNames.ContainsKey("Ten"))
            {
                digitsByNames.Add("Ten", value: 10);
            }
        }
    }
}
