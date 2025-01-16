namespace StructuredProgramming.IterationStatements;

public class JumpStatements
{
    //public static void PrintEvenNumbers(int upTo)
    //{
    //    for (int currentNumber = 1; currentNumber <= upTo; currentNumber++)
    //    {
    //        if (currentNumber % 2 != 0)
    //        {
    //            continue;
    //        }

    //        Console.WriteLine(currentNumber);
    //    }
    //}

    //public static void PrintEvenNumbers(int upTo)
    //{
    //    int currentNumber = 0;
    //    while (currentNumber <= upTo)
    //    {
    //        currentNumber++;
    //        // 5 / 2 = 2
    //        // 5 - (5 / 2) = 1
    //        if (currentNumber % 2 != 0)
    //        {
    //            continue;
    //        }

    //        Console.WriteLine(currentNumber);
    //    }
    //}

    //public static void PrintEvenNumbers(int upTo)
    //{
    //    int currentNumber = 0;
    //    do
    //    {
    //        currentNumber++;
    //        if (currentNumber % 2 != 0)
    //        {
    //            continue;
    //        }

    //        Console.WriteLine(currentNumber);
    //    }
    //    while (currentNumber <= upTo);
    //}

    public static void PrintWhileValid(int upTo)
    {
        for (int i = 0; i < upTo; i++)
        {
            if (!IsValid(i))
            {
                break;
            }

            Console.WriteLine(i);
        }
    }

    private static bool IsValid(int value)
    {
        return value <= 5;
    }
    
    public static void InterruptedCount(int skipAfterEach)
    {
        //    1 2 3 4 5 6 7 8
        // 1| a b c d e f g h
        // 2| i j k l m n o p
        // 3| q r s t u v w x

        for (int i = 10; i < 1000; i += 10)
        {
            for (int j = 0; j < skipAfterEach; j++)
            {
                Console.WriteLine(i + j);
            }

            Console.WriteLine("Left the inner loop.");
        }
    }

    public static void PrintMultiplicationTable()
    {
        // 0   1 2 3 4
        // 1 | 1 2 3 4
        // 2 | 2 4 6 8
        // 3 | 3 6 9 12

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
        }

        int x = 1;
        while (x <= 9)
        {
            int y = 1;
            while (y <= 9)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
                y++;
            }

            x++;
        }
    }
}