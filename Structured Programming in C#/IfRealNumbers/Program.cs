namespace IfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 = 0010
            // =   0100
            // 8 = 1000

            // 4 = 0100



            int number = 8;
            Console.WriteLine(number);
            Console.WriteLine(number >> 1);

            #region Declaration

            //float floatValue = 0.0F;
            //double doubleValue = 0.0;
            //decimal decimalValue = 0.0M;

            // TODO: Show "var" keyword
            // NOTE! var - is NOT a dynamic type!

            #endregion

            #region Basics

            //double firstNumber = 30.5;
            //double secondNumber = 50.45;

            //double result = firstNumber + secondNumber;
            //Console.WriteLine(result);

            //Console.WriteLine(firstNumber - secondNumber);

            //Console.WriteLine(firstNumber * secondNumber);

            //// Note that adding '.' converts integer literal to double 
            //Console.WriteLine(5.0 / 2);

            #endregion

            #region Conversion

            //float anotherFloatValue = 1.2345F;
            //double anotherDoubleValue = anotherFloatValue;

            //float doubleToFloat = anotherDoubleValue;

            #endregion

            #region Floating Point Quirks

            //// Unexpected precision
            //double sum = 0.1 + 0.2;
            //Console.WriteLine(sum == 0.3);
            //Console.WriteLine(sum);

            //#region Solving the Issue

            //Console.WriteLine(AreEqual(sum, 0.3, precision: 0.00000000000000000001));

            //bool AreEqual(double firstNumber, double secondNumber, double precision)
            //{
            //    // TODO: show Math namespace functions
            //    var test = firstNumber - secondNumber;
            //    return Math.Abs(firstNumber - secondNumber) < precision;
            //}

            //#endregion

            #endregion
        }


    }
}
