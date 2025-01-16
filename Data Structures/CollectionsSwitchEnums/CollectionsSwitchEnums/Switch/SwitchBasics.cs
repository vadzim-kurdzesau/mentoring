using System;
using System.Text;

namespace CollectionsSwitchEnums.Switch
{
    public class SwitchBasics
    {
        public static void DemonstrateSwitchBasics()
        {
            string userInput = Console.ReadLine();
            //if (userInput == "1")
            //{
            //    Console.WriteLine("First option was selected.");
            //    return;
            //}
            //else if (userInput == "2")
            //{
            //    Console.WriteLine("Second option was selected.");
            //    return;
            //}
            //else if (userInput == "3")
            //{
            //    Console.WriteLine("Third option was selected.");
            //    return;
            //}
            //else if (userInput == "4")
            //{
            //    Console.WriteLine("Fourth option was selected.");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("ERROR: Invalid option was selected.");
            //    //return;
            //}

            switch (userInput)
            {
                case "1":
                case "2":
                    Console.WriteLine("First or second option was selected.");
                    break;
                case "3":
                    Console.WriteLine("Third option was selected.");
                    break;
                case "4":
                    Console.WriteLine("Fourth option was selected.");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid option was selected.");
                    break;
            }
        }

        public static void ExecuteOption(string option)
        {
            const string FirstOption = "1";
            switch (option)
            {
                case FirstOption:
                case "2":
                    Console.WriteLine("First or second option was selected.");
                    break;
                case "3":
                    Console.WriteLine("Third option was selected.");
                    break;
                case "4":
                    Console.WriteLine("Fourth option was selected.");
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid option was selected.");
                    break;
            }
        }

        public static void DemonstrateSwitchExpressionBasics()
        {
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out var number))
            {
                Console.WriteLine($"'{userInput}' is not a valid number!");
                return;
            }

            //if (number < 0)
            //{
            //    Console.WriteLine($"'{number}' is negative.");
            //    return;
            //}
            //else if (number == 0)
            //{
            //    Console.WriteLine("Number equals zero.");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine($"'{number}' is positive.");
            //    //return;
            //}

            string message = number switch
            {
                < 0 and > -10 => $"'{number}' is negative and single digit.",
                < 0 => $"'{number}' is negative.",
                0 => "Number equals zero.",
                _ => $"'{number}' is positive."
            };

            Console.WriteLine(message);
        }

        //public static string CheckNumber(int number) => number switch
        //{
        //    < 0 and > -10 => $"'{number}' is negative and single digit.",
        //    < 0 => $"'{number}' is negative.",
        //    0 => "Number equals zero.",
        //    _ => $"'{number}' is positive."
        //};
    }
}
