using Csharp8.Console.Factory.Product;
using System;

namespace Csharp8.Console.Factory.Creator
{
    public abstract class CodeSampleCreator
    {
        public abstract CodeSampleRunner Create();

        public static CodeSampleCreator SampleRunnerFactory(Sample sample)
        {
            if (sample == Sample.CallingMethodsUsingDelegates)
                return new CallingMethodsUsingDelegatesCreator();
            if (sample == Sample.UsingLocalFunctions)
                return new UsingLocalFunctionCreator();

            throw new ApplicationException("error");
        }
    }
    
}
