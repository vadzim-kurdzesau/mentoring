using System.Collections;

namespace Generics.Demo
{
    internal static class BoxingProblem
    {
        public static void Demonstrate()
        {
            int number = 5;
            PrintValue(number);

            string text = "Five";
            PrintValue(text);

            #region Type Safety Issue

            //ArrayList list = new ArrayList();
            //list.Add(8);
            //list.Add(9);
            //list.Add("Ten");

            //int sum = 0;
            //foreach (int item in list)
            //{
            //    sum += item;
            //}

            //Console.WriteLine(sum);

            #endregion
        }

        #region First Solution

        public interface INumber
        {
            INumber Add(INumber value);
        }

        public class NumberList
        {
            private readonly INumber[] _numbers = new INumber[4];
            private int _currentIndex = 0;

            public void Add(INumber number)
            {
                _numbers[_currentIndex++] = number;
            }
        }

        #endregion

        private static void PrintValue(object value)
        {
            string message = $"Printing value: {value.ToString()} of type \"{value.GetType()}\".";
            Console.WriteLine(message);
        }
    }
}
