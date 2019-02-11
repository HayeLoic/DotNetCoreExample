using DotNetCoreExampleLibrary;
using System;

namespace DotNetCoreExampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExampleConsoleAppProcessor ExampleConsoleAppProcessor = new ExampleConsoleAppProcessor(new AgeCalculator());
                ExampleConsoleAppProcessor.AskDateAndCalculateAge();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadKey();
            }
        }
    }
}
