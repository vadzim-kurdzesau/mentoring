using System;
using System.Collections.Generic;

namespace CollectionsSwitchEnums.Collections
{
    public class QueueBasics
    {
        public static void DemonstrateQueueBasics()
        {
            // Does not have initializer!
            Queue<string> names = new Queue<string>();

            names.Enqueue("Bob");
            names.Enqueue("John");

            string firstName = names.Dequeue();
            Console.WriteLine($"The first name in the queue: '{firstName}'");

            string currentFirstName = names.Peek();
            Console.WriteLine($"Current first name in the queue: '{currentFirstName}'");

            // NOTE! Doesn't have indexing
            //firstName = names[0];
        }
    }
}
