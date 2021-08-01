using static System.Console;
using Csharp8.Console.Factory;
using Csharp8.Console.Factory.Creator;
using System;
using System.Linq;

PrintMenuOptions();

static void PrintMenuOptions()
{
    WriteLine("Select an option to run:");
    WriteLine();

    var enumValues = Enum.GetValues(typeof(Sample)).Cast<Sample>().ToList();
    enumValues.ForEach(x => WriteLine($"{(int)x} - {x}"));

    WriteLine();

    int.TryParse(ReadLine(), out int option);
    Clear();

    RunSample(option);
}

static void RunSample(int option)
{
    CodeSampleCreator.SampleRunnerFactory((Sample)option)
        .Create()
        .Execute();
}




