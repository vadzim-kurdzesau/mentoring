using System;
using System.Collections.Generic;

namespace CollectionsSwitchEnums.Collections
{
    public class StackBasics
    {
        public static void DemonstrateStackBasics()
        {
            // Does not have initializer!
            Stack<string> words = new Stack<string>();

            words.Push("First word");
            words.Push("Second word");

            string wordOnTop = words.Pop();
            Console.WriteLine(wordOnTop);

            string remainingWord = words.Peek();
            Console.WriteLine(remainingWord);

            // NOTE! Doesn't have indexing
            //string firstWord = words[0];
        }
    }
}
