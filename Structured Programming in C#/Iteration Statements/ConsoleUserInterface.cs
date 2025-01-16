namespace StructuredProgramming.IterationStatements;

public class ConsoleUserInterface
{
    /// <summary>
    /// Requests user to enter an integer.
    /// </summary>
    //public static int RequestInteger()
    //{
    //    int result;

    //    string userInput = RequestInput();
    //    while (!int.TryParse(userInput, out result))
    //    {
    //        RequestInput();
    //    }

    //    return result;
    //}

    private static string RequestInput()
    {
        Console.Write("Enter an integer: ");
        return Console.ReadLine();
    }

    public static int RequestInteger()
    {
        int result;
        string userInput;
        do
        {
            userInput = RequestInput();
        }
        while (!int.TryParse(userInput, out result));

        return result;
    }

    // public static void SummonInfiniteLoop()
    // {
    //     while (true)
    //     {
    //         // Some code here
    //     }
    // }

    /// <summary>
    /// Prints number in the range of the <paramref name="start"/> and <paramref name="end"/> values.
    /// </summary>
    // public static void PrintRange(int start, int end)
    // {
    //     for (int i = start; i < end; i--)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }
}