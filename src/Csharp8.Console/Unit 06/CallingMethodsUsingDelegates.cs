using Csharp8.Console.Factory.Product;
using static System.Console;

namespace Csharp8.Console.Unit_06
{
    public class CallingMethodsUsingDelegates : CodeSampleRunner
    {
        private static int MethodIWantToCall(string input) =>
            input.Length;
        private static int MethodIWantToCall() => 0;

        public override void Execute()
        {
            //Create delegate instances that points to methods
            var delegateWithParameter = new DelegateWithParameter(MethodIWantToCall);
            var delegateWithoutParameter = new DelegateWithoutParameter(MethodIWantToCall);

            //Call the delegate, which calls the methods
            int result = delegateWithParameter("call method using delegates");
            int result2 = delegateWithoutParameter();

            WriteLine($"Execution of an delegate with parameter: {result}");
            WriteLine($"Execution of an delegate without parameter: {result2}");
        }

    }

    delegate int DelegateWithParameter(string s);
    delegate int DelegateWithoutParameter();
}
