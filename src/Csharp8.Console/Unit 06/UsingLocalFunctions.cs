using Csharp8.Console.Factory.Product;
using System;
using static System.Console;

namespace Csharp8.Console.Unit_06
{
    public class UsingLocalFunctions: CodeSampleRunner
    {
        //Method with a local function
        private static int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException(nameof(number) + "cannot be less than zero.");


            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        public override void Execute()
        {
            int number = 5;
            WriteLine($"The factorial of {number} is: {Factorial(5)}");
        }

    }
}
