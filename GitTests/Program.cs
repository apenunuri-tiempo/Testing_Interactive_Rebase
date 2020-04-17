using System;

namespace GitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Method_BranchA());
            Console.ReadLine();

        }

        private static string Method_BranchA()
        {
            return "Method from Branch A";
        }
    }
}
