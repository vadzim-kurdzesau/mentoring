using System;

namespace WorkingWithStrings.Demo;

public class Program
{
    private static void Main()
    {
        string sourceMessage = "    Hello, World!    ";

        // Getting the string length
        // String concatenation via '+' operator
        int messageLength = sourceMessage.Length;
        Console.WriteLine("Message length is " + messageLength);

        PrintSeparationLine();

        // Accessing string characters by index
        // String concatenation via string.Concat
        for (int i = 0; i < messageLength; i++)
        {
            string message = string.Concat(i, ") ", sourceMessage[i]);
            Console.WriteLine(message);
        }

        PrintSeparationLine();

        DemonstateStringTrimming(sourceMessage);

        PrintSeparationLine();
    }

    private static void DemonstateStringTrimming(string sourceMessage)
    {
        // String trimming and string interpolation/string.Format
        string trimmedMessage = sourceMessage.Trim();
        Console.WriteLine($"The source message '{sourceMessage}' has been trimmed to '{trimmedMessage}'.");

        string anotherMessage = "####SpamMessage###";
        string anotherTrimmedMessage = anotherMessage.Trim('#');
        Console.WriteLine(string.Format("The source message '{0}' has been trimmed to '{1}'.", anotherMessage, anotherTrimmedMessage));
    }

    private static void PrintSeparationLine()
    {
        Console.WriteLine("==============================================");
    }
}