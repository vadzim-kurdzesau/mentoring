using System;

namespace CollectionsSwitchEnums.Enums
{
    // Note that Flag enums are named as plural
    // TODO: show why flags require numbers of power of two
    [Flags]
    public enum BitMonths
    {
        January = 0,
        Febriary = 1,
        March = 2,
        April = 4,
        May = 8,
        June = 16,
        July = 32,
        August = 64,
        September = 128,
        October = 256,
        November = 512,
        December = 1024,
    }

    public class EnumFlags
    {
        public static void DemonstrateEnumFlagsBasics()
        {
            // December = 0100 0000 0000
            // January  = 0000 0000 0000
            // Febriary = 0000 0000 0001

            // December | January | Febriary:
            //          = 0100 0000 0001
            //          & 0001 0000 0000
            //          = 0000 0000 0000

            // December & (December | January | Febriary):
            // December = 0100 0000 0000
            //          & 0100 0000 0001
            //          = 0100 0000 0000

            BitMonths month = BitMonths.October;
            bool isWinter = (month & (BitMonths.December | BitMonths.January | BitMonths.Febriary)) == BitMonths.October;
            if (isWinter)
            {
                Console.WriteLine($"{month} is in Winter.");
            }
            else
            {
                Console.WriteLine($"{month} is NOT in Winter.");
            }
        }

        public static void DemonstrateEnumFlags()
        {
            string testInput = " Test message with, a lot , of commas here, ";
            string[] words = testInput.Split(separator: new char[] { ',' }, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Console.WriteLine($"The next word: '{word}'");
            }
        }
    }
}
