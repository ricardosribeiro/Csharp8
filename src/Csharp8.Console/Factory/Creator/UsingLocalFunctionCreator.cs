using Csharp8.Console.Factory.Product;
using Csharp8.Console.Unit_06;

namespace Csharp8.Console.Factory.Creator
{
    class UsingLocalFunctionCreator : CodeSampleCreator
    {
        public override CodeSampleRunner Create()
        {
            return new UsingLocalFunctions();
        }
    }
}
