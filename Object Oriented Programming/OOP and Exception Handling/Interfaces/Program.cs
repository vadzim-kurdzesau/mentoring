using Interfaces.Demo.Examples;
using Interfaces.Demo.Functions;

namespace Interfaces.Demo
{
    internal class Program
    {
        public class ReverseComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x < y) return 1;
                if (x > y) return -1;
                return 0;
            }
        }

        public static void Main()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var calculator = new Calculator();

            var powerOfTwoFunction = new PowerOfTwoFunction();
            var squareRootFunction = new SquareRootFunction();

            PrintNumbers(numbers);

            calculator.Calculate(numbers, powerOfTwoFunction);
            PrintNumbers(numbers);

            calculator.Calculate(numbers, squareRootFunction);
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(int[] numbers)
        {
            var message = string.Join(", ", numbers.Select(n => n.ToString()));
            Console.WriteLine($"Numbers array: {{ {message} }}.");
        }
    }
}