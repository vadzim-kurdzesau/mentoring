namespace IfRealNumbers
{
    internal class IfStatements
    {
        public static int DoSomething(int i)
        {
            int result = i;
            if (result < 0)
            {
                result = 0;
            }

            return result;
        }

        public static int GetFactorialOf(int number)
        {
            bool equalsZero = number == 0;
            if (equalsZero)
            {
                return 1;
            }

            return number * GetFactorialOf(number - 1);
        }

        //static int GetFactorialOf(int number)
        //{
        //    if (number == 0)
        //    {
        //        return 1;
        //    }

        //    return number * GetFactorialOf(number - 1);
        //}

        public static int GetFibonacci(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            if (number == 1)
            {
                return 1;
            }

            return GetFibonacci(number - 2) + GetFibonacci(number - 1);
        }
    }
}
