using System;
using System.Text;
using LegacyCodeLibrary;

namespace SampleLegacyConsoleApp
{
    class Program
    {
        // CHALLENGE #1: How would you document what this method does?
        // CHALLENGE #2: How do you change it with 100% confidence that it works the same way as it did before?               
        static void Main(string[] args)
        {
            // TODO: How would you test this code?             
            Console.WriteLine(Formatter.FormatText("<test/>"));
            
            return;
        }
    }
}