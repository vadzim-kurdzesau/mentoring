namespace DesignPatterns.Patterns.Functions
{
    public class SquareRootFunction : IFunction
    {
        public int Calculate(int number)
        {
            return (int)Math.Sqrt(number);
        }
    }
}
