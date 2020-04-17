using System;

namespace GitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Method_Branch1());
            Console.WriteLine(Method_Branch2());
            Console.ReadLine();
        }

        private static string Method_Branch1()
        {
            return "Method from Branch 1";
        }

        private static string Method_Branch2()
        {
            return "Method from Branch 2";
        }
    }
}
