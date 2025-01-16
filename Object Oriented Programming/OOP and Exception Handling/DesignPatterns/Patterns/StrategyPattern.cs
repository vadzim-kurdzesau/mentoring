using DesignPatterns.Patterns.Functions;

namespace DesignPatterns.Patterns
{
    public class StrategyPattern
    {
        private readonly IFunction _function;

        public StrategyPattern(IFunction function)
        {
            _function = function;
        }

        // Strategy pattern
        public void Calculate(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = _function.Calculate(numbers[i]);
            }
        }
    }
}
