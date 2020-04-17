using System;

namespace GitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Method_BranchA());
            Console.WriteLine(Method_BranchB());
            Console.ReadLine();

        }

        private static string Method_BranchA()
        {
            return "Method from Branch A";
        }

        private static string Method_BranchB()
        {
            return "Method from Branch B";
        }
    }
}
