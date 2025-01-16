namespace DesignPatterns.Patterns.Functions
{
    public class PowerOfTwoFunction : IFunction
    {
        public int Calculate(int number)
        {
            return number * number;
        }
    }
}
