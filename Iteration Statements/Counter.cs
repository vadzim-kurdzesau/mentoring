namespace StructuredProgramming.IterationStatements;

public class Counter
{
    /// <summary>
    /// Counts and prints a counted value up to the specified <paramref name="numberOfTimes"/>.
    /// </summary>
    //public static void Count(int numberOfTimes)
    //{
    //    int currentCount = 1;
    //    while (currentCount <= numberOfTimes)
    //    {
    //        Console.WriteLine("Current count: " + currentCount);
    //        currentCount++;
    //    }
    //}

    public static void Count(int numberOfTimes)
    {
        for (int currentCount = 1; currentCount <= numberOfTimes; currentCount++)
        {
            Console.WriteLine("Current counter: " + currentCount);
        }
    }
}