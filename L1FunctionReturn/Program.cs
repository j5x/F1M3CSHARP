using System;

namespace L1FunctionReturn
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine(Name("Jason", "Siegersma")); }

        static string Name(string firstName, string lastName)
        {
            string separator = ",";
            string result = lastName + separator + firstName;
            return result;
        }

    }
}
