namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IncrementByOne(1);

            #region Value Type Parameters
            //int half = IsSplittable(number) ? number / 2 : number;

            //Console.WriteLine(int.TryParse(Console.ReadLine(), out int input));
            //Console.WriteLine(IsSplittable(number));
            //Console.WriteLine(number);

            //int number;
            //Console.WriteLine(IsSplittable(out number));

            //Console.WriteLine(number);
            //Console.WriteLine(number);

            #endregion
        }

        #region Simple method

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void WriteNumber(int number)
        {
            Console.WriteLine(number);
        }

        #endregion

        #region Return types

        static int GetPowerOfTwo(int number)
        {
            return number * number;
        }

        #endregion

        #region Value Type Parameters

        static bool IsSplittable(int number)
        {
            number = 5;
            return false;

            //bool isSplitable = (number % 2 == 0);

            ////number /= 2;

            //return isSplitable;
        }

        #endregion

        #region Method Overloading

        //static int Divide(int number)
        //{
        //    int result = number / 2;
        //    return result;
        //}

        //static int Divide(int firstNumber, int secondNumber )
        //{
        //    int result = firstNumber / secondNumber;
        //    return result;
        //}

        static int Divide(int firstNumber, int secondNumber = 2, int thirdNumber = 3)
        {
            int result = firstNumber / secondNumber / thirdNumber;
            return result;
        }

        // static long Divide(int firstNumber, int secondNumber, int thirdNumber)
        // {
        //     long result = firstNumber / secondNumber / thirdNumber;
        //     return result;
        // }

        // static int Divide(long firstNumber, int secondNumber, int thirdNumber)
        // {
        //     long result = firstNumber / secondNumber / thirdNumber;
        //     return (int)result;
        // }

        #endregion

        #region Recursion

        // Recursion could be accidental and cause stack overflow
        static int IncrementByOne(int value)
        {
            return IncrementByOne(value + 1);
        }

        // Or can be used in algorithms
        static int GetFactorialOf(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * GetFactorialOf(number - 1);
        }

        #endregion

        #region TODO

        // TODO: Default values

        // TODO: Pass Named Arguments (write a complete mess of a code)

        // Console.WriteLine - static method of class Console

        #endregion
    }
}


